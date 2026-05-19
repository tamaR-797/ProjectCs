namespace UI_
{
    partial class Cashier
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            customerId = new TextBox();
            comboProducts = new ComboBox();
            productIdTextBox = new TextBox();
            quantityUpDown = new NumericUpDown();
            addProductButton = new Button();
            dgvOrder = new DataGridView();
            lblTotal = new Label();
            btnDoOrder = new Button();
            buttonManager = new Button();
            buttonShowSales = new Button();
            panelDetails = new Panel();
            lblDetailName = new Label();
            lblDetailUnit = new Label();
            lblDetailQty = new Label();
            lblDetailSalesCount = new Label();
            panelOrder = new Panel();
            panelOpen = new Panel();
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            panelDetails.SuspendLayout();
            panelOrder.SuspendLayout();
            panelOpen.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(212, 175, 55); // זהב שמפניה עשיר
            label1.Location = new Point(960, 15);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 0;
            label1.Text = "עמדת קופה";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(205, 127, 50); // נחושת יוקרתית לאלמנט פתיחה מיוחד
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(255, 255, 255); // לבן מוחלט לקריאות על רקע נחושת
            button1.Location = new Point(20, 12);
            button1.Name = "button1";
            button1.Size = new Size(210, 56);
            button1.TabIndex = 1;
            button1.Text = "OPEN ORDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(245, 245, 220); // גוון שמנת רך לכותרות פנימיות
            label2.Location = new Point(330, 5);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 2;
            label2.Text = "Enter Customer ID";
            // 
            // customerId
            // 
            customerId.BackColor = Color.FromArgb(28, 28, 28); // אפור אובסידיאן כהה
            customerId.BorderStyle = BorderStyle.FixedSingle;
            customerId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            customerId.ForeColor = Color.FromArgb(255, 255, 255); // לבן מוחלט לנתונים
            customerId.Location = new Point(330, 28);
            customerId.Name = "customerId";
            customerId.Size = new Size(140, 27);
            customerId.TabIndex = 3;
            // 
            // comboProducts
            // 
            comboProducts.BackColor = Color.FromArgb(28, 28, 28); // אפור אובסידיאן כהה
            comboProducts.FlatStyle = FlatStyle.Flat;
            comboProducts.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboProducts.ForeColor = Color.FromArgb(255, 255, 255); // לבן מוחלט
            comboProducts.Location = new Point(20, 21);
            comboProducts.Name = "comboProducts";
            comboProducts.Size = new Size(241, 25);
            comboProducts.TabIndex = 4;
            comboProducts.SelectedIndexChanged += comboProducts_SelectedIndexChanged;
            // 
            // productIdTextBox
            // 
            productIdTextBox.BackColor = Color.FromArgb(28, 28, 28); // אפור אובסידיאן כהה
            productIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            productIdTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            productIdTextBox.ForeColor = Color.FromArgb(255, 255, 255); // לבן מוחלט
            productIdTextBox.Location = new Point(280, 21);
            productIdTextBox.Name = "productIdTextBox";
            productIdTextBox.Size = new Size(81, 25);
            productIdTextBox.TabIndex = 5;
            // 
            // quantityUpDown
            // 
            quantityUpDown.BackColor = Color.FromArgb(28, 28, 28); // אפור אובסידיאן כהה
            quantityUpDown.BorderStyle = BorderStyle.FixedSingle;
            quantityUpDown.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            quantityUpDown.ForeColor = Color.FromArgb(255, 255, 255); // לבן מוחלט
            quantityUpDown.Location = new Point(380, 21);
            quantityUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quantityUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            quantityUpDown.Name = "quantityUpDown";
            quantityUpDown.Size = new Size(60, 25);
            quantityUpDown.TabIndex = 6;
            quantityUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            quantityUpDown.ValueChanged += quantityUpDown_ValueChanged;
            // 
            // addProductButton
            // 
            addProductButton.BackColor = Color.FromArgb(28, 28, 28); // אפור אובסידיאן
            addProductButton.FlatStyle = FlatStyle.Flat;
            addProductButton.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55); // מסגרת זהב שמפניה
            addProductButton.FlatAppearance.BorderSize = 1;
            addProductButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addProductButton.ForeColor = Color.FromArgb(212, 175, 55); // טקסט בזהב שמפניה
            addProductButton.Location = new Point(460, 16);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(96, 32);
            addProductButton.TabIndex = 7;
            addProductButton.Text = "Add Item";
            addProductButton.UseVisualStyleBackColor = false;
            addProductButton.Click += addProductButton_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.BackgroundColor = Color.FromArgb(28, 28, 28); // אפור אובסידיאן כהה ליצירת עומק ושכבות
            dgvOrder.BorderStyle = BorderStyle.None;
            dgvOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18); // כותרות הטבלה ברקע שחור מט עמוק
            dgvOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(245, 245, 220); // כותרות בגוון שמנת רך
            dgvOrder.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvOrder.EnableHeadersVisualStyles = false;
            dgvOrder.GridColor = Color.FromArgb(40, 40, 40); // קווי רשת מעודנים וכהים יותר
            dgvOrder.DefaultCellStyle.BackColor = Color.FromArgb(28, 28, 28);
            dgvOrder.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // נתונים בטבלה בלבן מוחלט לקריאות מושלמת
            dgvOrder.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 175, 55); // בחירה בגוון זהב שמפניה
            dgvOrder.DefaultCellStyle.SelectionForeColor = Color.FromArgb(18, 18, 18); // טקסט שחור על רקע הבחירה המוזהב
            dgvOrder.Location = new Point(20, 68);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(670, 320);
            dgvOrder.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(212, 175, 55); // זהב שמפניה בולט לסיכום
            lblTotal.Location = new Point(20, 415);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(200, 35);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total: 0 ₪";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnDoOrder
            // 
            btnDoOrder.BackColor = Color.FromArgb(212, 175, 55); // כפתור פעולה ראשי מוזהב ומלא
            btnDoOrder.FlatStyle = FlatStyle.Flat;
            btnDoOrder.FlatAppearance.BorderSize = 0;
            btnDoOrder.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoOrder.ForeColor = Color.FromArgb(18, 18, 18); // טקסט כהה על רקע מוזהב לניגודיות יוקרתית
            btnDoOrder.Location = new Point(270, 395);
            btnDoOrder.Name = "btnDoOrder";
            btnDoOrder.Size = new Size(210, 65);
            btnDoOrder.TabIndex = 10;
            btnDoOrder.Text = "COMPLETE ORDER";
            btnDoOrder.UseVisualStyleBackColor = false;
            btnDoOrder.Click += btnDoOrder_Click;
            // 
            // buttonManager
            // 
            buttonManager.BackColor = Color.FromArgb(28, 28, 28);
            buttonManager.FlatStyle = FlatStyle.Flat;
            buttonManager.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50); // מסגרת כהה ומושתקת
            buttonManager.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            buttonManager.ForeColor = Color.FromArgb(245, 245, 220); // שמנת רך לטקסט משני ומרוחק
            buttonManager.Location = new Point(960, 630);
            buttonManager.Name = "buttonManager";
            buttonManager.Size = new Size(130, 35);
            buttonManager.TabIndex = 11;
            buttonManager.Text = "Manager Dashboard";
            buttonManager.UseVisualStyleBackColor = false;
            buttonManager.Click += buttonManager_Click;
            // 
            // buttonShowSales
            // 
            buttonShowSales.BackColor = Color.FromArgb(28, 28, 28);
            buttonShowSales.FlatStyle = FlatStyle.Flat;
            buttonShowSales.FlatAppearance.BorderColor = Color.FromArgb(205, 127, 50); // מסגרת נחושת יוקרתית למבצעים
            buttonShowSales.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonShowSales.ForeColor = Color.FromArgb(205, 127, 50); // טקסט בצבע נחושת
            buttonShowSales.Location = new Point(540, 410);
            buttonShowSales.Name = "buttonShowSales";
            buttonShowSales.Size = new Size(150, 35);
            buttonShowSales.TabIndex = 13;
            buttonShowSales.Text = "מבצעים מיוחדים 🌟";
            buttonShowSales.UseVisualStyleBackColor = false;
            buttonShowSales.Click += buttonShowSales_Click;
            // 
            // panelDetails
            // 
            panelDetails.BackColor = Color.FromArgb(28, 28, 28); // רקע פאנל אפור אובסידיאן כהה
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelDetails.Controls.Add(lblDetailName);
            panelDetails.Controls.Add(lblDetailUnit);
            panelDetails.Controls.Add(lblDetailQty);
            panelDetails.Controls.Add(lblDetailSalesCount);
            panelDetails.Location = new Point(845, 135);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(250, 180);
            panelDetails.TabIndex = 11;
            // 
            // lblDetailName
            // 
            lblDetailName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDetailName.ForeColor = Color.FromArgb(255, 255, 255); // לבן מוחלט
            lblDetailName.Location = new Point(15, 15);
            lblDetailName.Name = "lblDetailName";
            lblDetailName.Size = new Size(220, 25);
            lblDetailName.TabIndex = 0;
            lblDetailName.Text = "Product Name:";
            // 
            // lblDetailUnit
            // 
            lblDetailUnit.Font = new Font("Segoe UI", 10F);
            lblDetailUnit.ForeColor = Color.FromArgb(245, 245, 220); // כותרות נתונים בשמנת רך
            lblDetailUnit.Location = new Point(15, 50);
            lblDetailUnit.Name = "lblDetailUnit";
            lblDetailUnit.Size = new Size(220, 25);
            lblDetailUnit.TabIndex = 1;
            lblDetailUnit.Text = "Unit price:";
            lblDetailUnit.Click += lblDetailUnit_Click;
            // 
            // lblDetailQty
            // 
            lblDetailQty.Font = new Font("Segoe UI", 10F);
            lblDetailQty.ForeColor = Color.FromArgb(245, 245, 220); // שמנת רך
            lblDetailQty.Location = new Point(15, 85);
            lblDetailQty.Name = "lblDetailQty";
            lblDetailQty.Size = new Size(220, 25);
            lblDetailQty.TabIndex = 2;
            lblDetailQty.Text = "Available Quantity:";
            // 
            // lblDetailSalesCount
            // 
            lblDetailSalesCount.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblDetailSalesCount.ForeColor = Color.FromArgb(205, 127, 50); // נחושת יוקרתית לאלמנט מבצעים מיוחד
            lblDetailSalesCount.Location = new Point(15, 125);
            lblDetailSalesCount.Name = "lblDetailSalesCount";
            lblDetailSalesCount.Size = new Size(220, 25);
            lblDetailSalesCount.TabIndex = 4;
            lblDetailSalesCount.Text = "Active sales: 0";
            // 
            // panelOrder
            // 
            panelOrder.BackColor = Color.FromArgb(28, 28, 28); // אפור אובסידיאן כהה ליצירת שכבה מעל הרקע הראשי
            panelOrder.Controls.Add(addProductButton);
            panelOrder.Controls.Add(quantityUpDown);
            panelOrder.Controls.Add(productIdTextBox);
            panelOrder.Controls.Add(buttonShowSales);
            panelOrder.Controls.Add(comboProducts);
            panelOrder.Controls.Add(dgvOrder);
            panelOrder.Controls.Add(lblTotal);
            panelOrder.Controls.Add(btnDoOrder);
            panelOrder.Location = new Point(95, 135);
            panelOrder.Name = "panelOrder";
            panelOrder.Size = new Size(714, 485);
            panelOrder.TabIndex = 14;
            // 
            // panelOpen
            // 
            panelOpen.BackColor = Color.FromArgb(28, 28, 28); // אפור אובסידיאן כהה
            panelOpen.Controls.Add(button1);
            panelOpen.Controls.Add(customerId);
            panelOpen.Controls.Add(label2);
            panelOpen.Location = new Point(312, 48);
            panelOpen.Name = "panelOpen";
            panelOpen.Size = new Size(497, 81);
            panelOpen.TabIndex = 11;
            panelOpen.Paint += panelOpen_Paint;
            // 
            // Cashier
            // 
            BackColor = Color.FromArgb(18, 18, 18); // רקע ראשי (Form) שחור מט עמוק
            ClientSize = new Size(1116, 684);
            Controls.Add(panelOpen);
            Controls.Add(panelOrder);
            Controls.Add(label1);
            Controls.Add(panelDetails);
            Controls.Add(buttonManager);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cashier";
            Text = "Boutique Appliance System - Cashier Station";
            Load += Cashier_Load;
            ((System.ComponentModel.ISupportInitialize)quantityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            panelDetails.ResumeLayout(false);
            panelOrder.ResumeLayout(false);
            panelOrder.PerformLayout();
            panelOpen.ResumeLayout(false);
            panelOpen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.ComboBox comboProducts;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnDoOrder;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonShowSales;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.Label lblDetailUnit;
        private System.Windows.Forms.Label lblDetailQty;
        private System.Windows.Forms.Label lblDetailSalesCount;
        private Panel panelOrder;
        private Panel panelOpen;
    }
}