using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //***Данные***//
        private static bool[] _Table;
        private const int CHUNCKSIZE = 2;

        //***Служебные методы***//
        public Form1()
        {
            InitializeComponent();
            InititializeTable();
        }
        private void InititializeTable()
        {
            _Table = new bool[65536];
            for (char c = '0'; c <= '9'; c++) _Table[c] = true;
            for (char c = 'A'; c <= 'Z'; c++) _Table[c] = true;
            for (char c = 'a'; c <= 'z'; c++) _Table[c] = true;
            _Table['.'] = true; _Table['('] = true; _Table[')'] = true;
            _Table['>'] = true; _Table['<'] = true; _Table['='] = true;
            _Table['-'] = true; _Table['+'] = true; _Table['*'] = true;
            _Table['/'] = true; _Table['!'] = true; _Table['%'] = true;
            _Table['&'] = true; _Table['|'] = true; _Table['~'] = true;
            _Table[' '] = true; _Table['\\'] = true;
        }
        private static string Сanonize(string str)
        {
            char[] buffer = new char[str.Length];
            int index = 0;
            foreach (char c in str)
            {
                if (_Table[c])
                {
                    buffer[index] = c;
                    index++;
                }

            }
            return new string(buffer, 0, index);
        }
        private void SplitIntoShingles(ref String[] arShingles, ref String[] arWords, int chunkSize)
        { 
            for (int j = 0; j< arWords.Length - chunkSize + 1; j++)
            {
                
                for(int i=0; i<chunkSize && (j<arWords.Length - chunkSize + 1); i++)
                    arShingles[j] += arWords[i+j];

            }

        }

        //***События***//
        private void b_do_Click(object sender, EventArgs e)
        {
            //ПОДГОТОВКА ИСХОДНОГО ТЕКСТА(Надо проверить на то что текст вообще есть)
            String Original = Сanonize(tb_original.Text); //Канонизация
            Original = string.Join("`", Original.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            String[] arWordsOriginal = new String[Original.Length];
            arWordsOriginal = Original.Split('`'); //Разбиение текста на слова

            String[] arShinglesOriginal = new String[arWordsOriginal.Length - CHUNCKSIZE + 1];
            SplitIntoShingles(ref arShinglesOriginal, ref arWordsOriginal, CHUNCKSIZE); //Разбиение текста на шинглы


            //ПОДГОТОВКА СРАВНИВАЕМОГО ТЕКСТА(Надо проверить на то что текст вообще есть)
            String Compare = Сanonize(tb_compare.Text); //Канонизация
            Compare = string.Join("`", Compare.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            String[] arWordsCompare = new String[Compare.Length];
            arWordsCompare = Compare.Split('`'); //Разбиение текста на слова

            String[] arShinglesCompare = new String[arWordsCompare.Length - CHUNCKSIZE + 1];
            SplitIntoShingles(ref arShinglesCompare, ref arWordsCompare, CHUNCKSIZE); //Разбиение текста на шинглы


            //Считаем количество совпадений
            float MinLenght = arShinglesOriginal.Length;
            float CountOfСoincidence = 0;
            float PercentOfCoincidence = 0;
            if (MinLenght > arShinglesCompare.Length) MinLenght = arShinglesCompare.Length;
            for (int i = 0; i < MinLenght; i++)
            {
                if (arShinglesOriginal[i].GetHashCode() == arShinglesCompare[i].GetHashCode()) CountOfСoincidence++;
            }
            //Процент совпадений
            PercentOfCoincidence = (CountOfСoincidence / MinLenght) * 100;
            //Выводим процент совпадений в лэйбл
            l_PercentOfCoince.Text = PercentOfCoincidence.ToString("N2");
            l_PercentOfCoince.Text += '%';

        }
    }
}
