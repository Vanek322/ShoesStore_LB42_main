using Microsoft.EntityFrameworkCore;
using ShoesStore_LB42_main.Models;
using ShoesStore_LB42_main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoesStore_LB42_main
{
    public partial class FormOrders : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormOrders(User user, bool guest)
        {
            InitializeComponent();

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 80;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDeliveryDate = new DataGridViewTextBoxColumn();
            colDeliveryDate.Name = "colDeliveryDate";
            colDeliveryDate.FillWeight = 20;
            colDeliveryDate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvOrders.Columns.AddRange(
            [
                colInfo,colDeliveryDate
            ]);

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (var db = new ShopDbContext())
                {
                    var orders = db.Orders
                       .Include(i => i.Status)
                       .Include(i => i.DeliveryPoint)
                       .ToList();

                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["colInfo"].Value = FormatOrderInfo(order);

                        row.Cells["colDeliveryDate"].Value = $"{order.DeliveryDate}";
                        row.Cells["colDeliveryDate"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        //ApplyRowStyles(row, product);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void ApplyRowStyles(DataGridViewRow row, Product product)
        //{
        //    if (product.Discount > 15)
        //    {
        //        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");
        //        row.DefaultCellStyle.ForeColor = Color.White;
        //    }

        //    if (product.Discount <= 15)
        //    {
        //        row.DefaultCellStyle.ForeColor = Color.Black;
        //    }

        //    if (product.Discount > 0)
        //    {
        //        row.Cells["colDiscount"].Style.ForeColor = Color.Red;
        //        row.Cells["colDiscount"].Style.Font = new Font(
        //            "Times New Roman",
        //            12,
        //            FontStyle.Bold);
        //    }
        //    if (product.CointInStock <= 0)
        //    {
        //        row.DefaultCellStyle.ForeColor = Color.LightBlue;

        //    }
        //}

        private string FormatOrderInfo(Order order)
        {
            return $"Артикул: {order.Id}" + Environment.NewLine +
                $"Статус: {order.Status.StatusName}" + Environment.NewLine +
                $"Пункт выдачи: {order.DeliveryPoint.DeliveryAddress}" + Environment.NewLine +
                $"Дата заказа: {order.OrderDate}";
        }

        //private Image LoadProductImage(string photoUrl)
        //{
        //    if (!String.IsNullOrEmpty(photoUrl) && System.IO.File.Exists(photoUrl))
        //    {
        //        return Image.FromFile(photoUrl);
        //    }

        //    return Resources.picture;
        //}

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}
