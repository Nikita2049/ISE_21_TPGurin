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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.buttonGetAir = new System.Windows.Forms.Button();
            this.maskedTextBoxSpot = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxlevels = new System.Windows.Forms.ListBox();
            this.buttonSetAir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Location = new System.Drawing.Point(1, 2);
            this.pictureBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(678, 424);
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBoxTake);
            this.groupBox1.Controls.Add(this.buttonGetAir);
            this.groupBox1.Controls.Add(this.maskedTextBoxSpot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(723, 193);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(171, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 37);
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
            this.pictureBoxTake.Size = new System.Drawing.Size(171, 117);
            this.pictureBoxTake.TabIndex = 3;
            this.pictureBoxTake.TabStop = false;
            // 
            // buttonGetAir
            // 
            this.buttonGetAir.Location = new System.Drawing.Point(36, 55);
            this.buttonGetAir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetAir.Name = "buttonGetAir";
            this.buttonGetAir.Size = new System.Drawing.Size(60, 27);
            this.buttonGetAir.TabIndex = 2;
            this.buttonGetAir.Text = "Забрать";
            this.buttonGetAir.UseVisualStyleBackColor = true;
            this.buttonGetAir.Click += new System.EventHandler(this.buttonGetAir_Click);
            // 
            // maskedTextBoxSpot
            // 
            this.maskedTextBoxSpot.Location = new System.Drawing.Point(112, 34);
            this.maskedTextBoxSpot.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxSpot.Name = "maskedTextBoxSpot";
            this.maskedTextBoxSpot.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBoxSpot.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // listBoxlevels
            // 
            this.listBoxlevels.FormattingEnabled = true;
            this.listBoxlevels.Location = new System.Drawing.Point(788, 10);
            this.listBoxlevels.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxlevels.Name = "listBoxlevels";
            this.listBoxlevels.Size = new System.Drawing.Size(91, 69);
            this.listBoxlevels.TabIndex = 4;
            this.listBoxlevels.SelectedIndexChanged += new System.EventHandler(this.listBoxlevels_SelectedIndexChanged);
            // 
            // buttonSetAir
            // 
            this.buttonSetAir.Location = new System.Drawing.Point(772, 134);
            this.buttonSetAir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetAir.Name = "buttonSetAir";
            this.buttonSetAir.Size = new System.Drawing.Size(106, 31);
            this.buttonSetAir.TabIndex = 5;
            this.buttonSetAir.Text = "Заказать самолет";
            this.buttonSetAir.UseVisualStyleBackColor = true;
            this.buttonSetAir.Click += new System.EventHandler(this.buttonSetAir_Click);
            // 
            // FormAirdrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 491);
            this.Controls.Add(this.buttonSetAir);
            this.Controls.Add(this.listBoxlevels);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxPort);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAirdrom";
            this.Text = "FormAirdrom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button buttonGetAir;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSpot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxlevels;
        private System.Windows.Forms.Button buttonSetAir;
    }
}