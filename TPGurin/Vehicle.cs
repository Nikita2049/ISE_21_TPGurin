﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGurin
{
    public abstract class Vehicle : IAir
    {
        public static float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки самолета
        /// </summary>
        public static float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int _pictureHeight;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }
        /// <summary>
        /// Вес самолета
        /// </summary>
        public float Weight { protected set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public abstract void DrawAir(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}