using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_10
{/// <summary>
/// Вчисляет корень числа > 0
/// </summary>
    public class FuncSQR
    {
        /// <summary>
        /// Вычисляет корень числа > 0
        /// </summary>
        /// <param name="mass">массив к которому применяется функция</param>
        public void FuncSqr(double[] mass)
        {

            for (int i = 0; i < mass.Length; i++)//цикл для обхода всего массива
                if (mass[i] > 0)//если эл-т массива больше 0, то вычисляется корень эл-та массива
                {
                    mass[i] = Math.Sqrt(mass[i]);
                }
        }

            
        
    }
}
