namespace UI_
{
    partial class Customers
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            showCustomer = new Button();
            deleteCustomer = new Button();
            showAllCustomers = new Button();
            createCustomer = new Button();
            updateCustomer = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label5 = new Label();
            confirmCreate = new Button();
            checkBox1 = new CheckBox();
            Phone = new TextBox();
            Adress = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            NameTextBox = new TextBox();
            label2 = new Label();
            panelID = new Panel();
            confirmAction = new Button();
            ID = new TextBox();
            UpName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            UpAdress = new TextBox();
            UpPhone = new TextBox();
            checkBox2 = new CheckBox();
            UpdateConfirm = new Button();
            label6 = new Label();
            UpID = new TextBox();
            panelUpdate = new Panel();
            panelDelete = new Panel();
            DeleteConfirm = new Button();
            IDdelete = new TextBox();
            label10 = new Label();
            panelShowAll = new Panel();
            filterByClub = new Button();
            closeShowAll = new Button();
            labelFilter = new Label();
            filterTextBox = new TextBox();
            dataGridViewCustomers = new DataGridView();
            panel1.SuspendLayout();
            panelID.SuspendLayout();
            panelUpdate.SuspendLayout();
            panelDelete.SuspendLayout();
            panelShowAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();

            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 24); // רקע אובסידיאן כהה
            this.dataGridViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55); // כותרות בזהב שמפניה
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridViewCustomers.EnableHeadersVisualStyles = false;
            this.dataGridViewCustomers.GridColor = System.Drawing.Color.FromArgb(42, 42, 42);
            this.dataGridViewCustomers.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            this.dataGridViewCustomers.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224); // לבן-אפור רך לקריאות
            this.dataGridViewCustomers.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.dataGridViewCustomers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(50, 50, 50); // בחירה נקייה בגוון כהה
            this.dataGridViewCustomers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(212, 175, 55); // טקסט מוזהב בבחירה
            this.dataGridViewCustomers.RowTemplate.Height = 35;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(25, 75);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(700, 420);
            this.dataGridViewCustomers.TabIndex = 0;

            // 
            // filterTextBox
            // 
            this.filterTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.filterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.filterTextBox.ForeColor = System.Drawing.Color.White;
            this.filterTextBox.Location = new System.Drawing.Point(80, 22);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(180, 27);
            this.filterTextBox.TabIndex = 1;
            this.filterTextBox.TextChanged += filterTextBox_TextChanged;

            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelFilter.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55); // זהב שמפניה
            this.labelFilter.Location = new System.Drawing.Point(25, 25);
            this.labelFilter.Name = "lblFilter";
            this.labelFilter.Size = new System.Drawing.Size(49, 20);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "Filter:";

            // 
            // filterByClub
            // 
            this.filterByClub.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.filterByClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterByClub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.filterByClub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.filterByClub.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.filterByClub.Location = new System.Drawing.Point(280, 20);
            this.filterByClub.Name = "filterByClub";
            this.filterByClub.Size = new System.Drawing.Size(160, 32);
            this.filterByClub.TabIndex = 3;
            this.filterByClub.Text = "Only Club Members";
            this.filterByClub.UseVisualStyleBackColor = false;
            this.filterByClub.Click += new System.EventHandler(this.filterByClub_Click);

            // 
            // closeShowAll
            // 
            this.closeShowAll.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.closeShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeShowAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(205, 127, 50); // נחושת אלגנטית לסגירה
            this.closeShowAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.closeShowAll.ForeColor = System.Drawing.Color.FromArgb(205, 127, 50);
            this.closeShowAll.Location = new System.Drawing.Point(685, 20);
            this.closeShowAll.Name = "btnClose";
            this.closeShowAll.Size = new System.Drawing.Size(40, 32);
            this.closeShowAll.TabIndex = 4;
            this.closeShowAll.Text = "X";
            this.closeShowAll.UseVisualStyleBackColor = false;
            this.closeShowAll.Click += closeShowAll_Click;

            // 
            // showCustomer
            // 
            this.showCustomer.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.showCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.showCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.showCustomer.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.showCustomer.Location = new Point(750, 75);
            this.showCustomer.Name = "showCustomer";
            this.showCustomer.Size = new System.Drawing.Size(180, 45);
            this.showCustomer.TabIndex = 0;
            this.showCustomer.Text = "Show Customer";
            this.showCustomer.UseVisualStyleBackColor = false;
            this.showCustomer.Click += showCustomer_Click;

            // 
            // showAllCustomers
            // 
            this.showAllCustomers.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.showAllCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(169, 169, 169); // אפור בהיר נקי
            this.showAllCustomers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.showAllCustomers.ForeColor = System.Drawing.Color.White;
            this.showAllCustomers.Location = new Point(750, 140);
            this.showAllCustomers.Name = "showAllCustomers";
            this.showAllCustomers.Size = new Size(180, 45);
            this.showAllCustomers.TabIndex = 2;
            this.showAllCustomers.Text = "Show All Customers";
            this.showAllCustomers.UseVisualStyleBackColor = false;
            this.showAllCustomers.Click += showAllCustomers_Click;

            // 
            // createCustomer
            // 
            this.createCustomer.BackColor = System.Drawing.Color.FromArgb(212, 175, 55); // זהב מלא - הדגשת פעולת יצירה ראשית
            this.createCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCustomer.FlatAppearance.BorderSize = 0;
            this.createCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.createCustomer.ForeColor = System.Drawing.Color.FromArgb(18, 18, 18); // טקסט כהה על רקע זהב
            this.createCustomer.Location = new Point(750, 205);
            this.createCustomer.Name = "createCustomer";
            this.createCustomer.Size = new Size(180, 45);
            this.createCustomer.TabIndex = 2;
            this.createCustomer.Text = "Create Customer";
            this.createCustomer.UseVisualStyleBackColor = false;
            this.createCustomer.Click += createCustomer_Click;

            // 
            // deleteCustomer
            // 
            this.deleteCustomer.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.deleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(205, 127, 50); // נחושת לפעולת מחיקה/אזהרה
            this.deleteCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.deleteCustomer.ForeColor = System.Drawing.Color.FromArgb(205, 127, 50);
            this.deleteCustomer.Location = new Point(750, 270);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(180, 45);
            this.deleteCustomer.TabIndex = 1;
            this.deleteCustomer.Text = "Delete Customer";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += deleteCustomer_Click;

            // 
            // updateCustomer
            // 
            this.updateCustomer.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.updateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.updateCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.updateCustomer.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.updateCustomer.Location = new Point(750, 335);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new Size(180, 45);
            this.updateCustomer.TabIndex = 3;
            this.updateCustomer.Text = "Update Customer";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += updateCustomer_Click;

            // 
            // panel1 (Create Customer Panel)
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(confirmCreate);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(Phone);
            panel1.Controls.Add(Adress);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(NameTextBox);
            panel1.Location = new Point(31, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 171);
            panel1.TabIndex = 4;

            // textBox1
            textBox1.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = System.Drawing.Color.White;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            textBox1.Location = new Point(155, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(36, 23);
            textBox1.TabIndex = 9;

            // label5
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            label5.Location = new Point(169, 70);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 8;
            label5.Text = "ID";

            // confirmCreate
            confirmCreate.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            confirmCreate.FlatStyle = FlatStyle.Flat;
            confirmCreate.FlatAppearance.BorderSize = 0;
            confirmCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            confirmCreate.ForeColor = System.Drawing.Color.FromArgb(18, 18, 18);
            confirmCreate.Location = new Point(78, 132);
            confirmCreate.Name = "confirmCreate";
            confirmCreate.Size = new Size(75, 23);
            confirmCreate.TabIndex = 7;
            confirmCreate.Text = "OK";
            confirmCreate.UseVisualStyleBackColor = false;
            confirmCreate.Click += confirmCreate_Click;

            // checkBox1
            checkBox1.AutoSize = true;
            checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            checkBox1.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            checkBox1.Location = new Point(88, 109);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(99, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Club Member";
            checkBox1.UseVisualStyleBackColor = true;

            // Phone
            Phone.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            Phone.BorderStyle = BorderStyle.FixedSingle;
            Phone.ForeColor = System.Drawing.Color.White;
            Phone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            Phone.Location = new Point(3, 44);
            Phone.Name = "Phone";
            Phone.Size = new Size(100, 23);
            Phone.TabIndex = 5;

            // Adress
            Adress.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            Adress.BorderStyle = BorderStyle.FixedSingle;
            Adress.ForeColor = System.Drawing.Color.White;
            Adress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            Adress.Location = new Point(3, 88);
            Adress.Name = "Adress";
            Adress.Size = new Size(100, 23);
            Adress.TabIndex = 4;

            // label4
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            label4.Location = new Point(65, 23);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone";

            // label3
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            label3.Location = new Point(48, 70);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Address";

            // label1
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            label1.Location = new Point(155, 23);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";

            // NameTextBox
            NameTextBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.ForeColor = System.Drawing.Color.White;
            NameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            NameTextBox.Location = new Point(107, 44);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(84, 23);
            NameTextBox.TabIndex = 0;

            // label2
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            label2.Location = new Point(260, 15);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 8;
            label2.Text = "Enter ID";

            // panelID
            panelID.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            panelID.BorderStyle = BorderStyle.FixedSingle;
            panelID.Controls.Add(confirmAction);
            panelID.Controls.Add(ID);
            panelID.Controls.Add(label2);
            panelID.Location = new Point(118, 46);
            panelID.Name = "panelID";
            panelID.Size = new Size(339, 40);
            panelID.TabIndex = 9;

            // confirmAction 
            confirmAction.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            confirmAction.FlatStyle = FlatStyle.Flat;
            confirmAction.FlatAppearance.BorderSize = 0;
            confirmAction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            confirmAction.ForeColor = System.Drawing.Color.FromArgb(18, 18, 18);
            confirmAction.Location = new Point(27, 12);
            confirmAction.Name = "confirmAction";
            confirmAction.Size = new Size(75, 23);
            confirmAction.TabIndex = 8;
            confirmAction.Text = "OK";
            confirmAction.UseVisualStyleBackColor = false;
            confirmAction.Click += confirmAction_Click;

            // ID
            ID.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            ID.BorderStyle = BorderStyle.FixedSingle;
            ID.ForeColor = System.Drawing.Color.White;
            ID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            ID.Location = new Point(145, 12);
            ID.Name = "ID";
            ID.Size = new Size(100, 23);
            ID.TabIndex = 8;

            // UpName
            UpName.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            UpName.BorderStyle = BorderStyle.FixedSingle;
            UpName.ForeColor = System.Drawing.Color.White;
            UpName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            UpName.Location = new Point(118, 94);
            UpName.Name = "UpName";
            UpName.Size = new Size(84, 23);
            UpName.TabIndex = 0;

            // label9
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label9.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            label9.Location = new Point(152, 76);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 1;
            label9.Text = "Name";

            // label8
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label8.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            label8.Location = new Point(48, 76);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 2;
            label8.Text = "Address";

            // label7
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label7.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            label7.Location = new Point(64, 11);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 3;
            label7.Text = "Phone";

            // UpAdress
            UpAdress.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            UpAdress.BorderStyle = BorderStyle.FixedSingle;
            UpAdress.ForeColor = System.Drawing.Color.White;
            UpAdress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            UpAdress.Location = new Point(3, 94);
            UpAdress.Name = "UpAdress";
            UpAdress.Size = new Size(100, 23);
            UpAdress.TabIndex = 4;

            // UpPhone
            UpPhone.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            UpPhone.BorderStyle = BorderStyle.FixedSingle;
            UpPhone.ForeColor = System.Drawing.Color.White;
            UpPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            UpPhone.Location = new Point(10, 29);
            UpPhone.Name = "UpPhone";
            UpPhone.Size = new Size(100, 23);
            UpPhone.TabIndex = 5;

            // checkBox2 
            checkBox2.AutoSize = true;
            checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            checkBox2.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            checkBox2.Location = new Point(98, 136);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Club Member";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;

            // UpdateConfirm
            UpdateConfirm.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            UpdateConfirm.FlatStyle = FlatStyle.Flat;
            UpdateConfirm.FlatAppearance.BorderSize = 0;
            UpdateConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            UpdateConfirm.ForeColor = System.Drawing.Color.FromArgb(18, 18, 18);
            UpdateConfirm.Location = new Point(3, 136);
            UpdateConfirm.Name = "UpdateConfirm";
            UpdateConfirm.Size = new Size(75, 23);
            UpdateConfirm.TabIndex = 7;
            UpdateConfirm.Text = "OK";
            UpdateConfirm.UseVisualStyleBackColor = false;
            UpdateConfirm.Click += UpdateConfirm_Click;

            // label6
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            label6.Location = new Point(179, 11);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 8;
            label6.Text = "ID";

            // UpID
            UpID.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            UpID.BorderStyle = BorderStyle.FixedSingle;
            UpID.ForeColor = System.Drawing.Color.White;
            UpID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            UpID.Location = new Point(165, 29);
            UpID.Name = "UpID";
            UpID.Size = new Size(36, 23);
            UpID.TabIndex = 9;

            // panelUpdate 
            panelUpdate.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            panelUpdate.BorderStyle = BorderStyle.FixedSingle;
            panelUpdate.Controls.Add(label6);
            panelUpdate.Controls.Add(checkBox2);
            panelUpdate.Controls.Add(label7);
            panelUpdate.Controls.Add(label8);
            panelUpdate.Controls.Add(UpAdress);
            panelUpdate.Controls.Add(UpdateConfirm);
            panelUpdate.Controls.Add(UpPhone);
            panelUpdate.Controls.Add(label9);
            panelUpdate.Controls.Add(UpID);
            panelUpdate.Controls.Add(UpName);
            panelUpdate.Location = new Point(244, 133);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(213, 171);
            panelUpdate.TabIndex = 10;
            panelUpdate.Paint += panelUpdate_Paint;

            // panelDelete
            panelDelete.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            panelDelete.BorderStyle = BorderStyle.FixedSingle;
            panelDelete.Controls.Add(DeleteConfirm);
            panelDelete.Controls.Add(IDdelete);
            panelDelete.Controls.Add(label10);
            panelDelete.Location = new Point(118, 87);
            panelDelete.Name = "panelDelete";
            panelDelete.Size = new Size(339, 40);
            panelDelete.TabIndex = 10;

            // DeleteConfirm 
            DeleteConfirm.BackColor = System.Drawing.Color.FromArgb(205, 127, 50); // צבע נחושת אלגנטי לכפתור מחיקה
            DeleteConfirm.FlatStyle = FlatStyle.Flat;
            DeleteConfirm.FlatAppearance.BorderSize = 0;
            DeleteConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            DeleteConfirm.ForeColor = System.Drawing.Color.White;
            DeleteConfirm.Location = new Point(27, 12);
            DeleteConfirm.Name = "DeleteConfirm";
            DeleteConfirm.Size = new Size(75, 23);
            DeleteConfirm.TabIndex = 8;
            DeleteConfirm.Text = "OK";
            DeleteConfirm.UseVisualStyleBackColor = false;
            DeleteConfirm.Click += DeleteConfirm_Click;

            // IDdelete
            IDdelete.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            IDdelete.BorderStyle = BorderStyle.FixedSingle;
            IDdelete.ForeColor = System.Drawing.Color.White;
            IDdelete.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            IDdelete.Location = new Point(145, 12);
            IDdelete.Name = "IDdelete";
            IDdelete.Size = new Size(100, 23);
            IDdelete.TabIndex = 8;

            // label10
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            label10.ForeColor = System.Drawing.Color.FromArgb(205, 127, 50); // תווית נחושת תואמת למחיקה
            label10.Location = new Point(260, 15);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 8;
            label10.Text = "Enter ID";

            // panelShowAll           
            panelShowAll.BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            panelShowAll.BorderStyle = BorderStyle.None;
            panelShowAll.Controls.Add(filterByClub);
            panelShowAll.Controls.Add(closeShowAll);
            panelShowAll.Controls.Add(labelFilter);
            panelShowAll.Controls.Add(filterTextBox);
            panelShowAll.Controls.Add(dataGridViewCustomers);
            panelShowAll.Location = new Point(14, 46);
            panelShowAll.Name = "panelShowAll";
            panelShowAll.Size = new Size(566, 265);
            panelShowAll.TabIndex = 11;

            // חיווט כפתורי אישור פנימיים (מתוך לוגיקת הפאנלים) ואירועים נוספים
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);

            // 
            // Customers Form
            // 
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 18); // שחור מט עמוק
            this.ClientSize = new Size(960, 530);
            Controls.Add(panelShowAll);
            Controls.Add(panelDelete);
            Controls.Add(panelUpdate);
            Controls.Add(panelID);
            Controls.Add(panel1);
            Controls.Add(updateCustomer);
            Controls.Add(createCustomer);
            Controls.Add(showAllCustomers);
            Controls.Add(deleteCustomer);
            Controls.Add(showCustomer);
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premium Appliance - Customers Management";
            this.Load += Customers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelID.ResumeLayout(false);
            panelID.PerformLayout();
            panelUpdate.ResumeLayout(false);
            panelUpdate.PerformLayout();
            panelDelete.ResumeLayout(false);
            panelDelete.PerformLayout();
            panelShowAll.ResumeLayout(false);
            panelShowAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Button showCustomer;
        private Button deleteCustomer;
        private Button showAllCustomers;
        private Button createCustomer;
        private Button updateCustomer;
        private Panel panel1;
        private Label label1;
        private TextBox NameTextBox;
        private Label label4;
        private Label label3;
        private TextBox Phone;
        private TextBox Adress;
        private CheckBox checkBox1;
        private Button confirmCreate;
        private Label label2;
        private Panel panelID;
        private TextBox ID;
        private Button confirmAction;
        private TextBox textBox1;
        private Label label5;
        private Panel panelUpdate;
        private TextBox UpName;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox UpAdress;
        private TextBox UpPhone;
        private CheckBox checkBox2;
        private Button UpdateConfirm;
        private Label label6;
        private TextBox UpID;
        private Panel panelDelete;
        private Button DeleteConfirm;
        private TextBox IDdelete;
        private Label label10;
        private Panel panelShowAll;
        private DataGridView dataGridViewCustomers;
        private TextBox filterTextBox;
        private Label labelFilter;
        private Button closeShowAll;
        private Button filterByClub;
    }
}