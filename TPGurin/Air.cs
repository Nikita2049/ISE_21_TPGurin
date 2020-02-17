using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGurin
{
    public class Air : Vehicle
    {
        /// Ширина отрисовки самолета
        /// </summary>
        protected const int airWidth = 90;
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        protected const int airHeight = 1;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public Air(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Air(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            int k = 30;
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - airWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - 10 - step > 0)

                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - k - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - airHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка самолета
        /// </summary>
        /// <param name="g"></param>
        public override void DrawAir(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush white = new SolidBrush(Color.White);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush main = new SolidBrush(MainColor);
            Brush lblue = new SolidBrush(Color.LightBlue);
            Brush dred = new SolidBrush(Color.DarkRed);
            Brush gray = new SolidBrush(Color.Gray);

            // Корпус
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 10, 110, 25);
            g.DrawEllipse(pen, _startPosX + 108, _startPosY - 10, 25, 25);
            g.DrawEllipse(pen, _startPosX + 100, _startPosY + 5, 45, 10);
            g.DrawEllipse(pen, _startPosX - 12, _startPosY - 10, 45, 25);
            g.DrawRectangle(pen, _startPosX + 3, _startPosY - 30, 25, 30);
            g.DrawEllipse(pen, _startPosX + 14, _startPosY - 30, 25, 40);
            g.DrawEllipse(pen, _startPosX - 5, _startPosY + 3, 20, 5);
            g.FillRectangle(white, _startPosX + 10, _startPosY - 10, 110, 25);
            g.FillEllipse(white, _startPosX + 108, _startPosY - 10, 25, 25);
            g.FillEllipse(white, _startPosX + 100, _startPosY + 5, 45, 10);
            g.FillEllipse(main, _startPosX - 12, _startPosY - 10, 45, 25);
            g.FillRectangle(main, _startPosX + 3, _startPosY - 30, 25, 30);
            g.FillEllipse(main, _startPosX + 14, _startPosY - 30, 25, 40);
            g.FillEllipse(main, _startPosX - 5, _startPosY + 3, 20, 5);

            // Крылья
            g.FillRectangle(main, _startPosX + 50, _startPosY + 8, 40, 2);
            g.DrawRectangle(pen, _startPosX + 50, _startPosY + 8, 40, 2);
            g.FillRectangle(main, _startPosX + 45, _startPosY + 5, 10, 7);
            g.DrawRectangle(pen, _startPosX + 45, _startPosY + 5, 10, 7);

            // Дверь
            g.FillRectangle(main, _startPosX + 105, _startPosY - 2, 8, 13);
            g.DrawRectangle(pen, _startPosX + 105, _startPosY - 2, 8, 13);

            // Передние стекла
            g.FillRectangle(lblue, _startPosX + 125, _startPosY - 4, 5, 5);
            g.DrawRectangle(pen, _startPosX + 125, _startPosY - 4, 5, 5);
            g.FillRectangle(lblue, _startPosX + 118, _startPosY - 4, 5, 5);
            g.DrawRectangle(pen, _startPosX + 118, _startPosY - 4, 5, 5);

            // Турбина
            g.FillRectangle(dred, _startPosX + 65, _startPosY + 10, 16, 6);
            g.DrawRectangle(pen, _startPosX + 65, _startPosY + 10, 16, 6);
            g.FillRectangle(gray, _startPosX + 60, _startPosY + 11, 5, 4);
            g.DrawRectangle(pen, _startPosX + 60, _startPosY + 11, 5, 4);
            g.FillRectangle(gray, _startPosX + 80, _startPosY + 11, 5, 4);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 11, 5, 4);

            // Шасси
            g.FillRectangle(white, _startPosX + 105, _startPosY + 15, 8, 4);
            g.DrawRectangle(pen, _startPosX + 105, _startPosY + 15, 8, 4);
            g.FillRectangle(white, _startPosX + 107, _startPosY + 19, 3, 4);
            g.DrawRectangle(pen, _startPosX + 107, _startPosY + 19, 3, 4);
            g.FillRectangle(white, _startPosX + 20, _startPosY + 15, 8, 4);
            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 15, 8, 4);
            g.FillRectangle(white, _startPosX + 22, _startPosY + 19, 3, 4);
            g.DrawRectangle(pen, _startPosX + 22, _startPosY + 19, 3, 4);
            g.FillEllipse(brBlack, _startPosX + 105, _startPosY + 22, 7, 7);
            g.FillEllipse(brBlack, _startPosX + 18, _startPosY + 22, 7, 7);
            g.FillEllipse(brBlack, _startPosX + 23, _startPosY + 22, 7, 7);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}