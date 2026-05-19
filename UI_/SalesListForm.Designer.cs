using System.Drawing;
using System.Windows.Forms;

namespace UI_
{
    partial class SalesListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvSales;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvSales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();

            // הגדרות עיצוב פרימיום
            var premiumFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            var headerFont = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            var mainBgColor = Color.FromArgb(18, 18, 18);       // שחור פחם עמוק
            var panelBgColor = Color.FromArgb(30, 30, 30);     // אפור כהה מאוד
            var textLightColor = Color.FromArgb(224, 224, 224); // אופ-וייט עדין
            var goldAccent = Color.FromArgb(212, 175, 55);     // זהב שמפניה

            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.Location = new System.Drawing.Point(0, 0);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 35;
            this.dgvSales.Size = new System.Drawing.Size(600, 400);
            this.dgvSales.TabIndex = 0;

            // התאמת טבלת המכירות לקו העיצובי של החנות
            this.dgvSales.BackgroundColor = mainBgColor;
            this.dgvSales.BorderStyle = BorderStyle.None;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.GridColor = Color.FromArgb(45, 45, 45);
            this.dgvSales.ColumnHeadersDefaultCellStyle.BackColor = panelBgColor;
            this.dgvSales.ColumnHeadersDefaultCellStyle.ForeColor = goldAccent;
            this.dgvSales.ColumnHeadersDefaultCellStyle.Font = headerFont;
            this.dgvSales.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvSales.DefaultCellStyle.BackColor = mainBgColor;
            this.dgvSales.DefaultCellStyle.ForeColor = textLightColor;
            this.dgvSales.DefaultCellStyle.Font = premiumFont;
            this.dgvSales.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 50);
            this.dgvSales.DefaultCellStyle.SelectionForeColor = goldAccent;

            // 
            // SalesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dgvSales);
            this.Name = "SalesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Active Sales";
            this.BackColor = mainBgColor;
            this.ForeColor = textLightColor;
            this.Font = premiumFont;
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
        }
    }
}