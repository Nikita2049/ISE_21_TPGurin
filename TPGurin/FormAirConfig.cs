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
    public partial class FormAirConfig : Form
    {
        IAir air = null;
        private event airDelegate eventAddAir;
        public FormAirConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawAir()
        {
            if (air != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAir.Width, pictureBoxAir.Height);
                Graphics gr = Graphics.FromImage(bmp);
                air.SetPosition(15, 45, pictureBoxAir.Width, pictureBoxAir.Height);
                air.DrawAir(gr);
                pictureBoxAir.Image = bmp;
            }
        }

        public void AddEvent(airDelegate ev)
        {
            if (eventAddAir == null)
            {
                eventAddAir = new airDelegate(ev);
            }
            else
            {
                eventAddAir += ev;
            }
        }


        private void labelAir_MouseDown(object sender, MouseEventArgs e)
        {
            labelAir.DoDragDrop(labelAir.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelAirbus_MouseDown(object sender, MouseEventArgs e)
        {
            labelAirbus.DoDragDrop(labelAirbus.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void panelAir_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelAir_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Самолет":
                    air = new Air(100, 500, Color.White);
                    break;
                case "Аэробус":
                    air = new SuperAir(100, 500, Color.White, Color.Black, true, 3);
                    break;
            }
            DrawAir();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);

        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (air != null)
            {
                air.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawAir();
            }

        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (air != null)
            {
                if (air is SuperAir)
                {
                    (air as SuperAir).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawAir();

                }
            }
        }

        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void buttonLocate_Click(object sender, EventArgs e)
        {
            eventAddAir?.Invoke(air);
            Close();
        }
    }
}