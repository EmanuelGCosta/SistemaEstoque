﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SistemaEstoque
{
    public partial class CashierOrder : UserControl
    {

        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30");

        public CashierOrder()
        {
            InitializeComponent();
            displayAllAvaibleProducts();
            displayAllCategories();
            displayOrders();
            displayTotalPrice();
        }

        public void refresData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refresData);
                return;
            }
            displayAllAvaibleProducts();
            displayAllCategories();
            displayOrders();
            displayTotalPrice();
        }



        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayOrders()
        {
            OrdersData oData = new OrdersData();
            List<OrdersData> listData = oData.allOrdersData();

            dataGridView2.DataSource = listData;
        }

        public void displayAllAvaibleProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.allAvaibleProducts();

            dataGridView1.DataSource = listData;
        }

        public void displayAllCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectCategories = "SELECT * FROM categories";

                    using (SqlCommand cmd = new SqlCommand(selectCategories, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cashierOrder_category.Items.Clear();

                            while (reader.Read())
                            {
                                string Item = reader.GetString(1);
                                cashierOrder_category.Items.Add(Item);
                            }
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Conexão com banco de dados falhou!" + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }

            }

        }

        private void cashierOrder_category_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodID.Items.Clear();
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";

            string selectedValue = cashierOrder_category.SelectedItem as string;


            if (selectedValue != null)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectData = $"SELECT * FROM products WHERE category = '{selectedValue}' AND status = @status";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Disponível");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();
                                    cashierOrder_prodID.Items.Add(value);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexão com banco de dados falhou!" + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void cashierOrder_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierOrder_prodID.SelectedItem as string;

            if (checkConnection())
            {
                if (selectedValue != null)
                {
                    try
                    {
                        connect.Open();

                        string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}' AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Disponível");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["prod_name"].ToString();
                                    float prodPrice = Convert.ToSingle(reader["price"]);

                                    cashierOrder_prodName.Text = prodName;
                                    cashierOrder_price.Text = prodPrice.ToString("0.00");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexão com banco de dados falhou!" + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private int idGen;

        public void IDGenerator()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emanu\Documents\inventario.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            idGen = 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }

                    }
                    else
                    {
                        idGen = 1;
                    }


                }
                connect.Close();
            }
        }

        private float totalPrice = 0;
        public void displayTotalPrice()
        {
            IDGenerator();

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(total_price) FROM orders WHERE customer_id = @cID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", idGen);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);

                            cashierOrder_totalPrice.Text = totalPrice.ToString("0.00");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Conexão com banco de dados falhou: " + ex, "Mensagem de erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cashierOrder_addBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (cashierOrder_category.SelectedIndex == -1 || cashierOrder_prodID.SelectedIndex == -1 || cashierOrder_prodName.Text == "" || cashierOrder_price.Text == "" || cashierOrder_qty.Value == 0)
            {
                MessageBox.Show("Campos em branco!", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        float getPrice = 0;
                        int getStock = 0;
                        string selectOrder = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@prodID", cashierOrder_prodID.SelectedItem);

                            using (SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["price"];
                                    object rawStock = reader["stock"];

                                    if (rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(rawValue);
                                    }

                                    if (rawStock != DBNull.Value)
                                    {
                                        getStock = Convert.ToInt32(rawStock);
                                    }
                                }
                            }
                        }

                        if (getStock >= cashierOrder_qty.Value)
                        {
                            string insertData = "INSERT INTO orders (customer_id, prod_id, prod_name, category, qty, orig_price, total_price, order_date) " +
                                                            "VALUES(@cID, @prodID, @prodName, @cat, @qty, @origPrice, @totalPrice, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@cID", idGen);
                                cmd.Parameters.AddWithValue("@prodID", cashierOrder_prodID.SelectedItem);
                                cmd.Parameters.AddWithValue("@prodName", cashierOrder_prodName.Text.Trim());
                                cmd.Parameters.AddWithValue("@cat", cashierOrder_category.SelectedItem);
                                cmd.Parameters.AddWithValue("@qty", cashierOrder_qty.Value);
                                cmd.Parameters.AddWithValue("@origPrice", getPrice);


                                float totalP = (getPrice * (int)cashierOrder_qty.Value);
                                cmd.Parameters.AddWithValue("@totalPrice", totalP);

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Pedido feito com sucesso!", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Estoque insuficiente! Por favor, selecione uma quantidade menor ou aguarde o reabastecimento.", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Conexão com banco de dados falhou!" + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

            displayOrders();
            displayTotalPrice();
        }



        private void cashierOrder_removeBtn_Click(object sender, EventArgs e)
        {
            if (prodID == 0)
            {
                MessageBox.Show("Por favor selecione um item primeiro", "Mensagem de erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Você tem certeza que quer remover ID: " + prodID + "?", "Mensagem de confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM orders WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", prodID);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Removido com sucesso!", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Conexão com banco de dados falhou!" + ex, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
            displayOrders();
            displayTotalPrice();

            cashierOrder_totalPrice.Text = "0,00";
        }
        private int prodID = 0;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                prodID = (int)row.Cells[0].Value;
            }
        }

        private void clearFields()
        {
            cashierOrder_category.SelectedIndex = -1;
            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 1;
        }
        private void cashierOrder_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void cashierOrder_payOrders_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (cashierOrder_amount.Text == "" || dataGridView2.Rows.Count < 0)
            {
                MessageBox.Show("Algo deu errado.", "Mensagem de erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Pagar o pedido?", "Mensagem de confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            updateCustomersDB();
                            updateProductQtyDB();
                            removeOrdersDB();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Conexão com banco de dados falhou: " + ex, "Mensagem de erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
            displayTotalPrice();
        }

        private void updateCustomersDB()
        {
            string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, order_date) VALUES(@cID, @totalPrice, @amount, @change, @date)";

            using (SqlCommand cmd = new SqlCommand(insertData, connect))
            {
                cmd.Parameters.AddWithValue("@cID", idGen);
                cmd.Parameters.AddWithValue("@totalPrice", Convert.ToSingle(cashierOrder_totalPrice.Text));
                cmd.Parameters.AddWithValue("@amount", Convert.ToSingle(cashierOrder_amount.Text));
                cmd.Parameters.AddWithValue("@change", Convert.ToSingle(cashierOrder_change.Text));

                DateTime today = DateTime.Today;
                cmd.Parameters.AddWithValue("@date", today);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido pago com sucesso!", "Mensagem de êxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFields();

                cashierOrder_totalPrice.Text = "0,00";
                cashierOrder_amount.Text = "";
                cashierOrder_change.Text = "0,00";
            }
        }

        private void updateProductQtyDB()
        {
            string selectAllOrders = "SELECT * FROM orders";

            List<int> getQty = new List<int>();
            List<string> getId = new List<string>();
            using (SqlCommand cmd = new SqlCommand(selectAllOrders, connect))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        object rawQty = reader["qty"];
                        object id = reader["prod_id"];

                        if (rawQty != DBNull.Value)
                        {
                            getQty.Add(Convert.ToInt32(rawQty));
                        }
                        if (id != DBNull.Value)
                        {
                            getId.Add(Convert.ToString(id));
                        }
                    }
                }
            }

            string selectProducts = "SELECT * FROM products WHERE prod_id = @pid";
            string updateData = "UPDATE products SET stock = @updatedStock, status = @status WHERE prod_id = @pid";

            for (int i = 0; i < getId.Count; i++)
            {
                using (SqlCommand sData = new SqlCommand(selectProducts, connect))
                {
                    sData.Parameters.AddWithValue("@pid", getId[i]);
                    int getStock = 0;

                    using (SqlDataReader reader2 = sData.ExecuteReader())
                    {
                        if (reader2.Read())
                        {
                            Object Stock = reader2["stock"];

                            if (Stock != DBNull.Value)
                            {
                                getStock = Convert.ToInt32(Stock);
                            }
                        }
                    }

                    using (SqlCommand uData = new SqlCommand(updateData, connect))
                    {
                        Console.WriteLine(getQty[i] + "----" + getStock);
                        uData.Parameters.AddWithValue("@updatedStock", getStock - getQty[i]);
                        uData.Parameters.AddWithValue("@pid", getId[i]);

                        if (getStock - getQty[i] <= 0)
                        {
                            uData.Parameters.AddWithValue("@status", "Não disponível");
                        }
                        else
                        {
                            uData.Parameters.AddWithValue("@status", "Disponível");
                        }

                        uData.ExecuteNonQuery();
                        displayAllAvaibleProducts();
                    }
                }

            }
        }

        private void removeOrdersDB()
        {
            string deleteData = "DELETE FROM orders";

            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
            {
                cmd.ExecuteNonQuery();
                displayOrders();
            }
        }

        private void cashierOrder_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(cashierOrder_amount.Text);
                    float getChange = (getAmount - totalPrice);

                    if (getChange <= -1)
                    {
                        MessageBox.Show("Valor insufiente!", "Mensagem de erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cashierOrder_change.Text = getChange.ToString("0.00");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo deu errado! " + ex, "Mensagem de erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cashierOrder_amount.Text = "";
                    cashierOrder_change.Text = "0,00";
                }

            }
        }

        private int rowIndex = 0;
        private void cashierOrder_receipt_Click(object sender, EventArgs e)
        {

            if (cashierOrder_amount.Text == "" || dataGridView2.Rows.Count < 0)
            {
                MessageBox.Show("Por favor faça um pedido primeiro.", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

                cashierOrder_amount.Text = "";
                cashierOrder_change.Text = "0,00";
            }

        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            displayTotalPrice();
            float y = 0;
            int count = 0;
            int colWidth = 100;
            int headerMargin = 5;
            int tableMargin = 5;

            Font font = new Font("Tahoma", 12);
            Font bold = new Font("Tahoma", 12, FontStyle.Bold);
            Font headerFont = new Font("Tahoma", 16, FontStyle.Bold);
            Font labelFont = new Font("Tahoma", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();

            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Sistema de Controle de Estoque";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left + (dataGridView2.Columns.Count / 2) * colWidth, y, alignCenter);


            count++;

            y += tableMargin;

            string[] header = { "ID", "CID", "PID", "PNone", "Categoria", "Preco Orig", "QTD", "Preco Total" };

            for (int q = 0; q < header.Length; q++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[q], bold, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[rowIndex];

                for (int q = 0; q < dataGridView2.Columns.Count; q++)
                {
                    object cellValue = row.Cells[q].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
                }

                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            int labelMargin = (int)Math.Min(rSpace, 200);

            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("-------------", labelFont).Width;

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Preço total: \t$" + totalPrice + "\nValor pago: \t$" + cashierOrder_amount.Text.Trim()
                + "\n\t\t----------\nTroco: \t$" + cashierOrder_change.Text.Trim(), labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("----------", labelFont).Width, y);
        }
    }
}
