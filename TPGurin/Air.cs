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
        protected const int airWidth = 150;
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        protected const int airHeight = 10;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public Air(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
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
            Brush bottom = new SolidBrush(MainColor);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush main = new SolidBrush(MainColor);
            Brush lblue = new SolidBrush(Color.LightBlue);
            Brush dred = new SolidBrush(Color.DarkRed);
            Brush gray = new SolidBrush(Color.Gray);

            // Корпус
            g.FillRectangle(white, _startPosX + 10, _startPosY - 1, 250, 62);
            g.FillEllipse(white, _startPosX + 230, _startPosY - 1, 70, 62);
            g.FillEllipse(white, _startPosX + 220, _startPosY + 22, 100, 38);
            g.FillEllipse(main, _startPosX - 35, _startPosY - 1, 120, 62);
            g.FillRectangle(main, _startPosX + 5, _startPosY - 55, 40, 65);
            g.FillEllipse(main, _startPosX - 35, _startPosY - 1, 120, 62);
            g.FillEllipse(main, _startPosX + 15, _startPosY - 55, 50, 100);
            g.FillEllipse(main, _startPosX - 25, _startPosY + 20, 70, 10);

            // Крылья
            g.FillRectangle(white, _startPosX + 100, _startPosY + 50, 100, 7);
            g.DrawRectangle(pen, _startPosX + 100, _startPosY + 50, 100, 7);
            g.FillRectangle(white, _startPosX + 80, _startPosY + 35, 25, 20);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 35, 25, 20);

            // Дверь
            g.FillRectangle(white, _startPosX + 235, _startPosY + 15, 15, 25);
            g.DrawRectangle(pen, _startPosX + 235, _startPosY + 15, 15, 25);

            // Передние стекла
            g.FillRectangle(lblue, _startPosX + 280, _startPosY + 10, 10, 10);
            g.DrawRectangle(pen, _startPosX + 280, _startPosY + 10, 10, 10);
            g.FillRectangle(lblue, _startPosX + 265, _startPosY + 10, 10, 10);
            g.DrawRectangle(pen, _startPosX + 265, _startPosY + 10, 10, 10);

            // Турбина
            g.FillRectangle(dred, _startPosX + 125, _startPosY + 50, 40, 25);
            g.DrawRectangle(pen, _startPosX + 125, _startPosY + 50, 40, 25);
            g.FillRectangle(gray, _startPosX + 115, _startPosY + 53, 10, 20);
            g.DrawRectangle(pen, _startPosX + 165, _startPosY + 53, 5, 20);
            g.FillRectangle(gray, _startPosX + 115, _startPosY + 53, 10, 20);
            g.DrawRectangle(pen, _startPosX + 165, _startPosY + 53, 5, 20);

            // Шасси
            g.FillRectangle(white, _startPosX + 250, _startPosY + 60, 15, 10);
            g.DrawRectangle(pen, _startPosX + 250, _startPosY + 60, 15, 10);
            g.FillRectangle(white, _startPosX + 255, _startPosY + 70, 5, 8);
            g.DrawRectangle(pen, _startPosX + 255, _startPosY + 70, 5, 8);
            g.FillRectangle(white, _startPosX + 40, _startPosY + 60, 15, 10);
            g.DrawRectangle(pen, _startPosX + 40, _startPosY + 60, 15, 10);
            g.FillRectangle(white, _startPosX + 45, _startPosY + 70, 5, 8);
            g.DrawRectangle(pen, _startPosX + 45, _startPosY + 70, 5, 8);
            g.FillEllipse(brBlack, _startPosX + 250, _startPosY + 75, 15, 15);
            g.FillEllipse(brBlack, _startPosX + 45, _startPosY + 75, 15, 15);
            g.FillEllipse(brBlack, _startPosX + 35, _startPosY + 75, 15, 15);
        }
    }
}