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
                g.FillRectangle(main, _startPosX + 10, _startPosY - 1, 250, 62);
                g.FillEllipse(main, _startPosX + 230, _startPosY - 1, 70, 62);
                g.FillEllipse(main, _startPosX + 220, _startPosY + 22, 100, 38);
                g.FillEllipse(dop, _startPosX - 35, _startPosY - 1, 120, 62);
                g.FillRectangle(dop, _startPosX + 5, _startPosY - 55, 40, 65);
                g.FillEllipse(dop, _startPosX - 35, _startPosY - 1, 120, 62);
                g.FillEllipse(dop, _startPosX + 15, _startPosY - 55, 50, 100);
                g.FillEllipse(dop, _startPosX - 25, _startPosY + 20, 70, 10);
                g.DrawEllipse(pen, _startPosX - 25, _startPosY + 20, 70, 10);
            }
            switch (Turbines)
            {
                case 1:
                    g.FillRectangle(dop, _startPosX + 140, _startPosY + 56, 40, 25);
                    g.DrawRectangle(pen, _startPosX + 140, _startPosY + 56, 40, 25);
                    g.FillRectangle(dop, _startPosX + 180, _startPosY + 59, 10, 20);
                    g.DrawRectangle(pen, _startPosX + 180, _startPosY + 59, 5, 20);
                    g.FillRectangle(dop, _startPosX + 135, _startPosY + 59, 10, 20);
                    g.DrawRectangle(pen, _startPosX + 140, _startPosY + 59, 5, 20);
                    Pen pen1 = new Pen(Color.Black);
                    break;
                case 2:
                    g.FillRectangle(dop, _startPosX + 100, _startPosY + 56, 40, 25);
                    g.DrawRectangle(pen, _startPosX + 100, _startPosY + 56, 40, 25);
                    g.FillRectangle(dop, _startPosX + 95, _startPosY + 59, 10, 20);
                    g.DrawRectangle(pen, _startPosX + 95, _startPosY + 59, 5, 20);
                    g.FillRectangle(dop, _startPosX + 135, _startPosY + 59, 10, 20);
                    g.DrawRectangle(pen, _startPosX + 140, _startPosY + 59, 5, 20);
                    Pen pen2 = new Pen(Color.Black);
                    break;
            }
            base.DrawAir(g);
            g.FillEllipse(lblue, _startPosX + 220, _startPosY + 12, 8, 8);
            g.DrawEllipse(pen, _startPosX + 220, _startPosY + 12, 8, 8);
            g.FillEllipse(lblue, _startPosX + 210, _startPosY + 12, 8, 8);
            g.DrawEllipse(pen, _startPosX + 210, _startPosY + 12, 8, 8);
            g.FillEllipse(lblue, _startPosX + 200, _startPosY + 12, 8, 8);
            g.DrawEllipse(pen, _startPosX + 200, _startPosY + 12, 8, 8);
            g.FillEllipse(lblue, _startPosX + 190, _startPosY + 12, 8, 8);
            g.DrawEllipse(pen, _startPosX + 190, _startPosY + 12, 8, 8);
            g.FillEllipse(lblue, _startPosX + 180, _startPosY + 12, 8, 8);
            g.DrawEllipse(pen, _startPosX + 180, _startPosY + 12, 8, 8);
            g.FillEllipse(lblue, _startPosX + 170, _startPosY + 12, 8, 8);
            g.DrawEllipse(pen, _startPosX + 170, _startPosY + 12, 8, 8);
            g.FillEllipse(lblue, _startPosX + 160, _startPosY + 12, 8, 8);
            g.DrawEllipse(pen, _startPosX + 160, _startPosY + 12, 8, 8);
            g.FillEllipse(lblue, _startPosX + 150, _startPosY + 12, 8, 8);
            g.DrawEllipse(pen, _startPosX + 150, _startPosY + 12, 8, 8);
            g.FillEllipse(lblue, _startPosX + 140, _startPosY + 12, 8, 8);
            g.DrawEllipse(pen, _startPosX + 140, _startPosY + 12, 8, 8);
            g.FillEllipse(lblue, _startPosX + 130, _startPosY + 12, 8, 8);
            g.DrawEllipse(pen, _startPosX + 130, _startPosY + 12, 8, 8);
        }
    }
}
