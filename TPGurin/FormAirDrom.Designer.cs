namespace TPGurin
{
    partial class FormAirDrom
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
            this.pictureBoxAirdrom = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.buttonGetAir = new System.Windows.Forms.Button();
            this.maskedTextBoxSpot = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonLocateAir = new System.Windows.Forms.Button();
            this.buttonLocateAirbus = new System.Windows.Forms.Button();
            this.listBoxlevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirdrom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAirdrom
            // 
            this.pictureBoxAirdrom.Location = new System.Drawing.Point(1, 2);
            this.pictureBoxAirdrom.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAirdrom.Name = "pictureBoxAirdrom";
            this.pictureBoxAirdrom.Size = new System.Drawing.Size(678, 424);
            this.pictureBoxAirdrom.TabIndex = 0;
            this.pictureBoxAirdrom.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBoxTake);
            this.groupBox1.Controls.Add(this.buttonGetAir);
            this.groupBox1.Controls.Add(this.maskedTextBoxSpot);
            this.groupBox1.Controls.Add(this.labelPlace);
            this.groupBox1.Location = new System.Drawing.Point(683, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(211, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Забрать самолет с";
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(4, 87);
            this.pictureBoxTake.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(203, 142);
            this.pictureBoxTake.TabIndex = 3;
            this.pictureBoxTake.TabStop = false;
            // 
            // buttonGetAir
            // 
            this.buttonGetAir.Location = new System.Drawing.Point(68, 58);
            this.buttonGetAir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetAir.Name = "buttonGetAir";
            this.buttonGetAir.Size = new System.Drawing.Size(68, 27);
            this.buttonGetAir.TabIndex = 2;
            this.buttonGetAir.Text = "Забрать";
            this.buttonGetAir.UseVisualStyleBackColor = true;
            this.buttonGetAir.Click += new System.EventHandler(this.buttonGetAir_Click);
            // 
            // maskedTextBoxSpot
            // 
            this.maskedTextBoxSpot.Location = new System.Drawing.Point(98, 34);
            this.maskedTextBoxSpot.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxSpot.Name = "maskedTextBoxSpot";
            this.maskedTextBoxSpot.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBoxSpot.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(52, 37);
            this.labelPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // buttonLocateAir
            // 
            this.buttonLocateAir.Location = new System.Drawing.Point(742, 84);
            this.buttonLocateAir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLocateAir.Name = "buttonLocateAir";
            this.buttonLocateAir.Size = new System.Drawing.Size(130, 31);
            this.buttonLocateAir.TabIndex = 2;
            this.buttonLocateAir.Text = "Посадить самолет";
            this.buttonLocateAir.UseVisualStyleBackColor = true;
            this.buttonLocateAir.Click += new System.EventHandler(this.buttonLocateAir_Click);
            // 
            // buttonLocateAirbus
            // 
            this.buttonLocateAirbus.Location = new System.Drawing.Point(742, 129);
            this.buttonLocateAirbus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLocateAirbus.Name = "buttonLocateAirbus";
            this.buttonLocateAirbus.Size = new System.Drawing.Size(130, 32);
            this.buttonLocateAirbus.TabIndex = 3;
            this.buttonLocateAirbus.Text = "Посадить аэробус";
            this.buttonLocateAirbus.UseVisualStyleBackColor = true;
            this.buttonLocateAirbus.Click += new System.EventHandler(this.buttonLocateAirbus_Click);
            // 
            // listBoxlevels
            // 
            this.listBoxlevels.FormattingEnabled = true;
            this.listBoxlevels.Location = new System.Drawing.Point(763, 11);
            this.listBoxlevels.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxlevels.Name = "listBoxlevels";
            this.listBoxlevels.Size = new System.Drawing.Size(91, 69);
            this.listBoxlevels.TabIndex = 4;
            this.listBoxlevels.SelectedIndexChanged += new System.EventHandler(this.listBoxlevels_SelectedIndexChanged);
            // 
            // FormAirDrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 491);
            this.Controls.Add(this.listBoxlevels);
            this.Controls.Add(this.buttonLocateAirbus);
            this.Controls.Add(this.buttonLocateAir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxAirdrom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAirDrom";
            this.Text = "FormPort";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirdrom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAirdrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button buttonGetAir;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSpot;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonLocateAir;
        private System.Windows.Forms.Button buttonLocateAirbus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxlevels;
    }
}