namespace ShoesStore_LB42_main
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pbLogo = new PictureBox();
            pnMain = new Panel();
            btnGuest = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lbPassword = new Label();
            txtLogin = new TextBox();
            lbLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnMain.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(142, 13);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 91);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.None;
            pnMain.Controls.Add(btnGuest);
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(txtPassword);
            pnMain.Controls.Add(lbPassword);
            pnMain.Controls.Add(txtLogin);
            pnMain.Controls.Add(lbLogin);
            pnMain.Location = new Point(12, 119);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(360, 202);
            pnMain.TabIndex = 1;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.LimeGreen;
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(97, 164);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(167, 28);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += BtnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSpringGreen;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(97, 130);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 28);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(70, 93);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 29);
            txtPassword.TabIndex = 3;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(152, 70);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(69, 21);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Пароль";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(70, 33);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(220, 29);
            txtLogin.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(152, 9);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(61, 21);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Логин";
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(384, 330);
            Controls.Add(pnMain);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин обуви - Авторизация";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnMain;
        private Button btnGuest;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lbPassword;
        private TextBox txtLogin;
        private Label lbLogin;
    }
}
