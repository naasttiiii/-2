using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibMas
{
    public class Massiv
    { 
        //Объявление одномерного массива
        private int[] mass;

        //Kонструктор для инициализации массива
        public Massiv (int n)
        {
            mass = new int[n];
        }

        // Заполнениe массива случайными числами
        /// <summary>
        /// Заполняет массив случайными числами
        /// </summary>
        /// <param name="minValue">Минимальное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        /// <returns>Массив со случайными числами</returns>
        
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
       /// <summary>
       /// Очищает массив(заполняет его 0)
       /// </summary>
       /// <param name="dataTable">Таблица массива</param>
        public void Clear(DataGridView dataTable)
        {
            //заполнение массива 0
            for (int i = 0; i < mass.Length; ++i)
            {
                mass[i] = 0;
            }

        }

        //Вывод массива
        /// <summary>
        /// Выводит массив в таблицу
        /// </summary>
        /// <param name="dataTable">Таблица массива</param>
        public void Print(DataGridView dataTable)
        {
            dataTable.ColumnCount = mass.Length;//число столбцов в таблице равняется длинне массива
            //вывод массива в таблицу на форме
            for (int i = 0; i < mass.Length; ++i)
            {
                dataTable[i, 0].Value = mass[i];
            }
        }

        /// <summary>
        /// Сохранение одномерного массива в файл
        /// </summary>
        /// <param name="mass">сохраняемый одномерный массив</param>
        /// <param name="path">путь к файлу</param>
        public static void Save(int[] mass, string path)
        {
            //Создание потока для работы с файлом, на запись
            using (StreamWriter saveFile = new StreamWriter(path))
            {
                //Запись кол-во столбцов
                saveFile.WriteLine(mass.Length);
                //Запись элементов массива
                for (int i = 0; i < mass.Length; i++)
                {
                    saveFile.WriteLine(mass[i]);
                }
            }
        }

        /// <summary>
        /// Открытие одномерного масиива из файла
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public void Open(string path)
        {
            //Создание потока для работы с файлом, на чтение
            using (StreamReader readFile = new StreamReader(path))
            {
                //Чтение кол-ва столбцов из файла
                int n = Convert.ToInt32(readFile.ReadLine());
                Array.Resize<int>(ref mass, n);//изменяет кол-во эл-тов до кол-ва столбцов из файла
                //Чтение элементов из файла
                for (int i = 0; i < n; i++)
                {
                    mass[i] = Convert.ToInt32(readFile.ReadLine());
                }
            }
        }


    }


}
