using Microsoft.EntityFrameworkCore;
using ShoesStore_LB42_main.Models;
using ShoesStore_LB42_main.Properties;

namespace ShoesStore_LB42_main
{
    public partial class FormProducts : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormProducts(User user, bool guest)
        {
            InitializeComponent();

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "colDiscount";
            colDiscount.FillWeight = 10;
            colDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvProducts.Columns.AddRange(
            [
                colPhoto,colInfo,colDiscount
            ]);

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadProducts();
            dgvProducts.CellPainting += dgvProducts_CellPainting;
        }

        private void LoadProducts()
        {
            try
            {
                using (var db = new ShopDbContext())
                {
                    var products = db.Product
                        .Include(i => i.Category)
                        .Include(i => i.Manufacturer)
                        .Include(i => i.Supplier)
                        .Include(i => i.Measure)
                        .Include(i => i.ProductType)
                        .ToList();

                    dgvProducts.Rows.Clear();

                    foreach (var product in products)
                    {
                        int rowIndex = dgvProducts.Rows.Add();
                        var row = dgvProducts.Rows[rowIndex];

                        row.Cells["colPhoto"].Value = LoadProductImage(product.PhotoUrl);

                        row.Cells["colInfo"].Value = FormatProductInfo(product);

                        row.Cells["colDiscount"].Value = $"{product.Discount}%";
                        row.Cells["colDiscount"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        ApplyRowStyles(row, product);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyRowStyles(DataGridViewRow row, Product product)
        {
            if (product.Discount > 15)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");
                row.DefaultCellStyle.ForeColor = Color.White;
            }

            //if (product.Discount <= 15)
            //{
            //    row.DefaultCellStyle.ForeColor = Color.Black;
            //}

            //if (product.Discount > 0)
            //{
            //    row.Cells["colDiscount"].Style.ForeColor = Color.Red;
            //    row.Cells["colDiscount"].Style.Font = new Font(
            //        "Times New Roman",
            //        12,
            //        FontStyle.Bold);
            //}
            if (product.CointInStock <= 0)
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue;

            }
        }

        private string FormatProductInfo(Product product)
        {
            string priceText;

            if (product.Discount > 0)
            {
                decimal finalPrice = product.Price * (100 - product.Discount) / 100;
                priceText = $"{product.Price:C} -> {finalPrice:C}";
            }
            else
            {
                priceText = $"{product.Price:C}";
            }

            return $"{product.Category.CategoryName} | {product.ProductType.ProdType} " + Environment.NewLine +
                $"Описание товара: {product.Description}" + Environment.NewLine +
                $"Производитель: {product.Manufacturer.ManufacturerName}" + Environment.NewLine +
                $"Поставщик: {product.Supplier.SupplierName}" + Environment.NewLine +
                $"Цена: {priceText}" + Environment.NewLine +
                $"Единица измерения: {product.Measure.MeasureName}" + Environment.NewLine +
                $"Количество на складе: {product.CointInStock}";

        }

        private Image LoadProductImage(string photoUrl)
        {
            if (!String.IsNullOrEmpty(photoUrl) && System.IO.File.Exists(photoUrl))
            {
                return Image.FromFile(photoUrl);
            }

            return Resources.picture;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void dgvProducts_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        { }

        //private void dgvProducts_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex == dgvProducts.Columns["colInfo"].Index)
        //    {
        //        string text = e.Value?.ToString();
        //        if (string.IsNullOrEmpty(text))
        //        {
        //            e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
        //            e.Handled = true;
        //            return;
        //        }

        //        string[] lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
        //        float y = e.CellBounds.Top + 2; // небольшой отступ сверху
        //        Font font = e.CellStyle.Font;

        //        e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

        //        foreach (string line in lines)
        //        {
        //            if (line.StartsWith("Цена: ") && line.Contains(" -> "))
        //            {
        //                // Пример: "Цена: 5 000,00 ₽ -> 4 250,00 ₽"
        //                int arrowIndex = line.IndexOf(" -> ");
        //                string beforeArrow = line.Substring(0, arrowIndex);      // "Цена: 5 000,00 ₽"
        //                string afterArrow = line.Substring(arrowIndex + " -> ".Length); // "4 250,00 ₽"

        //                string label = "Цена: ";
        //                string oldPrice = beforeArrow.Substring(label.Length); // "5 000,00 ₽"

        //                float x = e.CellBounds.Left + 2;

        //                // 1. Рисуем "Цена: "
        //                SizeF labelSize = e.Graphics.MeasureString(label, font);
        //                e.Graphics.DrawString(label, font, Brushes.Black, x, y);
        //                x += labelSize.Width;

        //                // 2. Рисуем старую цену (чёрным)
        //                SizeF oldPriceSize = e.Graphics.MeasureString(oldPrice, font);
        //                e.Graphics.DrawString(oldPrice, font, Brushes.Black, x, y);
        //                // Зачёркиваем старую цену
        //                float strikeY = y + oldPriceSize.Height / 2;
        //                e.Graphics.DrawLine(Pens.Black, x, strikeY, x + oldPriceSize.Width, strikeY);
        //                x += oldPriceSize.Width;

        //                // 3. Рисуем новую цену (красным)
        //                e.Graphics.DrawString(afterArrow, font, Brushes.Red, x, y);
        //            }
        //            else
        //            {
        //                // Обычная строка — рисуем чёрным
        //                e.Graphics.DrawString(line, font, Brushes.Black, e.CellBounds.Left + 2, y);
        //            }

        //            // Переход на следующую строку
        //            SizeF lineSize = e.Graphics.MeasureString(line, font);
        //            y += lineSize.Height + 1;
        //        }

        //        e.Handled = true;
        //    }
        //}
    }
}
