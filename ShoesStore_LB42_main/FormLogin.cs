using Microsoft.EntityFrameworkCore;
using ShoesStore_LB42_main.Models;

namespace ShoesStore_LB42_main
{
    public partial class FormLogin : Form
    {
        public User? CurrentUser { get; private set; }
        public Boolean IsGuest { get; private set; }
        public Role UserRole { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLogin.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new ShopDbContext())
            {
                var user = db.Users
                    .Include(u => u.Role) // ← ЭТО ОБЯЗАТЕЛЬНО
                    .FirstOrDefault(u => u.Login == txtLogin.Text && u.Pass == txtPassword.Text);

                if (user != null)
                {
                    CurrentUser = user;
                    IsGuest = false;
                    UserRole = user.Role; // Теперь Role точно не null (если в БД есть запись)
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnGuest_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            IsGuest = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
