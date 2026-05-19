namespace UI_
{
    partial class Sales
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
            showSale = new Button();
            deleteSale = new Button();
            showAllSales = new Button();
            createSale = new Button();
            updateSale = new Button();
            panel1 = new Panel();
            endDatePicker = new DateTimePicker();
            startDatePicker = new DateTimePicker();
            clubCheckBox = new CheckBox();
            costTextBox = new TextBox();
            amountTextBox = new TextBox();
            productComboBox = new ComboBox();
            confirmCreate = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelID = new Panel();
            confirmAction = new Button();
            idTextBox = new TextBox();
            labelID = new Label();
            panelUpdate = new Panel();
            upEndDatePicker = new DateTimePicker();
            upStartDatePicker = new DateTimePicker();
            clubCheckBoxUpdate = new CheckBox();
            upCostTextBox = new TextBox();
            upAmountTextBox = new TextBox();
            productComboBoxUpdate = new ComboBox();
            UpdateConfirm = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            upIdTextBox = new TextBox();
            panelDelete = new Panel();
            DeleteConfirm = new Button();
            idDeleteTextBox = new TextBox();
            labelIDDelete = new Label();
            panelShowAll = new Panel();
            filterByProduct = new Button();
            filterByClub = new Button();
            closeShowAll = new Button();
            labelFilter = new Label();
            filterTextBox = new TextBox();
            dataGridViewSales = new DataGridView();
            productFilterComboBox = new ComboBox();
            label12 = new Label();
            panel1.SuspendLayout();
            panelID.SuspendLayout();
            panelUpdate.SuspendLayout();
            panelDelete.SuspendLayout();
            panelShowAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            SuspendLayout();

            // הגדרות פונטים וצבעים של קו הפרימיום הכהה
            var premiumFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            var headerFont = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            var mainBgColor = Color.FromArgb(18, 18, 18);       // שחור פחם עמוק
            var panelBgColor = Color.FromArgb(30, 30, 30);     // אפור כהה מאוד לפאנלים
            var textLightColor = Color.FromArgb(224, 224, 224); // אופ-וייט רך וקריא
            var goldAccent = Color.FromArgb(212, 175, 55);     // זהב שמפניה נקי
            var copperAccent = Color.FromArgb(205, 127, 50);    // נחושת מעודנת (לאקשן שלילי/מחיקה)
            var silverAccent = Color.FromArgb(176, 176, 176);    // כסף פלטינה למסגרות וכפתורים ניטרליים

            // 
            // showSale
            // 
            showSale.Location = new Point(594, 77);
            showSale.Name = "showSale";
            showSale.Size = new Size(150, 45);
            showSale.TabIndex = 0;
            showSale.Text = "Show Sale";
            showSale.Click += showSale_Click;
            showSale.Font = premiumFont;
            showSale.BackColor = panelBgColor;
            showSale.ForeColor = textLightColor;
            showSale.FlatStyle = FlatStyle.Flat;
            showSale.FlatAppearance.BorderColor = silverAccent;
            showSale.FlatAppearance.BorderSize = 1;
            // 
            // deleteSale
            // 
            deleteSale.Location = new Point(594, 209);
            deleteSale.Name = "deleteSale";
            deleteSale.Size = new Size(150, 45);
            deleteSale.TabIndex = 1;
            deleteSale.Text = "Delete Sale";
            deleteSale.Click += deleteSale_Click;
            deleteSale.Font = premiumFont;
            deleteSale.BackColor = panelBgColor;
            deleteSale.ForeColor = textLightColor;
            deleteSale.FlatStyle = FlatStyle.Flat;
            deleteSale.FlatAppearance.BorderColor = copperAccent;
            deleteSale.FlatAppearance.BorderSize = 1;
            // 
            // showAllSales
            // 
            showAllSales.Location = new Point(594, 121);
            showAllSales.Name = "showAllSales";
            showAllSales.Size = new Size(150, 45);
            showAllSales.TabIndex = 2;
            showAllSales.Text = "Show All Sales";
            showAllSales.Click += showAllSales_Click;
            showAllSales.Font = premiumFont;
            showAllSales.BackColor = panelBgColor;
            showAllSales.ForeColor = textLightColor;
            showAllSales.FlatStyle = FlatStyle.Flat;
            showAllSales.FlatAppearance.BorderColor = silverAccent;
            showAllSales.FlatAppearance.BorderSize = 1;
            // 
            // createSale
            // 
            createSale.Location = new Point(594, 165);
            createSale.Name = "createSale";
            createSale.Size = new Size(150, 45);
            createSale.TabIndex = 2;
            createSale.Text = "Create Sale";
            createSale.Click += createSale_Click;
            createSale.Font = premiumFont;
            createSale.BackColor = panelBgColor;
            createSale.ForeColor = textLightColor;
            createSale.FlatStyle = FlatStyle.Flat;
            createSale.FlatAppearance.BorderColor = goldAccent;
            createSale.FlatAppearance.BorderSize = 1;
            // 
            // updateSale
            // 
            updateSale.Location = new Point(594, 253);
            updateSale.Name = "updateSale";
            updateSale.Size = new Size(150, 45);
            updateSale.TabIndex = 3;
            updateSale.Text = "Update Sale";
            updateSale.Click += updateSale_Click;
            updateSale.Font = premiumFont;
            updateSale.BackColor = panelBgColor;
            updateSale.ForeColor = textLightColor;
            updateSale.FlatStyle = FlatStyle.Flat;
            updateSale.FlatAppearance.BorderColor = silverAccent;
            updateSale.FlatAppearance.BorderSize = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(endDatePicker);
            panel1.Controls.Add(startDatePicker);
            panel1.Controls.Add(clubCheckBox);
            panel1.Controls.Add(costTextBox);
            panel1.Controls.Add(amountTextBox);
            panel1.Controls.Add(productComboBox);
            panel1.Controls.Add(confirmCreate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 260);
            panel1.TabIndex = 4;
            panel1.BackColor = panelBgColor;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(115, 181);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(95, 27);
            endDatePicker.TabIndex = 11;
            endDatePicker.CalendarMonthBackground = mainBgColor;
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(5, 181);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(95, 27);
            startDatePicker.TabIndex = 10;
            startDatePicker.CalendarMonthBackground = mainBgColor;
            // 
            // clubCheckBox
            // 
            clubCheckBox.AutoSize = true;
            clubCheckBox.Location = new Point(5, 150);
            clubCheckBox.Name = "clubCheckBox";
            clubCheckBox.Size = new Size(130, 23);
            clubCheckBox.TabIndex = 9;
            clubCheckBox.Text = "Club Members";
            clubCheckBox.Font = premiumFont;
            clubCheckBox.ForeColor = textLightColor;
            // 
            // costTextBox
            // 
            costTextBox.Location = new Point(115, 110);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(95, 27);
            costTextBox.TabIndex = 8;
            costTextBox.Font = premiumFont;
            costTextBox.BackColor = mainBgColor;
            costTextBox.ForeColor = textLightColor;
            costTextBox.BorderStyle = BorderStyle.FixedSingle;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(5, 110);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(95, 27);
            amountTextBox.TabIndex = 7;
            amountTextBox.Font = premiumFont;
            amountTextBox.BackColor = mainBgColor;
            amountTextBox.ForeColor = textLightColor;
            amountTextBox.BorderStyle = BorderStyle.FixedSingle;
            // 
            // productComboBox
            // 
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(5, 66);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(205, 27);
            productComboBox.TabIndex = 6;
            productComboBox.Font = premiumFont;
            productComboBox.BackColor = mainBgColor;
            productComboBox.ForeColor = textLightColor;
            // 
            // confirmCreate
            // 
            confirmCreate.Location = new Point(65, 220);
            confirmCreate.Name = "confirmCreate";
            confirmCreate.Size = new Size(90, 32);
            confirmCreate.TabIndex = 5;
            confirmCreate.Text = "OK";
            confirmCreate.Click += confirmCreate_Click;
            confirmCreate.Font = headerFont;
            confirmCreate.BackColor = goldAccent;
            confirmCreate.ForeColor = mainBgColor;
            confirmCreate.FlatStyle = FlatStyle.Flat;
            confirmCreate.FlatAppearance.BorderSize = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 155);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 4;
            label5.Text = "End Date";
            label5.Font = premiumFont;
            label5.ForeColor = textLightColor;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 92);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 3;
            label4.Text = "Cost";
            label4.Font = premiumFont;
            label4.ForeColor = textLightColor;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 92);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 2;
            label3.Text = "Amount";
            label3.Font = premiumFont;
            label3.ForeColor = textLightColor;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 46);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 1;
            label2.Text = "Product";
            label2.Font = premiumFont;
            label2.ForeColor = textLightColor;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 155);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 1;
            label1.Text = "Start Date";
            label1.Font = premiumFont;
            label1.ForeColor = textLightColor;
            // 
            // panelID
            // 
            panelID.Controls.Add(confirmAction);
            panelID.Controls.Add(idTextBox);
            panelID.Controls.Add(labelID);
            panelID.Location = new Point(118, 46);
            panelID.Name = "panelID";
            panelID.Size = new Size(360, 50);
            panelID.TabIndex = 9;
            panelID.BackColor = panelBgColor;
            // 
            // confirmAction
            // 
            confirmAction.Location = new Point(15, 10);
            confirmAction.Name = "confirmAction";
            confirmAction.Size = new Size(80, 30);
            confirmAction.TabIndex = 8;
            confirmAction.Text = "OK";
            confirmAction.Click += confirmAction_Click;
            confirmAction.Font = headerFont;
            confirmAction.BackColor = goldAccent;
            confirmAction.ForeColor = mainBgColor;
            confirmAction.FlatStyle = FlatStyle.Flat;
            confirmAction.FlatAppearance.BorderSize = 0;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(135, 11);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(110, 27);
            idTextBox.TabIndex = 8;
            idTextBox.Font = premiumFont;
            idTextBox.BackColor = mainBgColor;
            idTextBox.ForeColor = textLightColor;
            idTextBox.BorderStyle = BorderStyle.FixedSingle;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(260, 15);
            labelID.Name = "labelID";
            labelID.Size = new Size(58, 19);
            labelID.TabIndex = 8;
            labelID.Text = "Enter ID";
            labelID.Font = premiumFont;
            labelID.ForeColor = textLightColor;
            // 
            // panelUpdate
            // 
            panelUpdate.Controls.Add(upEndDatePicker);
            panelUpdate.Controls.Add(upStartDatePicker);
            panelUpdate.Controls.Add(clubCheckBoxUpdate);
            panelUpdate.Controls.Add(upCostTextBox);
            panelUpdate.Controls.Add(upAmountTextBox);
            panelUpdate.Controls.Add(productComboBoxUpdate);
            panelUpdate.Controls.Add(UpdateConfirm);
            panelUpdate.Controls.Add(label10);
            panelUpdate.Controls.Add(label9);
            panelUpdate.Controls.Add(label8);
            panelUpdate.Controls.Add(label7);
            panelUpdate.Controls.Add(label6);
            panelUpdate.Controls.Add(upIdTextBox);
            panelUpdate.Location = new Point(270, 133);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(230, 260);
            panelUpdate.TabIndex = 10;
            panelUpdate.BackColor = panelBgColor;
            // 
            // upEndDatePicker
            // 
            upEndDatePicker.Location = new Point(120, 181);
            upEndDatePicker.Name = "upEndDatePicker";
            upEndDatePicker.Size = new Size(95, 27);
            upEndDatePicker.TabIndex = 13;
            // 
            // upStartDatePicker
            // 
            upStartDatePicker.Location = new Point(5, 181);
            upStartDatePicker.Name = "upStartDatePicker";
            upStartDatePicker.Size = new Size(95, 27);
            upStartDatePicker.TabIndex = 12;
            // 
            // clubCheckBoxUpdate
            // 
            clubCheckBoxUpdate.AutoSize = true;
            clubCheckBoxUpdate.Location = new Point(5, 150);
            clubCheckBoxUpdate.Name = "clubCheckBoxUpdate";
            clubCheckBoxUpdate.Size = new Size(130, 23);
            clubCheckBoxUpdate.TabIndex = 11;
            clubCheckBoxUpdate.Text = "Club Members";
            clubCheckBoxUpdate.Font = premiumFont;
            clubCheckBoxUpdate.ForeColor = textLightColor;
            // 
            // upCostTextBox
            // 
            upCostTextBox.Location = new Point(120, 110);
            upCostTextBox.Name = "upCostTextBox";
            upCostTextBox.Size = new Size(95, 27);
            upCostTextBox.TabIndex = 8;
            upCostTextBox.Font = premiumFont;
            upCostTextBox.BackColor = mainBgColor;
            upCostTextBox.ForeColor = textLightColor;
            upCostTextBox.BorderStyle = BorderStyle.FixedSingle;
            // 
            // upAmountTextBox
            // 
            upAmountTextBox.Location = new Point(5, 110);
            upAmountTextBox.Name = "upAmountTextBox";
            upAmountTextBox.Size = new Size(95, 27);
            upAmountTextBox.TabIndex = 7;
            upAmountTextBox.Font = premiumFont;
            upAmountTextBox.BackColor = mainBgColor;
            upAmountTextBox.ForeColor = textLightColor;
            upAmountTextBox.BorderStyle = BorderStyle.FixedSingle;
            // 
            // productComboBoxUpdate
            // 
            productComboBoxUpdate.FormattingEnabled = true;
            productComboBoxUpdate.Location = new Point(5, 66);
            productComboBoxUpdate.Name = "productComboBoxUpdate";
            productComboBoxUpdate.Size = new Size(210, 27);
            productComboBoxUpdate.TabIndex = 6;
            productComboBoxUpdate.Font = premiumFont;
            productComboBoxUpdate.BackColor = mainBgColor;
            productComboBoxUpdate.ForeColor = textLightColor;
            // 
            // UpdateConfirm
            // 
            UpdateConfirm.Location = new Point(70, 220);
            UpdateConfirm.Name = "UpdateConfirm";
            UpdateConfirm.Size = new Size(90, 32);
            UpdateConfirm.TabIndex = 5;
            UpdateConfirm.Text = "OK";
            UpdateConfirm.Click += UpdateConfirm_Click;
            UpdateConfirm.Font = headerFont;
            UpdateConfirm.BackColor = goldAccent;
            UpdateConfirm.ForeColor = mainBgColor;
            UpdateConfirm.FlatStyle = FlatStyle.Flat;
            UpdateConfirm.FlatAppearance.BorderSize = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(120, 155);
            label10.Name = "label10";
            label10.Size = new Size(65, 19);
            label10.TabIndex = 4;
            label10.Text = "End Date";
            label10.Font = premiumFont;
            label10.ForeColor = textLightColor;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(120, 92);
            label9.Name = "label9";
            label9.Size = new Size(36, 19);
            label9.TabIndex = 3;
            label9.Text = "Cost";
            label9.Font = premiumFont;
            label9.ForeColor = textLightColor;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 92);
            label8.Name = "label8";
            label8.Size = new Size(59, 19);
            label8.TabIndex = 2;
            label8.Text = "Amount";
            label8.Font = premiumFont;
            label8.ForeColor = textLightColor;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 46);
            label7.Name = "label7";
            label7.Size = new Size(57, 19);
            label7.TabIndex = 1;
            label7.Text = "Product";
            label7.Font = premiumFont;
            label7.ForeColor = textLightColor;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 12);
            label6.Name = "label6";
            label6.Size = new Size(23, 19);
            label6.TabIndex = 1;
            label6.Text = "ID";
            label6.Font = premiumFont;
            label6.ForeColor = textLightColor;
            // 
            // upIdTextBox
            // 
            upIdTextBox.Location = new Point(35, 8);
            upIdTextBox.Name = "upIdTextBox";
            upIdTextBox.Size = new Size(70, 27);
            upIdTextBox.TabIndex = 0;
            upIdTextBox.Font = premiumFont;
            upIdTextBox.BackColor = mainBgColor;
            upIdTextBox.ForeColor = textLightColor;
            upIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            // 
            // panelDelete
            // 
            panelDelete.Controls.Add(DeleteConfirm);
            panelDelete.Controls.Add(idDeleteTextBox);
            panelDelete.Controls.Add(labelIDDelete);
            panelDelete.Location = new Point(118, 87);
            panelDelete.Name = "panelDelete";
            panelDelete.Size = new Size(360, 45);
            panelDelete.TabIndex = 10;
            panelDelete.BackColor = panelBgColor;
            // 
            // DeleteConfirm
            // 
            DeleteConfirm.Location = new Point(15, 8);
            DeleteConfirm.Name = "DeleteConfirm";
            DeleteConfirm.Size = new Size(80, 30);
            DeleteConfirm.TabIndex = 8;
            DeleteConfirm.Text = "OK";
            DeleteConfirm.Click += DeleteConfirm_Click;
            DeleteConfirm.Font = headerFont;
            DeleteConfirm.BackColor = copperAccent;
            DeleteConfirm.ForeColor = textLightColor;
            DeleteConfirm.FlatStyle = FlatStyle.Flat;
            DeleteConfirm.FlatAppearance.BorderSize = 0;
            // 
            // idDeleteTextBox
            // 
            idDeleteTextBox.Location = new Point(135, 9);
            idDeleteTextBox.Name = "idDeleteTextBox";
            idDeleteTextBox.Size = new Size(110, 27);
            idDeleteTextBox.TabIndex = 8;
            idDeleteTextBox.Font = premiumFont;
            idDeleteTextBox.BackColor = mainBgColor;
            idDeleteTextBox.ForeColor = textLightColor;
            idDeleteTextBox.BorderStyle = BorderStyle.FixedSingle;
            // 
            // labelIDDelete
            // 
            labelIDDelete.AutoSize = true;
            labelIDDelete.Location = new Point(260, 12);
            labelIDDelete.Name = "labelIDDelete";
            labelIDDelete.Size = new Size(58, 19);
            labelIDDelete.TabIndex = 8;
            labelIDDelete.Text = "Enter ID";
            labelIDDelete.Font = premiumFont;
            labelIDDelete.ForeColor = textLightColor;
            // 
            // panelShowAll
            // 
            panelShowAll.Controls.Add(filterByProduct);
            panelShowAll.Controls.Add(label12);
            panelShowAll.Controls.Add(productFilterComboBox);
            panelShowAll.Controls.Add(filterByClub);
            panelShowAll.Controls.Add(closeShowAll);
            panelShowAll.Controls.Add(labelFilter);
            panelShowAll.Controls.Add(filterTextBox);
            panelShowAll.Controls.Add(dataGridViewSales);
            panelShowAll.Location = new Point(14, 46);
            panelShowAll.Name = "panelShowAll";
            panelShowAll.Size = new Size(566, 350);
            panelShowAll.TabIndex = 11;
            panelShowAll.BackColor = panelBgColor;
            // 
            // filterByProduct
            // 
            filterByProduct.Location = new Point(249, 45);
            filterByProduct.Margin = new Padding(2);
            filterByProduct.Name = "filterByProduct";
            filterByProduct.Size = new Size(179, 28);
            filterByProduct.TabIndex = 7;
            filterByProduct.Text = "Filter by Product";
            filterByProduct.Click += filterByProduct_Click;
            filterByProduct.Font = premiumFont;
            filterByProduct.BackColor = mainBgColor;
            filterByProduct.ForeColor = textLightColor;
            filterByProduct.FlatStyle = FlatStyle.Flat;
            filterByProduct.FlatAppearance.BorderColor = silverAccent;
            // 
            // filterByClub
            // 
            filterByClub.Location = new Point(249, 10);
            filterByClub.Margin = new Padding(2);
            filterByClub.Name = "filterByClub";
            filterByClub.Size = new Size(179, 28);
            filterByClub.TabIndex = 4;
            filterByClub.Text = "Only Club Members";
            filterByClub.Click += filterByClub_Click;
            filterByClub.Font = premiumFont;
            filterByClub.BackColor = mainBgColor;
            filterByClub.ForeColor = textLightColor;
            filterByClub.FlatStyle = FlatStyle.Flat;
            filterByClub.FlatAppearance.BorderColor = silverAccent;
            // 
            // closeShowAll
            // 
            closeShowAll.Location = new Point(500, 10);
            closeShowAll.Name = "closeShowAll";
            closeShowAll.Size = new Size(50, 25);
            closeShowAll.TabIndex = 3;
            closeShowAll.Text = "X";
            closeShowAll.Click += closeShowAll_Click;
            closeShowAll.Font = headerFont;
            closeShowAll.BackColor = Color.FromArgb(200, 50, 50); // כפתור אדום קלאסי מעודן לסגירה
            closeShowAll.ForeColor = Color.White;
            closeShowAll.FlatStyle = FlatStyle.Flat;
            closeShowAll.FlatAppearance.BorderSize = 0;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(10, 12);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(42, 19);
            labelFilter.TabIndex = 2;
            labelFilter.Text = "Filter:";
            labelFilter.Font = premiumFont;
            labelFilter.ForeColor = textLightColor;
            // 
            // filterTextBox
            // 
            filterTextBox.Location = new Point(65, 9);
            filterTextBox.Name = "filterTextBox";
            filterTextBox.PlaceholderText = "Search by Product ID";
            filterTextBox.Size = new Size(150, 27);
            filterTextBox.TabIndex = 1;
            filterTextBox.TextChanged += filterTextBox_TextChanged;
            filterTextBox.Font = premiumFont;
            filterTextBox.BackColor = mainBgColor;
            filterTextBox.ForeColor = textLightColor;
            filterTextBox.BorderStyle = BorderStyle.FixedSingle;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Location = new Point(10, 85);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.ReadOnly = true;
            dataGridViewSales.RowHeadersWidth = 62;
            dataGridViewSales.Size = new Size(540, 250);
            dataGridViewSales.TabIndex = 0;
            // עיצוב פרימיום כהה ומלוטש במיוחד לטבלה
            dataGridViewSales.BackgroundColor = panelBgColor;
            dataGridViewSales.BorderStyle = BorderStyle.None;
            dataGridViewSales.EnableHeadersVisualStyles = false;
            dataGridViewSales.GridColor = Color.FromArgb(50, 50, 50);
            dataGridViewSales.ColumnHeadersDefaultCellStyle.BackColor = mainBgColor;
            dataGridViewSales.ColumnHeadersDefaultCellStyle.ForeColor = goldAccent;
            dataGridViewSales.ColumnHeadersDefaultCellStyle.Font = headerFont;
            dataGridViewSales.DefaultCellStyle.BackColor = panelBgColor;
            dataGridViewSales.DefaultCellStyle.ForeColor = textLightColor;
            dataGridViewSales.DefaultCellStyle.Font = premiumFont;
            dataGridViewSales.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewSales.DefaultCellStyle.SelectionForeColor = goldAccent;
            // 
            // productFilterComboBox
            // 
            productFilterComboBox.FormattingEnabled = true;
            productFilterComboBox.Location = new Point(65, 45);
            productFilterComboBox.Name = "productFilterComboBox";
            productFilterComboBox.Size = new Size(150, 27);
            productFilterComboBox.TabIndex = 8;
            productFilterComboBox.Font = premiumFont;
            productFilterComboBox.BackColor = mainBgColor;
            productFilterComboBox.ForeColor = textLightColor;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 48);
            label12.Name = "label12";
            label12.Size = new Size(60, 19);
            label12.TabIndex = 2;
            label12.Text = "Product:";
            label12.Font = premiumFont;
            label12.ForeColor = textLightColor;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(panelShowAll);
            Controls.Add(panelDelete);
            Controls.Add(panelUpdate);
            Controls.Add(panelID);
            Controls.Add(panel1);
            Controls.Add(updateSale);
            Controls.Add(createSale);
            Controls.Add(showAllSales);
            Controls.Add(deleteSale);
            Controls.Add(showSale);
            Name = "Sales";
            Text = "Sales System";
            Load += Sales_Load;
            BackColor = mainBgColor;
            ForeColor = textLightColor;
            Font = premiumFont;
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Button showSale;
        private Button deleteSale;
        private Button showAllSales;
        private Button createSale;
        private Button updateSale;
        private Panel panel1;
        private Label label1;
        private TextBox amountTextBox;
        private TextBox costTextBox;
        private ComboBox productComboBox;
        private Button confirmCreate;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox clubCheckBox;
        private Label label5;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private Panel panelID;
        private TextBox idTextBox;
        private Button confirmAction;
        private Label labelID;
        private Panel panelUpdate;
        private TextBox upIdTextBox;
        private ComboBox productComboBoxUpdate;
        private TextBox upAmountTextBox;
        private TextBox upCostTextBox;
        private CheckBox clubCheckBoxUpdate;
        private DateTimePicker upStartDatePicker;
        private DateTimePicker upEndDatePicker;
        private Button UpdateConfirm;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panelDelete;
        private Label labelIDDelete;
        private TextBox idDeleteTextBox;
        private Button DeleteConfirm;
        private Panel panelShowAll;
        private DataGridView dataGridViewSales;
        private TextBox filterTextBox;
        private Label labelFilter;
        private Button closeShowAll;
        private Button filterByClub;
        private Button filterByProduct;
        private ComboBox productFilterComboBox;
        private Label label12;
    }
}