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
            this.pictureBoxPort = new System.Windows.Forms.PictureBox();
            this.groupBoxAirdrom = new System.Windows.Forms.GroupBox();
            this.labelTake = new System.Windows.Forms.Label();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.buttonTakePort = new System.Windows.Forms.Button();
            this.maskedTextBoxAirdrom = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonCreateAir = new System.Windows.Forms.Button();
            this.buttonCreateSuperAir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBoxAirdrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Location = new System.Drawing.Point(1, 2);
            this.pictureBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(575, 459);
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            // 
            // groupBoxAirdrom
            // 
            this.groupBoxAirdrom.Controls.Add(this.labelTake);
            this.groupBoxAirdrom.Controls.Add(this.pictureBoxTake);
            this.groupBoxAirdrom.Controls.Add(this.buttonTakePort);
            this.groupBoxAirdrom.Controls.Add(this.maskedTextBoxAirdrom);
            this.groupBoxAirdrom.Controls.Add(this.labelPlace);
            this.groupBoxAirdrom.Location = new System.Drawing.Point(580, 120);
            this.groupBoxAirdrom.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAirdrom.Name = "groupBoxAirdrom";
            this.groupBoxAirdrom.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAirdrom.Size = new System.Drawing.Size(171, 226);
            this.groupBoxAirdrom.TabIndex = 1;
            this.groupBoxAirdrom.TabStop = false;
            // 
            // labelTake
            // 
            this.labelTake.AutoSize = true;
            this.labelTake.Location = new System.Drawing.Point(4, 15);
            this.labelTake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTake.Name = "labelTake";
            this.labelTake.Size = new System.Drawing.Size(104, 13);
            this.labelTake.TabIndex = 4;
            this.labelTake.Text = "Забрать самолет с";
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(4, 109);
            this.pictureBoxTake.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(220, 141);
            this.pictureBoxTake.TabIndex = 3;
            this.pictureBoxTake.TabStop = false;
            // 
            // buttonTakeAirdrom
            // 
            this.buttonTakePort.Location = new System.Drawing.Point(17, 63);
            this.buttonTakePort.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakePort.Name = "buttonTakePort";
            this.buttonTakePort.Size = new System.Drawing.Size(130, 27);
            this.buttonTakePort.TabIndex = 2;
            this.buttonTakePort.Text = "Забрать";
            this.buttonTakePort.UseVisualStyleBackColor = true;
            this.buttonTakePort.Click += new System.EventHandler(this.buttonTakeAir_Click);
            // 
            // maskedTextBoxAirdrom
            // 
            this.maskedTextBoxAirdrom.Location = new System.Drawing.Point(53, 30);
            this.maskedTextBoxAirdrom.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxAirdrom.Name = "maskedTextBoxAirdrom";
            this.maskedTextBoxAirdrom.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBoxAirdrom.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(7, 33);
            this.labelPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // buttonCreateAir
            // 
            this.buttonCreateAir.Location = new System.Drawing.Point(597, 18);
            this.buttonCreateAir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateAir.Name = "buttonCreateAir";
            this.buttonCreateAir.Size = new System.Drawing.Size(130, 31);
            this.buttonCreateAir.TabIndex = 2;
            this.buttonCreateAir.Text = "Посадть Самолет";
            this.buttonCreateAir.UseVisualStyleBackColor = true;
            this.buttonCreateAir.Click += new System.EventHandler(this.buttonCreateAir_Click);
            // 
            // buttonCreateSuperAir
            // 
            this.buttonCreateSuperAir.Location = new System.Drawing.Point(597, 66);
            this.buttonCreateSuperAir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateSuperAir.Name = "buttonCreateSuperAir";
            this.buttonCreateSuperAir.Size = new System.Drawing.Size(130, 32);
            this.buttonCreateSuperAir.TabIndex = 3;
            this.buttonCreateSuperAir.Text = "Посадить Аэробус";
            this.buttonCreateSuperAir.UseVisualStyleBackColor = true;
            this.buttonCreateSuperAir.Click += new System.EventHandler(this.buttonCreateSuperAir_Click);
            // 
            // FormAirDrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonCreateSuperAir);
            this.Controls.Add(this.buttonCreateAir);
            this.Controls.Add(this.groupBoxAirdrom);
            this.Controls.Add(this.pictureBoxPort);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAirDrom";
            this.Text = "FormPort";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBoxAirdrom.ResumeLayout(false);
            this.groupBoxAirdrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.GroupBox groupBoxAirdrom;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button buttonTakePort;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAirdrom;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonCreateAir;
        private System.Windows.Forms.Button buttonCreateSuperAir;
        private System.Windows.Forms.Label labelTake;
    }
}