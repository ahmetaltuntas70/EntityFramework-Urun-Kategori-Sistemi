
namespace EntityUrun
{
    partial class FrmAnaForm
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
            this.BtnKI = new System.Windows.Forms.Button();
            this.BtnUI = new System.Windows.Forms.Button();
            this.BtnI = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKI
            // 
            this.BtnKI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnKI.BackColor = System.Drawing.Color.Gold;
            this.BtnKI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKI.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKI.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnKI.Location = new System.Drawing.Point(7, 48);
            this.BtnKI.Name = "BtnKI";
            this.BtnKI.Size = new System.Drawing.Size(179, 135);
            this.BtnKI.TabIndex = 0;
            this.BtnKI.Text = "KATEGORİ İŞLEMLERİ";
            this.BtnKI.UseVisualStyleBackColor = false;
            this.BtnKI.Click += new System.EventHandler(this.BtnKI_Click);
            // 
            // BtnUI
            // 
            this.BtnUI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUI.BackColor = System.Drawing.Color.Gold;
            this.BtnUI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUI.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUI.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnUI.Location = new System.Drawing.Point(195, 48);
            this.BtnUI.Name = "BtnUI";
            this.BtnUI.Size = new System.Drawing.Size(179, 135);
            this.BtnUI.TabIndex = 0;
            this.BtnUI.Text = "ÜRÜN İŞLEMLERİ";
            this.BtnUI.UseVisualStyleBackColor = false;
            this.BtnUI.Click += new System.EventHandler(this.BtnUI_Click);
            // 
            // BtnI
            // 
            this.BtnI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnI.BackColor = System.Drawing.Color.Gold;
            this.BtnI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnI.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnI.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnI.Location = new System.Drawing.Point(383, 48);
            this.BtnI.Name = "BtnI";
            this.BtnI.Size = new System.Drawing.Size(179, 135);
            this.BtnI.TabIndex = 0;
            this.BtnI.Text = "İSTATİSTİKLER";
            this.BtnI.UseVisualStyleBackColor = false;
            this.BtnI.Click += new System.EventHandler(this.BtnI_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Gold;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnCikis.Location = new System.Drawing.Point(487, 4);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(78, 32);
            this.BtnCikis.TabIndex = 16;
            this.BtnCikis.Text = "ÇIKIŞ";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(571, 197);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnI);
            this.Controls.Add(this.BtnUI);
            this.Controls.Add(this.BtnKI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKI;
        private System.Windows.Forms.Button BtnUI;
        private System.Windows.Forms.Button BtnI;
        private System.Windows.Forms.Button BtnCikis;
    }
}