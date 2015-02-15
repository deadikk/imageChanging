namespace image_changing
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceImg = new System.Windows.Forms.PictureBox();
            this.resultImg = new System.Windows.Forms.PictureBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.filter1 = new System.Windows.Forms.Button();
            this.filter2 = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.filter4 = new System.Windows.Forms.Button();
            this.filter3 = new System.Windows.Forms.Button();
            this.filterZero = new System.Windows.Forms.Button();
            this.filter5 = new System.Windows.Forms.Button();
            this.pixelSize = new System.Windows.Forms.NumericUpDown();
            this.power = new System.Windows.Forms.NumericUpDown();
            this.filter6 = new System.Windows.Forms.Button();
            this.hold_show = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.filter7 = new System.Windows.Forms.Button();
            this.graph1 = new System.Windows.Forms.PictureBox();
            this.graph2 = new System.Windows.Forms.PictureBox();
            this.BlurValue = new System.Windows.Forms.NumericUpDown();
            this.BlurBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlurValue)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceImg
            // 
            this.sourceImg.BackColor = System.Drawing.SystemColors.Control;
            this.sourceImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceImg.Location = new System.Drawing.Point(1, 56);
            this.sourceImg.Name = "sourceImg";
            this.sourceImg.Size = new System.Drawing.Size(444, 333);
            this.sourceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImg.TabIndex = 0;
            this.sourceImg.TabStop = false;
            // 
            // resultImg
            // 
            this.resultImg.BackColor = System.Drawing.SystemColors.Control;
            this.resultImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultImg.Location = new System.Drawing.Point(575, 56);
            this.resultImg.Name = "resultImg";
            this.resultImg.Size = new System.Drawing.Size(444, 333);
            this.resultImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultImg.TabIndex = 1;
            this.resultImg.TabStop = false;
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(379, 395);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(66, 27);
            this.openBtn.TabIndex = 2;
            this.openBtn.Text = "Open..";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // filter1
            // 
            this.filter1.BackColor = System.Drawing.SystemColors.Control;
            this.filter1.Location = new System.Drawing.Point(475, 99);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(79, 26);
            this.filter1.TabIndex = 3;
            this.filter1.Text = "Ч/Б";
            this.filter1.UseVisualStyleBackColor = false;
            this.filter1.Click += new System.EventHandler(this.filter1_Click);
            // 
            // filter2
            // 
            this.filter2.BackColor = System.Drawing.SystemColors.Control;
            this.filter2.Location = new System.Drawing.Point(475, 140);
            this.filter2.Name = "filter2";
            this.filter2.Size = new System.Drawing.Size(79, 26);
            this.filter2.TabIndex = 4;
            this.filter2.Text = "Негатив";
            this.filter2.UseVisualStyleBackColor = false;
            this.filter2.Click += new System.EventHandler(this.filter2_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(953, 395);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(66, 27);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save..";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(1036, 82);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1036, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Яркость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1036, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Контраст";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(1036, 158);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // filter4
            // 
            this.filter4.BackColor = System.Drawing.SystemColors.Control;
            this.filter4.Location = new System.Drawing.Point(475, 181);
            this.filter4.Name = "filter4";
            this.filter4.Size = new System.Drawing.Size(79, 26);
            this.filter4.TabIndex = 14;
            this.filter4.Text = "8 bit";
            this.filter4.UseVisualStyleBackColor = false;
            this.filter4.Click += new System.EventHandler(this.filter4_Click);
            // 
            // filter3
            // 
            this.filter3.BackColor = System.Drawing.SystemColors.Control;
            this.filter3.Location = new System.Drawing.Point(475, 223);
            this.filter3.Name = "filter3";
            this.filter3.Size = new System.Drawing.Size(79, 26);
            this.filter3.TabIndex = 15;
            this.filter3.Text = "4 bit";
            this.filter3.UseVisualStyleBackColor = false;
            this.filter3.Click += new System.EventHandler(this.filter3_Click);
            // 
            // filterZero
            // 
            this.filterZero.BackColor = System.Drawing.SystemColors.Control;
            this.filterZero.Location = new System.Drawing.Point(475, 56);
            this.filterZero.Name = "filterZero";
            this.filterZero.Size = new System.Drawing.Size(79, 26);
            this.filterZero.TabIndex = 16;
            this.filterZero.Text = "=";
            this.filterZero.UseVisualStyleBackColor = false;
            this.filterZero.Click += new System.EventHandler(this.button1_Click);
            // 
            // filter5
            // 
            this.filter5.BackColor = System.Drawing.SystemColors.Control;
            this.filter5.Location = new System.Drawing.Point(451, 294);
            this.filter5.Name = "filter5";
            this.filter5.Size = new System.Drawing.Size(118, 26);
            this.filter5.TabIndex = 17;
            this.filter5.Text = "Пикселизация";
            this.filter5.UseVisualStyleBackColor = false;
            this.filter5.Click += new System.EventHandler(this.filter5_Click);
            // 
            // pixelSize
            // 
            this.pixelSize.Location = new System.Drawing.Point(475, 268);
            this.pixelSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.pixelSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pixelSize.Name = "pixelSize";
            this.pixelSize.Size = new System.Drawing.Size(79, 20);
            this.pixelSize.TabIndex = 18;
            this.pixelSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(475, 337);
            this.power.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.power.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(79, 20);
            this.power.TabIndex = 20;
            this.power.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // filter6
            // 
            this.filter6.BackColor = System.Drawing.SystemColors.Control;
            this.filter6.Location = new System.Drawing.Point(451, 363);
            this.filter6.Name = "filter6";
            this.filter6.Size = new System.Drawing.Size(118, 26);
            this.filter6.TabIndex = 19;
            this.filter6.Text = "Автояркость";
            this.filter6.UseVisualStyleBackColor = false;
            this.filter6.Click += new System.EventHandler(this.filter6_Click);
            // 
            // hold_show
            // 
            this.hold_show.BackColor = System.Drawing.SystemColors.Control;
            this.hold_show.Location = new System.Drawing.Point(940, 24);
            this.hold_show.Name = "hold_show";
            this.hold_show.Size = new System.Drawing.Size(79, 26);
            this.hold_show.TabIndex = 21;
            this.hold_show.Text = "show orig";
            this.hold_show.UseVisualStyleBackColor = false;
            this.hold_show.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hold_show_MouseDown);
            this.hold_show.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hold_show_MouseUp);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(475, 402);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown3.TabIndex = 23;
            this.numericUpDown3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // filter7
            // 
            this.filter7.BackColor = System.Drawing.SystemColors.Control;
            this.filter7.Location = new System.Drawing.Point(451, 428);
            this.filter7.Name = "filter7";
            this.filter7.Size = new System.Drawing.Size(118, 26);
            this.filter7.TabIndex = 22;
            this.filter7.Text = "HDR";
            this.filter7.UseVisualStyleBackColor = false;
            this.filter7.Click += new System.EventHandler(this.filter7_Click);
            // 
            // graph1
            // 
            this.graph1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph1.InitialImage = global::image_changing.Properties.Resources.logo;
            this.graph1.Location = new System.Drawing.Point(1, 428);
            this.graph1.Name = "graph1";
            this.graph1.Size = new System.Drawing.Size(372, 193);
            this.graph1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.graph1.TabIndex = 24;
            this.graph1.TabStop = false;
            this.graph1.Click += new System.EventHandler(this.graph1_Click);
            // 
            // graph2
            // 
            this.graph2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph2.Location = new System.Drawing.Point(647, 428);
            this.graph2.Name = "graph2";
            this.graph2.Size = new System.Drawing.Size(372, 193);
            this.graph2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.graph2.TabIndex = 25;
            this.graph2.TabStop = false;
            // 
            // BlurValue
            // 
            this.BlurValue.Location = new System.Drawing.Point(475, 464);
            this.BlurValue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.BlurValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BlurValue.Name = "BlurValue";
            this.BlurValue.Size = new System.Drawing.Size(79, 20);
            this.BlurValue.TabIndex = 27;
            this.BlurValue.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // BlurBtn
            // 
            this.BlurBtn.BackColor = System.Drawing.SystemColors.Control;
            this.BlurBtn.Location = new System.Drawing.Point(451, 490);
            this.BlurBtn.Name = "BlurBtn";
            this.BlurBtn.Size = new System.Drawing.Size(118, 26);
            this.BlurBtn.TabIndex = 26;
            this.BlurBtn.Text = "Blur";
            this.BlurBtn.UseVisualStyleBackColor = false;
            this.BlurBtn.Click += new System.EventHandler(this.BlurBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1118, 627);
            this.Controls.Add(this.BlurValue);
            this.Controls.Add(this.BlurBtn);
            this.Controls.Add(this.graph2);
            this.Controls.Add(this.graph1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.filter7);
            this.Controls.Add(this.hold_show);
            this.Controls.Add(this.power);
            this.Controls.Add(this.filter6);
            this.Controls.Add(this.pixelSize);
            this.Controls.Add(this.filter5);
            this.Controls.Add(this.filterZero);
            this.Controls.Add(this.filter3);
            this.Controls.Add(this.filter4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.filter2);
            this.Controls.Add(this.filter1);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.resultImg);
            this.Controls.Add(this.sourceImg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sourceImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlurValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourceImg;
        private System.Windows.Forms.PictureBox resultImg;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button filter1;
        private System.Windows.Forms.Button filter2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button filter4;
        private System.Windows.Forms.Button filter3;
        private System.Windows.Forms.Button filterZero;
        private System.Windows.Forms.Button filter5;
        private System.Windows.Forms.NumericUpDown pixelSize;
        private System.Windows.Forms.NumericUpDown power;
        private System.Windows.Forms.Button filter6;
        private System.Windows.Forms.Button hold_show;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button filter7;
        private System.Windows.Forms.PictureBox graph1;
        private System.Windows.Forms.PictureBox graph2;
        private System.Windows.Forms.NumericUpDown BlurValue;
        private System.Windows.Forms.Button BlurBtn;
    }
}

