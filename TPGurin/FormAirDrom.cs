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
        /// <summary>
        /// Объект от класса многоуровневого порта
        /// </summary>
        MultiLevelAirdrom band;
        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;
        public FormAirDrom()
        {
            InitializeComponent();
            band = new MultiLevelAirdrom(countLevel, pictureBoxAirdrom.Width,
           pictureBoxAirdrom.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxlevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxlevels.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод отрисовки порта
        /// </summary>
        private void Draw()
        {
            if (listBoxlevels.SelectedIndex > -1)
            {
                //если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxAirdrom.Width,
               pictureBoxAirdrom.Height);
                Graphics gr = Graphics.FromImage(bmp);
                band[listBoxlevels.SelectedIndex].Draw(gr);
                pictureBoxAirdrom.Image = bmp;
            }
        }
        /// Обработка нажатия кнопки "Посадить самолет"
        private void buttonLocateAir_Click(object sender, EventArgs e)
        {
            if (listBoxlevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var air = new Air(100, 1000, dialog.Color);
                    int place = band[listBoxlevels.SelectedIndex] + air;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }
        /// Обработка нажатия кнопки "Посадить аэробус"
        private void buttonLocateAirbus_Click(object sender, EventArgs e)
        {
            if (listBoxlevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var air = new SuperAir(100, 1000, dialog.Color,
                       dialogDop.Color, true, 2);
                        int place = band[listBoxlevels.SelectedIndex] + air;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }
        /// Обработка нажатия кнопки "Забрать"
        private void buttonGetAir_Click(object sender, EventArgs e)
        {
            if (listBoxlevels.SelectedIndex > -1)
            {
                if (maskedTextBoxSpot.Text != "")
                {
                    var air = band[listBoxlevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBoxSpot.Text);
                    if (air != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                       pictureBoxTake.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        air.SetPosition(15, 55, pictureBoxTake.Width,
                       pictureBoxTake.Height);
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
        private void listBoxlevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}