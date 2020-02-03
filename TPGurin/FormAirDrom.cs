using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPGurin
{
    public partial class FormAirDrom : Form
    {
        Port<IAir> parking;
        public FormAirDrom()
        {
            InitializeComponent();
            parking = new Port<IAir>(20, pictureBoxPort.Width, pictureBoxPort.Height);
            Draw();
        }


        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxPort.Image = bmp;
        }

        private void buttonCreateAir_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var air = new Air(100, 1000, dialog.Color);
                int place = parking + air;
                Draw();
            }

        }

        private void buttonCreateSuperAir_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var air = new SuperAir(100, 1000, dialog.Color, dialogDop.Color, true, 2);
                    int place = parking + air;
                    Draw();
                }
            }
        }

        private void buttonTakeAir_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxAirdrom.Text != "")
            {
                var air = parking - Convert.ToInt32(maskedTextBoxAirdrom.Text);
                if (air != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    air.SetPosition(15, 55, pictureBoxTake.Width, pictureBoxTake.Height);
                    air.DrawAir(gr);
                    pictureBoxTake.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                   pictureBoxTake.Height);
                    pictureBoxTake.Image = bmp;
                }
                Draw();
            }
        }
    }
}