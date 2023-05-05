namespace IMlab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonBreak = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.editStep = new System.Windows.Forms.NumericUpDown();
			this.editSize = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.editMass = new System.Windows.Forms.NumericUpDown();
			this.labelWeight = new System.Windows.Forms.Label();
			this.labelSpeed = new System.Windows.Forms.Label();
			this.labelAngle = new System.Windows.Forms.Label();
			this.labelHeight = new System.Windows.Forms.Label();
			this.editSpeed = new System.Windows.Forms.NumericUpDown();
			this.editHeight = new System.Windows.Forms.NumericUpDown();
			this.editAngle = new System.Windows.Forms.NumericUpDown();
			this.btnStart = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.editStep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.editSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.editMass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.editSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.editHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.editAngle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonBreak);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.editStep);
			this.panel1.Controls.Add(this.editSize);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.editMass);
			this.panel1.Controls.Add(this.labelWeight);
			this.panel1.Controls.Add(this.labelSpeed);
			this.panel1.Controls.Add(this.labelAngle);
			this.panel1.Controls.Add(this.labelHeight);
			this.panel1.Controls.Add(this.editSpeed);
			this.panel1.Controls.Add(this.editHeight);
			this.panel1.Controls.Add(this.editAngle);
			this.panel1.Controls.Add(this.btnStart);
			this.panel1.Location = new System.Drawing.Point(11, 11);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1224, 201);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// buttonBreak
			// 
			this.buttonBreak.BackColor = System.Drawing.Color.Cyan;
			this.buttonBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.buttonBreak.Location = new System.Drawing.Point(15, 91);
			this.buttonBreak.Margin = new System.Windows.Forms.Padding(2);
			this.buttonBreak.Name = "buttonBreak";
			this.buttonBreak.Size = new System.Drawing.Size(86, 46);
			this.buttonBreak.TabIndex = 13;
			this.buttonBreak.Text = "Clear";
			this.buttonBreak.UseVisualStyleBackColor = false;
			this.buttonBreak.Click += new System.EventHandler(this.buttonBreak_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.dataGridView1.Location = new System.Drawing.Point(588, 2);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 30;
			this.dataGridView1.RowTemplate.ErrorText = "ERROR";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.RowTemplate.ReadOnly = true;
			this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.Size = new System.Drawing.Size(512, 190);
			this.dataGridView1.TabIndex = 13;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Time Step";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 120;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Distance";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 120;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Max height";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 120;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Speed at the end point";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 120;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(343, 118);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 17);
			this.label2.TabIndex = 12;
			this.label2.Text = "Step";
			// 
			// editStep
			// 
			this.editStep.DecimalPlaces = 3;
			this.editStep.Location = new System.Drawing.Point(387, 118);
			this.editStep.Margin = new System.Windows.Forms.Padding(2);
			this.editStep.Name = "editStep";
			this.editStep.Size = new System.Drawing.Size(85, 20);
			this.editStep.TabIndex = 11;
			this.editStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			// 
			// editSize
			// 
			this.editSize.DecimalPlaces = 2;
			this.editSize.Location = new System.Drawing.Point(387, 70);
			this.editSize.Margin = new System.Windows.Forms.Padding(2);
			this.editSize.Name = "editSize";
			this.editSize.Size = new System.Drawing.Size(85, 20);
			this.editSize.TabIndex = 10;
			this.editSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(345, 71);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Size";
			// 
			// editMass
			// 
			this.editMass.DecimalPlaces = 2;
			this.editMass.Location = new System.Drawing.Point(387, 25);
			this.editMass.Margin = new System.Windows.Forms.Padding(2);
			this.editMass.Name = "editMass";
			this.editMass.Size = new System.Drawing.Size(85, 20);
			this.editMass.TabIndex = 8;
			this.editMass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelWeight
			// 
			this.labelWeight.AutoSize = true;
			this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelWeight.Location = new System.Drawing.Point(328, 26);
			this.labelWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelWeight.Name = "labelWeight";
			this.labelWeight.Size = new System.Drawing.Size(52, 17);
			this.labelWeight.TabIndex = 7;
			this.labelWeight.Text = "Weight";
			// 
			// labelSpeed
			// 
			this.labelSpeed.AutoSize = true;
			this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelSpeed.Location = new System.Drawing.Point(140, 24);
			this.labelSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelSpeed.Name = "labelSpeed";
			this.labelSpeed.Size = new System.Drawing.Size(49, 17);
			this.labelSpeed.TabIndex = 6;
			this.labelSpeed.Text = "Speed";
			// 
			// labelAngle
			// 
			this.labelAngle.AutoSize = true;
			this.labelAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelAngle.Location = new System.Drawing.Point(145, 67);
			this.labelAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelAngle.Name = "labelAngle";
			this.labelAngle.Size = new System.Drawing.Size(44, 17);
			this.labelAngle.TabIndex = 5;
			this.labelAngle.Text = "Angle";
			// 
			// labelHeight
			// 
			this.labelHeight.AutoSize = true;
			this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labelHeight.Location = new System.Drawing.Point(140, 117);
			this.labelHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelHeight.Name = "labelHeight";
			this.labelHeight.Size = new System.Drawing.Size(49, 17);
			this.labelHeight.TabIndex = 4;
			this.labelHeight.Text = "Height";
			// 
			// editSpeed
			// 
			this.editSpeed.Location = new System.Drawing.Point(198, 24);
			this.editSpeed.Margin = new System.Windows.Forms.Padding(2);
			this.editSpeed.Name = "editSpeed";
			this.editSpeed.Size = new System.Drawing.Size(85, 20);
			this.editSpeed.TabIndex = 3;
			this.editSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// editHeight
			// 
			this.editHeight.Location = new System.Drawing.Point(198, 115);
			this.editHeight.Margin = new System.Windows.Forms.Padding(2);
			this.editHeight.Name = "editHeight";
			this.editHeight.Size = new System.Drawing.Size(85, 20);
			this.editHeight.TabIndex = 2;
			// 
			// editAngle
			// 
			this.editAngle.Location = new System.Drawing.Point(198, 67);
			this.editAngle.Margin = new System.Windows.Forms.Padding(2);
			this.editAngle.Name = "editAngle";
			this.editAngle.Size = new System.Drawing.Size(85, 20);
			this.editAngle.TabIndex = 1;
			this.editAngle.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btnStart.Location = new System.Drawing.Point(15, 25);
			this.btnStart.Margin = new System.Windows.Forms.Padding(2);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(86, 46);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// chart1
			// 
			chartArea1.AxisX.Maximum = 25D;
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.AxisY.Maximum = 10D;
			chartArea1.AxisY.Minimum = 0D;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Location = new System.Drawing.Point(11, 216);
			this.chart1.Margin = new System.Windows.Forms.Padding(2);
			this.chart1.Name = "chart1";
			series1.BorderWidth = 3;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Name = "Trajectory";
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(1209, 407);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1246, 634);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.editStep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.editSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.editMass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.editSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.editHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.editAngle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.NumericUpDown editSpeed;
        private System.Windows.Forms.NumericUpDown editHeight;
        private System.Windows.Forms.NumericUpDown editAngle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown editMass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown editSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown editStep;
        private System.Windows.Forms.Button buttonBreak;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

