namespace Inventory_Management_System
{
    partial class ManageUser
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            unameTb = new RichTextBox();
            FnameTb = new RichTextBox();
            PasswordTb = new RichTextBox();
            PhoneTb = new RichTextBox();
            addbt = new Button();
            editbt = new Button();
            delbt = new Button();
            homebt = new Button();
            UserGV = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 100);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(797, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 25);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(169, 24);
            label2.Name = "label2";
            label2.Size = new Size(462, 32);
            label2.TabIndex = 1;
            label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(316, 56);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage User";
            label1.Click += label1_Click;
            // 
            // unameTb
            // 
            unameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            unameTb.ForeColor = Color.DarkCyan;
            unameTb.Location = new Point(12, 120);
            unameTb.Name = "unameTb";
            unameTb.Size = new Size(227, 48);
            unameTb.TabIndex = 1;
            unameTb.Text = "UserName";
            unameTb.TextChanged += unameTb_TextChanged;
            // 
            // FnameTb
            // 
            FnameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FnameTb.ForeColor = Color.DarkCyan;
            FnameTb.Location = new Point(12, 185);
            FnameTb.Name = "FnameTb";
            FnameTb.Size = new Size(227, 48);
            FnameTb.TabIndex = 2;
            FnameTb.Text = "FullName";
            FnameTb.TextChanged += FnameTb_TextChanged;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTb.ForeColor = Color.DarkCyan;
            PasswordTb.Location = new Point(12, 253);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(227, 48);
            PasswordTb.TabIndex = 3;
            PasswordTb.Text = "Password";
            PasswordTb.TextChanged += PasswordTb_TextChanged;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTb.ForeColor = Color.DarkCyan;
            PhoneTb.Location = new Point(12, 331);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(227, 48);
            PhoneTb.TabIndex = 4;
            PhoneTb.Text = "Telephone";
            PhoneTb.TextChanged += PhoneTb_TextChanged;
            // 
            // addbt
            // 
            addbt.BackColor = Color.Cyan;
            addbt.FlatStyle = FlatStyle.Flat;
            addbt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addbt.ForeColor = SystemColors.Desktop;
            addbt.Location = new Point(12, 405);
            addbt.Name = "addbt";
            addbt.RightToLeft = RightToLeft.No;
            addbt.Size = new Size(71, 40);
            addbt.TabIndex = 5;
            addbt.Text = "Add";
            addbt.UseVisualStyleBackColor = false;
            addbt.Click += button1_Click;
            // 
            // editbt
            // 
            editbt.BackColor = Color.Cyan;
            editbt.FlatStyle = FlatStyle.Flat;
            editbt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editbt.ForeColor = SystemColors.Desktop;
            editbt.Location = new Point(89, 405);
            editbt.Name = "editbt";
            editbt.RightToLeft = RightToLeft.No;
            editbt.Size = new Size(74, 40);
            editbt.TabIndex = 6;
            editbt.Text = "Edit";
            editbt.UseVisualStyleBackColor = false;
            editbt.Click += button2_Click;
            // 
            // delbt
            // 
            delbt.BackColor = Color.Cyan;
            delbt.FlatStyle = FlatStyle.Flat;
            delbt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delbt.ForeColor = SystemColors.Desktop;
            delbt.Location = new Point(169, 405);
            delbt.Name = "delbt";
            delbt.RightToLeft = RightToLeft.No;
            delbt.Size = new Size(70, 40);
            delbt.TabIndex = 7;
            delbt.Text = "Delete";
            delbt.UseVisualStyleBackColor = false;
            delbt.Click += button3_Click;
            // 
            // homebt
            // 
            homebt.BackColor = Color.Cyan;
            homebt.FlatStyle = FlatStyle.Flat;
            homebt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            homebt.ForeColor = SystemColors.Desktop;
            homebt.Location = new Point(89, 461);
            homebt.Name = "homebt";
            homebt.RightToLeft = RightToLeft.No;
            homebt.Size = new Size(74, 40);
            homebt.TabIndex = 8;
            homebt.Text = "Home";
            homebt.UseVisualStyleBackColor = false;
            homebt.Click += button4_Click;
            // 
            // UserGV
            // 
            UserGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserGV.Location = new Point(289, 120);
            UserGV.Name = "UserGV";
            UserGV.RowTemplate.Height = 25;
            UserGV.Size = new Size(525, 480);
            UserGV.TabIndex = 9;
            UserGV.CellContentClick += UserGV_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 620);
            panel2.Name = "panel2";
            panel2.Size = new Size(826, 13);
            panel2.TabIndex = 10;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 633);
            Controls.Add(panel2);
            Controls.Add(UserGV);
            Controls.Add(homebt);
            Controls.Add(delbt);
            Controls.Add(editbt);
            Controls.Add(addbt);
            Controls.Add(PhoneTb);
            Controls.Add(PasswordTb);
            Controls.Add(FnameTb);
            Controls.Add(unameTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private RichTextBox unameTb;
        private RichTextBox FnameTb;
        private RichTextBox PasswordTb;
        private RichTextBox PhoneTb;
        private Button addbt;
        private Button editbt;
        private Button delbt;
        private Button homebt;
        private DataGridView UserGV;
        private Panel panel2;
        private Label label3;
    }
}