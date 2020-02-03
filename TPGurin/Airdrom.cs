using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGurin
{
    public class Port<T> where T : class, IAir
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private T[] _places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int PictureWidth { get; set; }
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int PictureHeight { get; set; }
        /// <summary>
        /// Размер посадочной полосы (ширина)
        /// </summary>
        private const int _placeSizeWidth = 180;
        /// <summary>
        /// Размер посадочной полосы (высота)
        /// </summary>
        private const int _placeSizeHeight = 70;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sizes">Количество мест на парковке</param>
        /// <param name="pictureWidth">Рамзер ы - ширина</param>
        /// <param name="pictureHeight">Рамзер полосы - высота</param>
        public Port(int sizes, int pictureWidth, int pictureHeight)
        {
            _places = new T[sizes];
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i] = null;
            }
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется самолет
        /// </summary>
        /// <param name="p">полоса</param>
        /// <param name="air">Добавляемое самолет</param>
        /// <returns></returns>
        public static int operator +(Port<T> p, T air)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places[i] = air;
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 10,
                     i % 5 * _placeSizeHeight + 40, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с полосы забираем самолет
        /// </summary>
        /// <param name="p">Полоса</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь

        /// <returns></returns>
        public static T operator -(Port<T> p, int index)
        {
            if (index < 0 || index > p._places.Length)
            {
                return null;
            }
            if (!p.CheckFreePlace(index))
            {
                T air = p._places[index];
                p._places[index] = null;
                return air;
            }
            return null;
        }
        /// <summary>
        /// Метод проверки заполнености посадочной полосы (ячейки массива)
        /// </summary>
        /// <param name="index">Номер посадочной полосы (порядковый номер)

        /// <returns></returns>
        private bool CheckFreePlace(int index)
        {
            return _places[index] == null;
        }
        /// <summary>
        /// Метод отрисовки полосы
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                if (!CheckFreePlace(i))
                {//если место не пустое
                    _places[i].DrawAir(g);
                }
            }
        }
        /// <summary>
        /// Метод отрисовки разметки посадочных полос
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы полосы
            g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _places.Length / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
    }
}