using System;
using System.Windows.Forms;

namespace SistemaEstoque
{
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
            displayUsername();
        }

        public void displayUsername()
        {
            string username = Form1.username.Substring(0, 1).ToUpper() + Form1.username.Substring(1).ToLower();
            user_username.Text = username;
        }

        private void leave_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Encerrar sessão?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                Form1 loggingForm = new Form1();

                loggingForm.Show();

                this.Hide();

            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Encerrar aplicativo?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            cashierOrder1.Visible = false;

            AdminDashboard adForm = adminDashboard1 as AdminDashboard;

            if (adForm != null)
            {
                adForm.refresData();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomerForm1.Visible = false;
            cashierOrder1.Visible = false;

            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;

            if (aapForm != null)
            {
                aapForm.refresData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = true;
            cashierOrder1.Visible = false;

            CashierCustomerForm ccfForm = cashierCustomerForm1 as CashierCustomerForm;

            if (ccfForm != null)
            {
                ccfForm.refresData();
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;
            cashierOrder1.Visible = true;

            CashierOrder coForm = cashierOrder1 as CashierOrder;

            if (coForm != null)
            {
                coForm.refresData();
            }
        }
    }
}
