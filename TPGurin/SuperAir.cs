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

        public SuperAir(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Board = Convert.ToBoolean(strs[4]);
                Turbines = Convert.ToInt32(strs[5]);
            }
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
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Board + ";" + Turbines;
        }
        /// <summary>
        /// Метод интерфейса IComparable для класса SuperAir
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(SuperAir other)
        {
            var res = (this is Air).CompareTo(other is Air);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Board != other.Board)
            {
                return Board.CompareTo(other.Board);
            }
            if (Turbines != other.Turbines)
            {
                return Turbines.CompareTo(other.Turbines);
            }
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса SuperAir
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(SuperAir other)
        {
            var res = (this as Air).Equals(other as Air);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Board != other.Board)
            {
                return false;
            }
            if (Turbines != other.Turbines)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is SuperAir airObj))
            {
                return false;
            }
            else
            {
                return Equals(airObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}