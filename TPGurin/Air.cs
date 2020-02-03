using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGurin
{
    public class Air
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;

        private const int shipWidth = 150;
        private const int shipHeight = 10;

        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Wing { private set; get; }
        public bool Chassis { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public Air(int maxSpeed, float weight, Color bottomColor, Color dopColor, bool wing, bool chassis)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = bottomColor;
            DopColor = dopColor;
            Wing = wing;
            Chassis = chassis;
        }
        /// Установка позиции корабля
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
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
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawAir(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush white = new SolidBrush(Color.White);
            Brush bottom = new SolidBrush(MainColor);
            Brush brBlack = new SolidBrush(Color.Black);
            Brush hull = new SolidBrush(DopColor);
            Brush lblue = new SolidBrush(Color.LightBlue);
            Brush dred = new SolidBrush(Color.DarkRed);
            Brush gray = new SolidBrush(Color.Gray);

            // Корпус
            g.FillRectangle(white, _startPosX + 10, _startPosY - 1, 250, 62);
            g.FillEllipse(white, _startPosX + 230, _startPosY - 1, 70, 62);
            g.FillEllipse(white, _startPosX + 220, _startPosY + 22, 100, 38);
            g.FillEllipse(hull, _startPosX - 35, _startPosY - 1, 120, 62);
            g.FillRectangle(hull, _startPosX + 5, _startPosY - 55, 40, 65);
            g.FillEllipse(hull, _startPosX - 35, _startPosY - 1, 120, 62);
            g.FillEllipse(hull, _startPosX + 15, _startPosY - 55, 50, 100);
            g.FillEllipse(hull, _startPosX - 25, _startPosY + 20, 70, 10);

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

            if (Chassis)
            {
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
}