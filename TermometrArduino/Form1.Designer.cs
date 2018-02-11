namespace TermometrArduino
{
    partial class Form1
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
            this.comPorList = new System.Windows.Forms.ComboBox();
            this.boundRate = new System.Windows.Forms.ComboBox();
            this.temp = new System.Windows.Forms.Label();
            this.humadity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comPorList
            // 
            this.comPorList.FormattingEnabled = true;
            this.comPorList.Location = new System.Drawing.Point(12, 12);
            this.comPorList.Name = "comPorList";
            this.comPorList.Size = new System.Drawing.Size(100, 21);
            this.comPorList.TabIndex = 0;
            this.comPorList.SelectedIndexChanged += new System.EventHandler(this.comPorList_SelectedIndexChanged);
            // 
            // boundRate
            // 
            this.boundRate.FormattingEnabled = true;
            this.boundRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.boundRate.Location = new System.Drawing.Point(118, 12);
            this.boundRate.Name = "boundRate";
            this.boundRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boundRate.Size = new System.Drawing.Size(100, 21);
            this.boundRate.TabIndex = 1;
            this.boundRate.SelectedIndexChanged += new System.EventHandler(this.boundRate_SelectedIndexChanged);
            // 
            // temp
            // 
            this.temp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.temp.Location = new System.Drawing.Point(12, 36);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(100, 50);
            this.temp.TabIndex = 2;
            this.temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humadity
            // 
            this.humadity.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.humadity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.humadity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.humadity.Location = new System.Drawing.Point(118, 36);
            this.humadity.Name = "humadity";
            this.humadity.Size = new System.Drawing.Size(100, 50);
            this.humadity.TabIndex = 3;
            this.humadity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 101);
            this.Controls.Add(this.humadity);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.boundRate);
            this.Controls.Add(this.comPorList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termometr Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comPorList;
        private System.Windows.Forms.ComboBox boundRate;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label humadity;
    }
}

