namespace ShoesStore_LB42_main
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTop = new Panel();
            dtgvProducts = new DataGridView();
            btnLogin = new Button();
            lblUserName = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblUserName);
            panelTop.Controls.Add(btnLogin);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(0, 0, 0, 10);
            panelTop.Size = new Size(964, 40);
            panelTop.TabIndex = 0;
            // 
            // dtgvProducts
            // 
            dtgvProducts.AllowUserToAddRows = false;
            dtgvProducts.AllowUserToDeleteRows = false;
            dtgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvProducts.BackgroundColor = Color.White;
            dtgvProducts.BorderStyle = BorderStyle.None;
            dtgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
            dtgvProducts.Dock = DockStyle.Fill;
            dtgvProducts.Location = new Point(10, 50);
            dtgvProducts.MultiSelect = false;
            dtgvProducts.Name = "dtgvProducts";
            dtgvProducts.ReadOnly = true;
            dtgvProducts.RowHeadersVisible = false;
            dtgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvProducts.Size = new Size(964, 601);
            dtgvProducts.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSpringGreen;
            btnLogin.Dock = DockStyle.Right;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(797, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(752, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 661);
            Controls.Add(dtgvProducts);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Products";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список товаров";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private DataGridView dtgvProducts;
        private Label lblUserName;
        private Button btnLogin;
    }
}