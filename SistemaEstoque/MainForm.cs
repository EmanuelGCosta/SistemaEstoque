using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstoque
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            displayUsername();
        }

        public void displayUsername()
        {
            string username = Form1.username.Substring(0, 1).ToUpper() + Form1.username.Substring(1).ToLower();
            user_username.Text = username;
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Encerrar aplicativo?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;

            AdminDashboard adForm = adminDashboard1 as AdminDashboard;

            if(adForm != null)
            {
                adForm.refresData();
            }

        }

        private void addUsers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = true;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;

            AdminAddUser aauForm = adminAddUser1 as AdminAddUser;

            if (aauForm != null)
            {
                aauForm.refresData();
            }
        }

        private void addCategories_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = false;

            AdminAddCategories aacForm = adminAddCategories1 as AdminAddCategories;

            if (aacForm != null)
            {
                aacForm.refresData();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierCustomerForm1.Visible = false;

            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;

            if (aapForm != null)
            {
                aapForm.refresData();
            }
        }

        private void custumers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomerForm1.Visible = true;

            CashierCustomerForm ccForm = cashierCustomerForm1 as CashierCustomerForm;

            if (ccForm != null)
            {
                ccForm.refresData();
            }
        }
    }
}
