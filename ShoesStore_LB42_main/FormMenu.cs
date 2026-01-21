using ShoesStore_LB42_main.Models;

namespace ShoesStore_LB42_main
{
    public partial class FormMenu : Form
    {
        public User? CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public Role UserRole { get; private set; }

        public FormMenu(User user, bool guest, Role userRole)
        {
            InitializeComponent();

            CurrentUser = user;
            IsGuest = guest;
            UserRole = userRole;

            if (!IsGuest)
            {
                lblUserName.Text = $"{CurrentUser.FullName} - {UserRole.RoleName}";
            }
            else
            {
                lblUserName.Text = "Гость";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnShowProducts_Click(object sender, EventArgs e)
        {
            using (var FormProducts = new FormProducts(
                            this.CurrentUser,
                            this.IsGuest))
            {
                FormProducts.ShowDialog();
            }
        }

        private void btnShowOrders_Click(object sender, EventArgs e)
        {
            using (var FormOrders = new FormOrders(
                            this.CurrentUser,
                            this.IsGuest))
            {
                FormOrders.ShowDialog();
            }
        }
    }
}
