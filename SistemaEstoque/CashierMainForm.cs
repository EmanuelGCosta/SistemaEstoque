using System;
using System.Windows.Forms;

namespace SistemaEstoque
{
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
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
            this.Close();
        }
    }
}
