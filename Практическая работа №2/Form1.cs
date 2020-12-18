using Lib_10;
using LibMas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__2
{
    public partial class Praktikum2 : Form
    {
        public Praktikum2()
        {
            InitializeComponent();
        }

        //Кнопка о программе
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хужанова Анастасия ИСП-31\n" +
           "Практическая работа №2\n" +
           "Ввести n целых чисел. Вычислить для чисел > 0 функцию корень из х . Результат обработки каждого числа вывести на экран.\n");
        }
        //Кнопка выход
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Кнопка заполнить массив
        private void btnFillTable_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);//число n задается пользователем, отвечает за кол-во столбцов
            Massiv mas = new Massiv(TableMas.ColumnCount = number);//создание новго экземпляра класса для заполнения массива
            mas.Rand(1, 100);//массив генерирует случайные числа в заданном диапазоне 
            mas.Print(TableMas);//массив выводится в таблицу
        }
        //Кнопка очистить массив
        private void btnClearTable_Click(object sender, EventArgs e)
        {
            Massiv mas = new Massiv(TableMas.ColumnCount);//создание новго экземпляра класса для очистки массива
            mas.Clear(TableMas);//очищается таблица массива
            mas.Print(TableMas);//очищенный массив выводится в таблицу

        }
        //Кнопка вычислить
        private void btnFunc_Click(object sender, EventArgs e)

        {
            int number = TableMas.ColumnCount;//число n берет значение из кол-ва столбцов массива
            double[] mass = new double[number];//объявление массива с кол-вом элементов
            for (int i = 0; i < number; i++)
            {
                mass[i] = Convert.ToDouble(TableMas[i, 0].Value);//элемент массива получает значение из таблицы массивов с кол-вом столбцов заданным пользователем
            }
            FuncSQR func = new FuncSQR();//создание нового экземпляра класса функции вычисления корня из х
            func.FuncSqr(mass);//вычисляет корень элементов массива
            TableFunc.ColumnCount = number;//число столбцов заданное пользователем
            TableFunc.RowCount = 1;//число строк по умолчанию 1
            for (int i = 0; i < number; i++)
            {
                TableFunc[i, 0].Value = Math.Round((mass[i]), 2);//вывод массива в таблицу с вычисленным корнем эл-тов
            }
        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            //Создание объекта диалогового окна для сохранения
            using (SaveFileDialog save = new SaveFileDialog
            {
                //Установка стандартных свойств
                DefaultExt = ".txt",
                Filter = "Все файлы (*.*) | *.* |Текстовые файлы | *.txt",
                FilterIndex = 2,
                Title = "Сохранение таблицы"
            })
            {
                //Если пользователь нажал ОК
                if (save.ShowDialog() == DialogResult.OK)
                {
                    int number = Convert.ToInt32(txtNumber.Text);//число n задается пользователем, отвечает за кол-во столбцов
                    int[] mass = new int[number];//объявление массива с кол-вом элементов
                    for (int i = 0; i < number; i++)
                    {
                        mass[i] = Convert.ToInt32(TableMas[i, 0].Value);//элемент массива получает значение из таблицы массивов с кол-вом столбцов заданным пользователем
                    }
                    
                    Massiv.Save(mass, save.FileName);//массив сохраняется в текстовый документ
                }
            }
        }

        private void btnOpenTable_Click(object sender, EventArgs e)
        {

            //Создание объекта диалогового окна для открытия
            using (OpenFileDialog open = new OpenFileDialog
            {
                //Установка стандартных свойств
                DefaultExt = ".txt",
                Filter = "Все файлы (*.*) | *.* |Текстовые файлы | *.txt",
                FilterIndex = 2,
                Title = "Открытие таблицы"
            })
            {
                //Если пользователь нажал ОК
                if (open.ShowDialog() == DialogResult.OK)
                {
                    //Открыть массив
                    int number = TableMas.ColumnCount;//число n берет значение из кол-ва столбцов массива
                    int[] mass = new int[number];//объявление массива с кол-вом элементов
                    for (int i = 0; i < number; i++)
                    {
                        mass[i] = Convert.ToInt32(TableMas[i, 0].Value);//элемент массива получает значение из таблицы массивов с кол-вом столбцов заданным пользователем
                    }
                    Massiv mas = new Massiv(number);//создание новго экземпляра класса для заполнения массива
                    mas.Open(open.FileName); // открытие массива из текстового документа
                    mas.Print(TableMas);//вывод в таблицу открытого массива из текстового документа
                }
            }
        }


    }
}
