using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGurin
{
    class MultiLevelAirdrom
    {
        /// <summary>
        /// Список с уровнями порта
        /// </summary>
        List<Port<IAir>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        private const int countPlaces = 20;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй в порту</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelAirdrom(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Port<IAir>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Port<IAir>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Port<IAir> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
    }
}