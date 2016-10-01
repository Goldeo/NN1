namespace AC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.pointsCount_tb = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.a_tb = new System.Windows.Forms.TextBox();
            this.b_tb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.neuronsCount_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bChart_tb = new System.Windows.Forms.TextBox();
            this.aChart_tb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.R2_tb = new System.Windows.Forms.TextBox();
            this.hiddenLayersCount_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Точек:";
            // 
            // pointsCount_tb
            // 
            this.pointsCount_tb.Location = new System.Drawing.Point(89, 234);
            this.pointsCount_tb.Name = "pointsCount_tb";
            this.pointsCount_tb.Size = new System.Drawing.Size(59, 20);
            this.pointsCount_tb.TabIndex = 2;
            this.pointsCount_tb.Text = "50";
            // 
            // chart
            // 
            chartArea6.AxisX.Title = "x";
            chartArea6.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea6.AxisY.Title = "f(x)";
            chartArea6.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea6);
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend6.Name = "Legend1";
            this.chart.Legends.Add(legend6);
            this.chart.Location = new System.Drawing.Point(374, 15);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.Green};
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.EmptyPointStyle.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            series12.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series12.Legend = "Legend1";
            series12.MarkerSize = 7;
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series12.Name = "Series2";
            this.chart.Series.Add(series11);
            this.chart.Series.Add(series12);
            this.chart.Size = new System.Drawing.Size(473, 304);
            this.chart.TabIndex = 3;
            this.chart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Обучить!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(705, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(142, 116);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Интервал обучения:";
            // 
            // a_tb
            // 
            this.a_tb.Location = new System.Drawing.Point(155, 75);
            this.a_tb.Name = "a_tb";
            this.a_tb.Size = new System.Drawing.Size(59, 20);
            this.a_tb.TabIndex = 7;
            this.a_tb.Text = "0";
            // 
            // b_tb
            // 
            this.b_tb.Location = new System.Drawing.Point(222, 75);
            this.b_tb.Name = "b_tb";
            this.b_tb.Size = new System.Drawing.Size(59, 20);
            this.b_tb.TabIndex = 8;
            this.b_tb.Text = "10";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Строить!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Нейронов в скрытом слое:";
            // 
            // neuronsCount_tb
            // 
            this.neuronsCount_tb.Location = new System.Drawing.Point(157, 45);
            this.neuronsCount_tb.Name = "neuronsCount_tb";
            this.neuronsCount_tb.Size = new System.Drawing.Size(59, 20);
            this.neuronsCount_tb.TabIndex = 11;
            this.neuronsCount_tb.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Обучаемых переменных:";
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(155, 108);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(59, 20);
            this.tb_x.TabIndex = 13;
            this.tb_x.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(713, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "R^2 = ";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 176);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(358, 23);
            this.progressBar.TabIndex = 15;
            // 
            // bChart_tb
            // 
            this.bChart_tb.Location = new System.Drawing.Point(156, 206);
            this.bChart_tb.Name = "bChart_tb";
            this.bChart_tb.Size = new System.Drawing.Size(59, 20);
            this.bChart_tb.TabIndex = 26;
            this.bChart_tb.Text = "10";
            // 
            // aChart_tb
            // 
            this.aChart_tb.Location = new System.Drawing.Point(89, 206);
            this.aChart_tb.Name = "aChart_tb";
            this.aChart_tb.Size = new System.Drawing.Size(59, 20);
            this.aChart_tb.TabIndex = 25;
            this.aChart_tb.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Интервал";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Шум:";
            this.label6.Visible = false;
            // 
            // R2_tb
            // 
            this.R2_tb.Enabled = false;
            this.R2_tb.Location = new System.Drawing.Point(758, 287);
            this.R2_tb.Name = "R2_tb";
            this.R2_tb.Size = new System.Drawing.Size(69, 20);
            this.R2_tb.TabIndex = 28;
            // 
            // hiddenLayersCount_tb
            // 
            this.hiddenLayersCount_tb.Location = new System.Drawing.Point(155, 12);
            this.hiddenLayersCount_tb.Name = "hiddenLayersCount_tb";
            this.hiddenLayersCount_tb.Size = new System.Drawing.Size(59, 20);
            this.hiddenLayersCount_tb.TabIndex = 30;
            this.hiddenLayersCount_tb.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Скрытых слоев:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(21, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 100);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функция";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "x * x";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "sin(x)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "sqrt(x) + sin(2 * x * x)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hiddenLayersCount_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.R2_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bChart_tb);
            this.Controls.Add(this.aChart_tb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.neuronsCount_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.b_tb);
            this.Controls.Add(this.a_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.pointsCount_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "ИНС";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pointsCount_tb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox a_tb;
        private System.Windows.Forms.TextBox b_tb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox neuronsCount_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox bChart_tb;
        private System.Windows.Forms.TextBox aChart_tb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox R2_tb;
        private System.Windows.Forms.TextBox hiddenLayersCount_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}