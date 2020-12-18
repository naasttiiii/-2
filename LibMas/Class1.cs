using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibMas
{
    public class Massiv
    { 
        //Oдномерный массив
        private int[] mass;

        //Kонструктор для инициализации массива
        public Massiv (int n)
        {
            mass = new int[n];
        }

        // Заполнениe массива случайными числами
        public int[] Rand(int minValue, int maxValue)
         
        {
            
            Random rnd = new Random();//Создание объекта в памяти
            //Цикл для обхода всего массива
            for (int i = 0; i < mass.Length; ++i)
            {
                //запись в ячейку массива случайного значения
                mass[i] = rnd.Next(minValue, maxValue);
            }

            return mass;
        }

        //Очистка
        public int[] Clear(int[] array)
        {
            //заполнение массива 0
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = 0;
            }

            return array;
        }

        //Вывод массива
        public void Print(DataGridView dataTable)
        {
            //вывод массива в таблицу на форме
            for (int i = 0; i < mass.Length; ++i)
            {
                dataTable[i, 0].Value = mass[i];
            }
        }
    }

    
}
