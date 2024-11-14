namespace SistemaEstoque
{
    partial class CashierOrder
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cashierOrder_clearBtn = new System.Windows.Forms.Button();
            this.cashierOrder_removeBtn = new System.Windows.Forms.Button();
            this.cashierOrder_addBtn = new System.Windows.Forms.Button();
            this.cashierOrder_qty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cashierOrder_price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cashierOrder_prodName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cashierOrder_prodID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierOrder_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cashierOrder_change = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cashierOrder_receipt = new System.Windows.Forms.Button();
            this.cashierOrder_payOrders = new System.Windows.Forms.Button();
            this.cashierOrder_amount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cashierOrder_totalPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_qty)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 314);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(12, 36, 12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(642, 266);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produtos Disponíveis";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cashierOrder_clearBtn);
            this.panel2.Controls.Add(this.cashierOrder_removeBtn);
            this.panel2.Controls.Add(this.cashierOrder_addBtn);
            this.panel2.Controls.Add(this.cashierOrder_qty);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cashierOrder_price);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cashierOrder_prodName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cashierOrder_prodID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cashierOrder_category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 350);
            this.panel2.Margin = new System.Windows.Forms.Padding(12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 313);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Selecione o produto";
            // 
            // cashierOrder_clearBtn
            // 
            this.cashierOrder_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_clearBtn.FlatAppearance.BorderSize = 0;
            this.cashierOrder_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_clearBtn.Location = new System.Drawing.Point(474, 265);
            this.cashierOrder_clearBtn.Name = "cashierOrder_clearBtn";
            this.cashierOrder_clearBtn.Size = new System.Drawing.Size(120, 34);
            this.cashierOrder_clearBtn.TabIndex = 19;
            this.cashierOrder_clearBtn.Text = "Limpar";
            this.cashierOrder_clearBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_clearBtn.Click += new System.EventHandler(this.cashierOrder_clearBtn_Click);
            // 
            // cashierOrder_removeBtn
            // 
            this.cashierOrder_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_removeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_removeBtn.FlatAppearance.BorderSize = 0;
            this.cashierOrder_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_removeBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_removeBtn.Location = new System.Drawing.Point(246, 265);
            this.cashierOrder_removeBtn.Name = "cashierOrder_removeBtn";
            this.cashierOrder_removeBtn.Size = new System.Drawing.Size(120, 34);
            this.cashierOrder_removeBtn.TabIndex = 18;
            this.cashierOrder_removeBtn.Text = "Remover";
            this.cashierOrder_removeBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_removeBtn.Click += new System.EventHandler(this.cashierOrder_removeBtn_Click);
            // 
            // cashierOrder_addBtn
            // 
            this.cashierOrder_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_addBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_addBtn.FlatAppearance.BorderSize = 0;
            this.cashierOrder_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_addBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_addBtn.Location = new System.Drawing.Point(109, 265);
            this.cashierOrder_addBtn.Name = "cashierOrder_addBtn";
            this.cashierOrder_addBtn.Size = new System.Drawing.Size(120, 34);
            this.cashierOrder_addBtn.TabIndex = 17;
            this.cashierOrder_addBtn.Text = "Adicionar";
            this.cashierOrder_addBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_addBtn.Click += new System.EventHandler(this.cashierOrder_addBtn_Click);
            // 
            // cashierOrder_qty
            // 
            this.cashierOrder_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_qty.Location = new System.Drawing.Point(473, 130);
            this.cashierOrder_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cashierOrder_qty.Name = "cashierOrder_qty";
            this.cashierOrder_qty.Size = new System.Drawing.Size(144, 26);
            this.cashierOrder_qty.TabIndex = 12;
            this.cashierOrder_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quantidade";
            // 
            // cashierOrder_price
            // 
            this.cashierOrder_price.AutoSize = true;
            this.cashierOrder_price.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_price.Location = new System.Drawing.Point(202, 184);
            this.cashierOrder_price.Name = "cashierOrder_price";
            this.cashierOrder_price.Size = new System.Drawing.Size(0, 22);
            this.cashierOrder_price.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Preço R$:";
            // 
            // cashierOrder_prodName
            // 
            this.cashierOrder_prodName.AutoSize = true;
            this.cashierOrder_prodName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_prodName.Location = new System.Drawing.Point(202, 130);
            this.cashierOrder_prodName.Name = "cashierOrder_prodName";
            this.cashierOrder_prodName.Size = new System.Drawing.Size(0, 22);
            this.cashierOrder_prodName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome do produto:";
            // 
            // cashierOrder_prodID
            // 
            this.cashierOrder_prodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_prodID.FormattingEnabled = true;
            this.cashierOrder_prodID.Location = new System.Drawing.Point(473, 65);
            this.cashierOrder_prodID.Name = "cashierOrder_prodID";
            this.cashierOrder_prodID.Size = new System.Drawing.Size(145, 28);
            this.cashierOrder_prodID.TabIndex = 6;
            this.cashierOrder_prodID.SelectedIndexChanged += new System.EventHandler(this.cashierOrder_prodID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID do produto";
            // 
            // cashierOrder_category
            // 
            this.cashierOrder_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_category.FormattingEnabled = true;
            this.cashierOrder_category.Location = new System.Drawing.Point(149, 65);
            this.cashierOrder_category.Name = "cashierOrder_category";
            this.cashierOrder_category.Size = new System.Drawing.Size(145, 28);
            this.cashierOrder_category.TabIndex = 4;
            this.cashierOrder_category.SelectedIndexChanged += new System.EventHandler(this.cashierOrder_category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cashierOrder_change);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cashierOrder_receipt);
            this.panel3.Controls.Add(this.cashierOrder_payOrders);
            this.panel3.Controls.Add(this.cashierOrder_amount);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cashierOrder_totalPrice);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(702, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 651);
            this.panel3.TabIndex = 1;
            // 
            // cashierOrder_change
            // 
            this.cashierOrder_change.AutoSize = true;
            this.cashierOrder_change.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_change.Location = new System.Drawing.Point(173, 413);
            this.cashierOrder_change.Name = "cashierOrder_change";
            this.cashierOrder_change.Size = new System.Drawing.Size(48, 22);
            this.cashierOrder_change.TabIndex = 26;
            this.cashierOrder_change.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Troco:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView2.Location = new System.Drawing.Point(12, 36);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(12, 36, 12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(306, 266);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Pedidos";
            // 
            // cashierOrder_receipt
            // 
            this.cashierOrder_receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_receipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_receipt.FlatAppearance.BorderSize = 0;
            this.cashierOrder_receipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_receipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_receipt.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_receipt.Location = new System.Drawing.Point(8, 549);
            this.cashierOrder_receipt.Name = "cashierOrder_receipt";
            this.cashierOrder_receipt.Size = new System.Drawing.Size(314, 52);
            this.cashierOrder_receipt.TabIndex = 24;
            this.cashierOrder_receipt.Text = "Recibo";
            this.cashierOrder_receipt.UseVisualStyleBackColor = false;
            this.cashierOrder_receipt.Click += new System.EventHandler(this.cashierOrder_receipt_Click);
            // 
            // cashierOrder_payOrders
            // 
            this.cashierOrder_payOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_payOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_payOrders.FlatAppearance.BorderSize = 0;
            this.cashierOrder_payOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_payOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_payOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_payOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_payOrders.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_payOrders.Location = new System.Drawing.Point(8, 488);
            this.cashierOrder_payOrders.Name = "cashierOrder_payOrders";
            this.cashierOrder_payOrders.Size = new System.Drawing.Size(314, 52);
            this.cashierOrder_payOrders.TabIndex = 20;
            this.cashierOrder_payOrders.Text = "Pagar Pedido";
            this.cashierOrder_payOrders.UseVisualStyleBackColor = false;
            this.cashierOrder_payOrders.Click += new System.EventHandler(this.cashierOrder_payOrders_Click);
            // 
            // cashierOrder_amount
            // 
            this.cashierOrder_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_amount.Location = new System.Drawing.Point(177, 372);
            this.cashierOrder_amount.Name = "cashierOrder_amount";
            this.cashierOrder_amount.Size = new System.Drawing.Size(114, 26);
            this.cashierOrder_amount.TabIndex = 23;
            this.cashierOrder_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierOrder_amount_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Valor R$:";
            // 
            // cashierOrder_totalPrice
            // 
            this.cashierOrder_totalPrice.AutoSize = true;
            this.cashierOrder_totalPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_totalPrice.Location = new System.Drawing.Point(173, 333);
            this.cashierOrder_totalPrice.Name = "cashierOrder_totalPrice";
            this.cashierOrder_totalPrice.Size = new System.Drawing.Size(48, 22);
            this.cashierOrder_totalPrice.TabIndex = 21;
            this.cashierOrder_totalPrice.Text = "0,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "Preço total R$:";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CashierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOrder";
            this.Size = new System.Drawing.Size(1044, 675);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_qty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cashierOrder_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cashierOrder_prodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cashierOrder_prodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cashierOrder_category;
        private System.Windows.Forms.NumericUpDown cashierOrder_qty;
        private System.Windows.Forms.Button cashierOrder_clearBtn;
        private System.Windows.Forms.Button cashierOrder_removeBtn;
        private System.Windows.Forms.Button cashierOrder_addBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cashierOrder_totalPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cashierOrder_amount;
        private System.Windows.Forms.Button cashierOrder_receipt;
        private System.Windows.Forms.Button cashierOrder_payOrders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label cashierOrder_change;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
