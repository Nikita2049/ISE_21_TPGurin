namespace TPGurin
{
    partial class FormAirConfig
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
            this.pictureBoxAir = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAirbus = new System.Windows.Forms.Label();
            this.labelAir = new System.Windows.Forms.Label();
            this.panelAir = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLocate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAir)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelAir.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAir
            // 
            this.pictureBoxAir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAir.Location = new System.Drawing.Point(2, 15);
            this.pictureBoxAir.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAir.Name = "pictureBoxAir";
            this.pictureBoxAir.Size = new System.Drawing.Size(181, 91);
            this.pictureBoxAir.TabIndex = 0;
            this.pictureBoxAir.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAirbus);
            this.groupBox1.Controls.Add(this.labelAir);
            this.groupBox1.Location = new System.Drawing.Point(29, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(104, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип самолета";
            // 
            // labelAirbus
            // 
            this.labelAirbus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAirbus.Location = new System.Drawing.Point(17, 50);
            this.labelAirbus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAirbus.Name = "labelAirbus";
            this.labelAirbus.Size = new System.Drawing.Size(58, 19);
            this.labelAirbus.TabIndex = 1;
            this.labelAirbus.Text = "Аэробус";
            this.labelAirbus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAirbus_MouseDown);
            // 
            // labelAir
            // 
            this.labelAir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAir.Location = new System.Drawing.Point(17, 23);
            this.labelAir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAir.Name = "labelAir";
            this.labelAir.Size = new System.Drawing.Size(58, 19);
            this.labelAir.TabIndex = 0;
            this.labelAir.Text = "Самолет";
            this.labelAir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAir_MouseDown);
            // 
            // panelAir
            // 
            this.panelAir.AllowDrop = true;
            this.panelAir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAir.Controls.Add(this.labelDopColor);
            this.panelAir.Controls.Add(this.labelBaseColor);
            this.panelAir.Controls.Add(this.pictureBoxAir);
            this.panelAir.Location = new System.Drawing.Point(212, 34);
            this.panelAir.Margin = new System.Windows.Forms.Padding(2);
            this.panelAir.Name = "panelAir";
            this.panelAir.Size = new System.Drawing.Size(186, 216);
            this.panelAir.TabIndex = 2;
            this.panelAir.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAir_DragDrop);
            this.panelAir.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAir_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(46, 166);
            this.labelDopColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(85, 40);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(46, 116);
            this.labelBaseColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(83, 36);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelGold);
            this.groupBox2.Controls.Add(this.panelGray);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(422, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(120, 207);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Gold;
            this.panelGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGold.Location = new System.Drawing.Point(62, 126);
            this.panelGold.Margin = new System.Windows.Forms.Padding(2);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(28, 31);
            this.panelGold.TabIndex = 2;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(14, 126);
            this.panelGray.Margin = new System.Windows.Forms.Padding(2);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(28, 31);
            this.panelGray.TabIndex = 2;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(62, 90);
            this.panelYellow.Margin = new System.Windows.Forms.Padding(2);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(28, 31);
            this.panelYellow.TabIndex = 2;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(14, 90);
            this.panelRed.Margin = new System.Windows.Forms.Padding(2);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(28, 31);
            this.panelRed.TabIndex = 2;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(62, 54);
            this.panelBlue.Margin = new System.Windows.Forms.Padding(2);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(28, 31);
            this.panelBlue.TabIndex = 2;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(14, 54);
            this.panelGreen.Margin = new System.Windows.Forms.Padding(2);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(28, 31);
            this.panelGreen.TabIndex = 2;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(62, 19);
            this.panelWhite.Margin = new System.Windows.Forms.Padding(2);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(28, 31);
            this.panelWhite.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(14, 18);
            this.panelBlack.Margin = new System.Windows.Forms.Padding(2);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(28, 32);
            this.panelBlack.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(37, 201);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(67, 26);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonLocate
            // 
            this.buttonLocate.Location = new System.Drawing.Point(37, 162);
            this.buttonLocate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLocate.Name = "buttonLocate";
            this.buttonLocate.Size = new System.Drawing.Size(67, 28);
            this.buttonLocate.TabIndex = 5;
            this.buttonLocate.Text = "Добавить";
            this.buttonLocate.UseVisualStyleBackColor = true;
            this.buttonLocate.Click += new System.EventHandler(this.buttonLocate_Click);
            // 
            // FormAirConfig
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonLocate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelAir);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAirConfig";
            this.Text = "Выбор Самолета";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelAir.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAir;
        private System.Windows.Forms.Label labelAirbus;
        private System.Windows.Forms.Panel panelAir;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLocate;
        private System.Windows.Forms.Label labelDopColor;
    }
}