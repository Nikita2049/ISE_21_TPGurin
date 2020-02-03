using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGurin
{
    public class SuperAir : Air
    {
        public Color DopColor { private set; get; }
        public bool Board { private set; get; }
        public int Turbines { private set; get; }

        public SuperAir(int maxSpeed, float weight, Color mainColor, Color dopColor, bool board, int countturbines) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Board = board;
            Random rnd = new Random();
            Turbines = countturbines;
        }

        public override void DrawAir(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush main = new SolidBrush(MainColor);
            Brush dop = new SolidBrush(DopColor);
            Brush lblue = new SolidBrush(Color.LightBlue);

            if (Board)
            {
                g.FillRectangle(main, _startPosX + 10, _startPosY - 10, 110, 25);
                g.FillEllipse(main, _startPosX + 108, _startPosY - 10, 25, 25);
                g.FillEllipse(main, _startPosX + 100, _startPosY + 5, 45, 10);
                g.FillEllipse(dop, _startPosX - 12, _startPosY - 10, 45, 25);
                g.FillRectangle(dop, _startPosX + 3, _startPosY - 30, 25, 30);
                g.FillEllipse(dop, _startPosX + 14, _startPosY - 30, 25, 40);
                g.FillEllipse(dop, _startPosX - 5, _startPosY + 3, 20, 5);
            }
            switch (Turbines)
            {
                case 1:
                    g.FillRectangle(main, _startPosX + 65, _startPosY + 10, 16, 6);
                    g.DrawRectangle(pen, _startPosX + 65, _startPosY + 10, 16, 6);
                    g.FillRectangle(main, _startPosX + 60, _startPosY + 11, 5, 4);
                    g.DrawRectangle(pen, _startPosX + 60, _startPosY + 11, 5, 4);
                    g.FillRectangle(main, _startPosX + 80, _startPosY + 11, 5, 4);
                    g.DrawRectangle(pen, _startPosX + 80, _startPosY + 11, 5, 4);
                    Pen pen1 = new Pen(Color.Black);
                    break;
                case 2:
                    g.FillRectangle(main, _startPosX + 65, _startPosY + 10, 16, 6);
                    g.DrawRectangle(pen, _startPosX + 65, _startPosY + 10, 16, 6);
                    g.FillRectangle(main, _startPosX + 60, _startPosY + 11, 5, 4);
                    g.DrawRectangle(pen, _startPosX + 60, _startPosY + 11, 5, 4);
                    g.FillRectangle(main, _startPosX + 80, _startPosY + 11, 5, 4);
                    g.DrawRectangle(pen, _startPosX + 80, _startPosY + 11, 5, 4);
                    Pen pen2 = new Pen(Color.Black);
                    break;
            }
            base.DrawAir(g);
            g.FillEllipse(dop, _startPosX + 40, _startPosY - 5, 7, 7);
            g.DrawEllipse(pen, _startPosX + 40, _startPosY - 5, 7, 7);
            g.FillEllipse(dop, _startPosX + 50, _startPosY - 5, 7, 7);
            g.DrawEllipse(pen, _startPosX + 50, _startPosY - 5, 7, 7);
            g.FillEllipse(dop, _startPosX + 60, _startPosY - 5, 7, 7);
            g.DrawEllipse(pen, _startPosX + 60, _startPosY - 5, 7, 7);
            g.FillEllipse(dop, _startPosX + 70, _startPosY - 5, 7, 7);
            g.DrawEllipse(pen, _startPosX + 70, _startPosY - 5, 7, 7);
            g.FillEllipse(dop, _startPosX + 80, _startPosY - 5, 7, 7);
            g.DrawEllipse(pen, _startPosX + 80, _startPosY - 5, 7, 7);
            g.FillEllipse(dop, _startPosX + 90, _startPosY - 5, 7, 7);
            g.DrawEllipse(pen, _startPosX + 90, _startPosY - 5, 7, 7);
        }
    }
}
