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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comPorList = new System.Windows.Forms.ComboBox();
            this.boundRate = new System.Windows.Forms.ComboBox();
            this.temperatureValueDth11 = new System.Windows.Forms.Label();
            this.humidityValueDth11 = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.humidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dth11 = new System.Windows.Forms.Label();
            this.dth22 = new System.Windows.Forms.Label();
            this.temperatureValueDth22 = new System.Windows.Forms.Label();
            this.humidityValueDth22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidity)).BeginInit();
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
            // temperatureValueDth11
            // 
            this.temperatureValueDth11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.temperatureValueDth11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperatureValueDth11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.temperatureValueDth11.Location = new System.Drawing.Point(12, 66);
            this.temperatureValueDth11.Name = "temperatureValueDth11";
            this.temperatureValueDth11.Size = new System.Drawing.Size(100, 50);
            this.temperatureValueDth11.TabIndex = 2;
            this.temperatureValueDth11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidityValueDth11
            // 
            this.humidityValueDth11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.humidityValueDth11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.humidityValueDth11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.humidityValueDth11.Location = new System.Drawing.Point(118, 66);
            this.humidityValueDth11.Name = "humidityValueDth11";
            this.humidityValueDth11.Size = new System.Drawing.Size(100, 50);
            this.humidityValueDth11.TabIndex = 3;
            this.humidityValueDth11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperature
            // 
            chartArea1.Name = "ChartArea1";
            this.temperature.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.temperature.Legends.Add(legend1);
            this.temperature.Location = new System.Drawing.Point(12, 282);
            this.temperature.Name = "temperature";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "temp";
            this.temperature.Series.Add(series1);
            this.temperature.Size = new System.Drawing.Size(1258, 256);
            this.temperature.TabIndex = 4;
            this.temperature.Text = "chart1";
            // 
            // humidity
            // 
            chartArea2.Name = "ChartArea1";
            this.humidity.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.humidity.Legends.Add(legend2);
            this.humidity.Location = new System.Drawing.Point(12, 544);
            this.humidity.Name = "humidity";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "humidity";
            this.humidity.Series.Add(series2);
            this.humidity.Size = new System.Drawing.Size(1258, 279);
            this.humidity.TabIndex = 5;
            this.humidity.Text = "humidity";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(625, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "1 min";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(756, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "5 min";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(887, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 49);
            this.button3.TabIndex = 8;
            this.button3.Text = "10 min";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(228, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Odstęp pomiędzy pomiarami";
            this.label1.UseMnemonic = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(494, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 49);
            this.button4.TabIndex = 10;
            this.button4.Text = "30 s";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GrayText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(363, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 49);
            this.button5.TabIndex = 11;
            this.button5.Text = "10 s";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GrayText;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(232, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 49);
            this.button6.TabIndex = 12;
            this.button6.Text = "5 s";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // dth11
            // 
            this.dth11.AutoSize = true;
            this.dth11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dth11.ForeColor = System.Drawing.Color.Lime;
            this.dth11.Location = new System.Drawing.Point(77, 36);
            this.dth11.Name = "dth11";
            this.dth11.Size = new System.Drawing.Size(69, 24);
            this.dth11.TabIndex = 13;
            this.dth11.Text = "DTH11";
            this.dth11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dth22
            // 
            this.dth22.AutoSize = true;
            this.dth22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dth22.ForeColor = System.Drawing.Color.Lime;
            this.dth22.Location = new System.Drawing.Point(77, 130);
            this.dth22.Name = "dth22";
            this.dth22.Size = new System.Drawing.Size(69, 24);
            this.dth22.TabIndex = 14;
            this.dth22.Text = "DTH22";
            this.dth22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperatureValueDth22
            // 
            this.temperatureValueDth22.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.temperatureValueDth22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperatureValueDth22.ForeColor = System.Drawing.SystemColors.Highlight;
            this.temperatureValueDth22.Location = new System.Drawing.Point(12, 181);
            this.temperatureValueDth22.Name = "temperatureValueDth22";
            this.temperatureValueDth22.Size = new System.Drawing.Size(100, 50);
            this.temperatureValueDth22.TabIndex = 15;
            this.temperatureValueDth22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidityValueDth22
            // 
            this.humidityValueDth22.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.humidityValueDth22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.humidityValueDth22.ForeColor = System.Drawing.SystemColors.Highlight;
            this.humidityValueDth22.Location = new System.Drawing.Point(118, 181);
            this.humidityValueDth22.Name = "humidityValueDth22";
            this.humidityValueDth22.Size = new System.Drawing.Size(100, 50);
            this.humidityValueDth22.TabIndex = 16;
            this.humidityValueDth22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 835);
            this.Controls.Add(this.humidityValueDth22);
            this.Controls.Add(this.temperatureValueDth22);
            this.Controls.Add(this.dth22);
            this.Controls.Add(this.dth11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.humidityValueDth11);
            this.Controls.Add(this.temperatureValueDth11);
            this.Controls.Add(this.boundRate);
            this.Controls.Add(this.comPorList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termometr Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comPorList;
        private System.Windows.Forms.ComboBox boundRate;
        private System.Windows.Forms.Label temperatureValueDth11;
        private System.Windows.Forms.Label humidityValueDth11;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart humidity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label dth11;
        private System.Windows.Forms.Label dth22;
        private System.Windows.Forms.Label temperatureValueDth22;
        private System.Windows.Forms.Label humidityValueDth22;
    }
}

