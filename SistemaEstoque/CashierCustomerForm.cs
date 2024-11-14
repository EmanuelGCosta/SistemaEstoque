using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaEstoque
{
    public partial class CashierCustomerForm : UserControl
    {
        public CashierCustomerForm()
        {
            InitializeComponent();
            displayCustomers();
        }

        public void refresData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refresData);
                return;
            }
            displayCustomers();
        }

        public void displayCustomers()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allCustomers();

            dataGridView1.DataSource = listData;
        }
    }
}
