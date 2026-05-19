using System.Drawing;
using System.Windows.Forms;

namespace UI_
{
    partial class Manager
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
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();

            // 
            // label1 (כותרת פאנל מנהל)
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(212, 175, 55); // זהב שמפניה
            label1.Location = new Point(340, 40);
            label1.Name = "label1";
            label1.Size = new Size(120, 47);
            label1.TabIndex = 0;
            label1.Text = "מנהל";

            // 
            // button1 (לקוחות)
            // 
            button1.BackColor = Color.FromArgb(28, 28, 28); // אפור אובסידיאן כהה
            button1.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55); // מסגרת זהב שמפניה
            button1.FlatAppearance.BorderSize = 1;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(255, 255, 255);
            button1.Location = new Point(530, 160);
            button1.Name = "button1";
            button1.Size = new Size(180, 80);
            button1.TabIndex = 1;
            button1.Text = "לקוחות";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // 
            // button2 (מוצרים)
            // 
            button2.BackColor = Color.FromArgb(28, 28, 28);
            button2.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55); // מסגרת זהב שמפניה
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(255, 255, 255);
            button2.Location = new Point(90, 160);
            button2.Name = "button2";
            button2.Size = new Size(180, 80);
            button2.TabIndex = 2;
            button2.Text = "מוצרים";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;

            // 
            // button3 (מבצעים)
            // 
            button3.BackColor = Color.FromArgb(28, 28, 28);
            button3.FlatAppearance.BorderColor = Color.FromArgb(205, 127, 50); // מסגרת נחושת יוקרתית למבצעים
            button3.FlatAppearance.BorderSize = 1;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(255, 255, 255);
            button3.Location = new Point(310, 160);
            button3.Name = "button3";
            button3.Size = new Size(180, 80);
            button3.TabIndex = 2;
            button3.Text = "מבצעים";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;

            // 
            // Manager Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18); // שחור מט עמוק
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Name = "Manager";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "פאנל מנהל - Premium Appliance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}