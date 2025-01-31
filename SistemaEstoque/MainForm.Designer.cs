namespace SistemaEstoque
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.leave_btn = new System.Windows.Forms.Button();
            this.custumers_btn = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.addCategories_btn = new System.Windows.Forms.Button();
            this.addUsers_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminDashboard1 = new SistemaEstoque.AdminDashboard();
            this.adminAddUser1 = new SistemaEstoque.AdminAddUser();
            this.adminAddCategories1 = new SistemaEstoque.AdminAddCategories();
            this.adminAddProducts1 = new SistemaEstoque.AdminAddProducts();
            this.cashierCustomerForm1 = new SistemaEstoque.CashierCustomerForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(67)))));
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1220, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(60, 45);
            this.close.TabIndex = 12;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 45);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sistema de Controle de Estoque";
            // 
            // leave_btn
            // 
            this.leave_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.leave_btn.FlatAppearance.BorderSize = 0;
            this.leave_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(67)))));
            this.leave_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.leave_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leave_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_btn.ForeColor = System.Drawing.Color.White;
            this.leave_btn.Location = new System.Drawing.Point(12, 615);
            this.leave_btn.Name = "leave_btn";
            this.leave_btn.Size = new System.Drawing.Size(211, 48);
            this.leave_btn.TabIndex = 16;
            this.leave_btn.Text = "Sair";
            this.leave_btn.UseVisualStyleBackColor = false;
            this.leave_btn.Click += new System.EventHandler(this.leave_btn_Click);
            // 
            // custumers_btn
            // 
            this.custumers_btn.FlatAppearance.BorderSize = 0;
            this.custumers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.custumers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.custumers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custumers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custumers_btn.ForeColor = System.Drawing.Color.White;
            this.custumers_btn.Location = new System.Drawing.Point(0, 438);
            this.custumers_btn.Name = "custumers_btn";
            this.custumers_btn.Size = new System.Drawing.Size(236, 52);
            this.custumers_btn.TabIndex = 14;
            this.custumers_btn.Text = "Vendas";
            this.custumers_btn.UseVisualStyleBackColor = true;
            this.custumers_btn.Click += new System.EventHandler(this.custumers_btn_Click);
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.FlatAppearance.BorderSize = 0;
            this.addProducts_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addProducts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_btn.ForeColor = System.Drawing.Color.White;
            this.addProducts_btn.Location = new System.Drawing.Point(0, 380);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(236, 52);
            this.addProducts_btn.TabIndex = 13;
            this.addProducts_btn.Text = "Adicionar produto";
            this.addProducts_btn.UseVisualStyleBackColor = true;
            this.addProducts_btn.Click += new System.EventHandler(this.addProducts_btn_Click);
            // 
            // addCategories_btn
            // 
            this.addCategories_btn.FlatAppearance.BorderSize = 0;
            this.addCategories_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCategories_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addCategories_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_btn.ForeColor = System.Drawing.Color.White;
            this.addCategories_btn.Location = new System.Drawing.Point(0, 322);
            this.addCategories_btn.Name = "addCategories_btn";
            this.addCategories_btn.Size = new System.Drawing.Size(236, 52);
            this.addCategories_btn.TabIndex = 12;
            this.addCategories_btn.Text = "Adicionar categoria";
            this.addCategories_btn.UseVisualStyleBackColor = true;
            this.addCategories_btn.Click += new System.EventHandler(this.addCategories_btn_Click);
            // 
            // addUsers_btn
            // 
            this.addUsers_btn.FlatAppearance.BorderSize = 0;
            this.addUsers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addUsers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.addUsers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUsers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_btn.ForeColor = System.Drawing.Color.White;
            this.addUsers_btn.Location = new System.Drawing.Point(0, 264);
            this.addUsers_btn.Name = "addUsers_btn";
            this.addUsers_btn.Size = new System.Drawing.Size(236, 52);
            this.addUsers_btn.TabIndex = 11;
            this.addUsers_btn.Text = "Adicionar usuário";
            this.addUsers_btn.UseVisualStyleBackColor = true;
            this.addUsers_btn.Click += new System.EventHandler(this.addUsers_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Location = new System.Drawing.Point(0, 206);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(236, 52);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bem Vindo,";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.leave_btn);
            this.panel2.Controls.Add(this.custumers_btn);
            this.panel2.Controls.Add(this.addProducts_btn);
            this.panel2.Controls.Add(this.addCategories_btn);
            this.panel2.Controls.Add(this.addUsers_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.user_username);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 675);
            this.panel2.TabIndex = 2;
            // 
            // user_username
            // 
            this.user_username.AutoSize = true;
            this.user_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_username.ForeColor = System.Drawing.Color.White;
            this.user_username.Location = new System.Drawing.Point(93, 122);
            this.user_username.Name = "user_username";
            this.user_username.Size = new System.Drawing.Size(49, 18);
            this.user_username.TabIndex = 10;
            this.user_username.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaEstoque.Properties.Resources.Account;
            this.pictureBox1.Location = new System.Drawing.Point(77, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminDashboard1);
            this.panel3.Controls.Add(this.adminAddUser1);
            this.panel3.Controls.Add(this.adminAddCategories1);
            this.panel3.Controls.Add(this.adminAddProducts1);
            this.panel3.Controls.Add(this.cashierCustomerForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(236, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 675);
            this.panel3.TabIndex = 3;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1044, 675);
            this.adminDashboard1.TabIndex = 4;
            // 
            // adminAddUser1
            // 
            this.adminAddUser1.Location = new System.Drawing.Point(0, 0);
            this.adminAddUser1.Name = "adminAddUser1";
            this.adminAddUser1.Size = new System.Drawing.Size(1044, 675);
            this.adminAddUser1.TabIndex = 3;
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.Location = new System.Drawing.Point(0, 0);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(1044, 675);
            this.adminAddCategories1.TabIndex = 2;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1044, 675);
            this.adminAddProducts1.TabIndex = 1;
            // 
            // cashierCustomerForm1
            // 
            this.cashierCustomerForm1.Location = new System.Drawing.Point(0, 0);
            this.cashierCustomerForm1.Name = "cashierCustomerForm1";
            this.cashierCustomerForm1.Size = new System.Drawing.Size(1044, 675);
            this.cashierCustomerForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button leave_btn;
        private System.Windows.Forms.Button custumers_btn;
        private System.Windows.Forms.Button addProducts_btn;
        private System.Windows.Forms.Button addCategories_btn;
        private System.Windows.Forms.Button addUsers_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label user_username;
        private System.Windows.Forms.Panel panel3;
        private AdminDashboard adminDashboard1;
        private AdminAddUser adminAddUser1;
        private AdminAddCategories adminAddCategories1;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomerForm cashierCustomerForm1;
    }
}