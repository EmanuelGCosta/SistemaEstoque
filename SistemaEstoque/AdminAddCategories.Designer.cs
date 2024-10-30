namespace SistemaEstoque
{
    partial class AdminAddCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addCategory_clearBtn = new System.Windows.Forms.Button();
            this.addCategory_removeBtn = new System.Windows.Forms.Button();
            this.addCategory_updateBtn = new System.Windows.Forms.Button();
            this.addCategory_addBtn = new System.Windows.Forms.Button();
            this.addCategory_category = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(371, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 651);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Todas Categorias";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(626, 585);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addCategory_clearBtn);
            this.panel1.Controls.Add(this.addCategory_removeBtn);
            this.panel1.Controls.Add(this.addCategory_updateBtn);
            this.panel1.Controls.Add(this.addCategory_addBtn);
            this.panel1.Controls.Add(this.addCategory_category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 651);
            this.panel1.TabIndex = 6;
            // 
            // addCategory_clearBtn
            // 
            this.addCategory_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCategory_clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCategory_clearBtn.FlatAppearance.BorderSize = 0;
            this.addCategory_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCategory_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory_clearBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addCategory_clearBtn.Location = new System.Drawing.Point(184, 189);
            this.addCategory_clearBtn.Name = "addCategory_clearBtn";
            this.addCategory_clearBtn.Size = new System.Drawing.Size(147, 51);
            this.addCategory_clearBtn.TabIndex = 11;
            this.addCategory_clearBtn.Text = "Limpar";
            this.addCategory_clearBtn.UseVisualStyleBackColor = false;
            // 
            // addCategory_removeBtn
            // 
            this.addCategory_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCategory_removeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCategory_removeBtn.FlatAppearance.BorderSize = 0;
            this.addCategory_removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCategory_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory_removeBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory_removeBtn.ForeColor = System.Drawing.Color.White;
            this.addCategory_removeBtn.Location = new System.Drawing.Point(13, 189);
            this.addCategory_removeBtn.Name = "addCategory_removeBtn";
            this.addCategory_removeBtn.Size = new System.Drawing.Size(147, 51);
            this.addCategory_removeBtn.TabIndex = 10;
            this.addCategory_removeBtn.Text = "Remover";
            this.addCategory_removeBtn.UseVisualStyleBackColor = false;
            this.addCategory_removeBtn.Click += new System.EventHandler(this.addCategory_removeBtn_Click);
            // 
            // addCategory_updateBtn
            // 
            this.addCategory_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCategory_updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCategory_updateBtn.FlatAppearance.BorderSize = 0;
            this.addCategory_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCategory_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory_updateBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addCategory_updateBtn.Location = new System.Drawing.Point(184, 132);
            this.addCategory_updateBtn.Name = "addCategory_updateBtn";
            this.addCategory_updateBtn.Size = new System.Drawing.Size(147, 51);
            this.addCategory_updateBtn.TabIndex = 9;
            this.addCategory_updateBtn.Text = "Atualizar";
            this.addCategory_updateBtn.UseVisualStyleBackColor = false;
            this.addCategory_updateBtn.Click += new System.EventHandler(this.addCategory_updateBtn_Click);
            // 
            // addCategory_addBtn
            // 
            this.addCategory_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCategory_addBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.addCategory_addBtn.FlatAppearance.BorderSize = 0;
            this.addCategory_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCategory_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory_addBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory_addBtn.ForeColor = System.Drawing.Color.White;
            this.addCategory_addBtn.Location = new System.Drawing.Point(13, 132);
            this.addCategory_addBtn.Name = "addCategory_addBtn";
            this.addCategory_addBtn.Size = new System.Drawing.Size(147, 51);
            this.addCategory_addBtn.TabIndex = 8;
            this.addCategory_addBtn.Text = "Adicionar";
            this.addCategory_addBtn.UseVisualStyleBackColor = false;
            this.addCategory_addBtn.Click += new System.EventHandler(this.addCategory_addBtn_Click);
            // 
            // addCategory_category
            // 
            this.addCategory_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory_category.Location = new System.Drawing.Point(13, 77);
            this.addCategory_category.Name = "addCategory_category";
            this.addCategory_category.Size = new System.Drawing.Size(318, 29);
            this.addCategory_category.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // AdminAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddCategories";
            this.Size = new System.Drawing.Size(1044, 675);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addCategory_clearBtn;
        private System.Windows.Forms.Button addCategory_removeBtn;
        private System.Windows.Forms.Button addCategory_updateBtn;
        private System.Windows.Forms.Button addCategory_addBtn;
        private System.Windows.Forms.TextBox addCategory_category;
        private System.Windows.Forms.Label label1;
    }
}
