using System.Drawing;
using System.Windows.Forms;

namespace UI_
{
    partial class Login
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();

            // 
            // button1 (מנהל 🖥️)
            // 
            button1.BackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.BorderColor = Color.FromArgb(212, 175, 55); // מסגרת זהב שמפניה עשיר
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(212, 175, 55); // טקסט זהב תואם
            button1.Location = new Point(233, 60);
            button1.Name = "button1";
            button1.Size = new Size(334, 130);
            button1.TabIndex = 0;
            button1.Text = "מנהל 🖥️";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // 
            // button2 (קופאי 🛒)
            // 
            button2.BackColor = Color.FromArgb(28, 28, 28);
            button2.FlatAppearance.BorderColor = Color.FromArgb(205, 127, 50); // מסגרת נחושת יוקרתית לקופאי
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(245, 245, 220); // טקסט שמנת רך
            button2.Location = new Point(233, 230);
            button2.Name = "button2";
            button2.Size = new Size(334, 130);
            button2.TabIndex = 1;
            button2.Text = "קופאי 🛒";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;

            // 
            // Login Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18); // שחור מט עמוק המעניק עומק
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F);
            Name = "Login";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "כניסה למערכת - Premium Boutique Appliance";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}