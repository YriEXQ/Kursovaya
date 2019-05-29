using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form1 : Form
    {
        //=======Данные=======//
        float MaxPercent = 0;
        private static bool[] _Table;
        private int CHUNCKSIZE = 2;
        string Original = "";
        string Compare = "";

        public Form1()
        {
            InitializeComponent();
            InititializeTable();
            cb_ChunkSize.SelectedIndex = 0;
        }


        //=======Служебные методы=======//
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
            for (int j = 0; j < arWords.Length - chunkSize + 1; j++)
            {

                for (int i = 0; i < chunkSize && (j < arWords.Length - chunkSize + 1); i++)
                    arShingles[j] += arWords[i + j];
            }
        }

        private float DoShinglesAlghoritm()
        {

            if (this.Original.Length == 0 || this.Compare.Length == 0)
            {
                return -1;
            }


            //ПОДГОТОВКА ИСХОДНОГО ТЕКСТА(Надо проверить на то что текст вообще есть)
            this.Original = Сanonize(this.Original); //Канонизация
            this.Original = string.Join("`", Original.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            String[] arWordsOriginal = new String[Original.Length];
            arWordsOriginal = this.Original.Split('`'); //Разбиение текста на слова
            if (arWordsOriginal.Length < CHUNCKSIZE)
            {
                return -1;
            }
            String[] arShinglesOriginal = new String[arWordsOriginal.Length - CHUNCKSIZE + 1];
            SplitIntoShingles(ref arShinglesOriginal, ref arWordsOriginal, CHUNCKSIZE); //Разбиение текста на шинглы


            //ПОДГОТОВКА СРАВНИВАЕМОГО ТЕКСТА(Надо проверить на то что текст вообще есть)
            this.Compare = Сanonize(this.Compare); //Канонизация
            this.Compare = string.Join("`", Compare.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            String[] arWordsCompare = new String[Compare.Length];
            arWordsCompare = this.Compare.Split('`'); //Разбиение текста на слова
            if (arWordsCompare.Length < CHUNCKSIZE)
            {
                return -1;
            }
            String[] arShinglesCompare = new String[arWordsCompare.Length - CHUNCKSIZE + 1];
            SplitIntoShingles(ref arShinglesCompare, ref arWordsCompare, CHUNCKSIZE); //Разбиение текста на шинглы


            //Считаем количество совпадений
            float MinLenght = arShinglesOriginal.Length;
            float CountOfСoincidence = 0;
            if (MinLenght > arShinglesCompare.Length) MinLenght = arShinglesCompare.Length;
            for (int i = 0; i < MinLenght; i++)
            {
                if (arShinglesOriginal[i].GetHashCode() == arShinglesCompare[i].GetHashCode()) CountOfСoincidence++;
            }
            //Процент совпадений
            return (CountOfСoincidence / MinLenght) * 100;
            
        }

        private void b_Start_Click(object sender, EventArgs e)
        {
            //=======Блока с проверками=======//

            //Проверка на выделенность
            if (lb_Files.Items.Count == 0 || lb_Files.SelectedItem == null)
            {
                MessageBox.Show("Не выбран файл или их нет.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Проверка на правильность MaxPercent если 
            try
            { MaxPercent = float.Parse(tb_Limit.Text); }
            catch
            {
                MessageBox.Show("Введите число в границу совпадения.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //=======Выполнение алгоритма=======//
            //Читаем в Original текст из файла
            using (StreamReader sr = new StreamReader(lb_Files.SelectedItem.ToString()))
            {
                this.Original = sr.ReadToEnd();
            }

            //Цикл по всем файлам из ListBox
            for (int i=0;i<lb_Files.Items.Count;i++)
            {
                if (i == lb_Files.SelectedIndex) continue; //Проверка если попали на Original
                //Читаем в Compare текст из файла
                using (StreamReader sr = new StreamReader(lb_Files.Items[i].ToString()))
                {
                    this.Compare = sr.ReadToEnd();
                }
                //Выполняем алгоритм
                double PercentResult = DoShinglesAlghoritm();
                //Если все правильно, то записываем в файл result результат проверки
                if(PercentResult != -1 && PercentResult>MaxPercent)
                { 
                    using (StreamWriter sw = new StreamWriter("result.txt", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(i + "." + lb_Files.Items[i].ToString() +"\t"+ PercentResult + "%");
                    }
                }
                //Иначе вывподим ошибку
                else if(PercentResult == -1) MessageBox.Show($"Недостаточно текста в файле {lb_Files.Items[i].ToString()}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //Вывод MessageBox с успехом
            MessageBox.Show("Операции успешно выполнены и сохранены в файл result.txt в каталоге с программой.", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void b_AddFiles_Click(object sender, EventArgs e)
        {
            //=======Запускаем диалог для выбора папки=======//
            string path = "";
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                    //Присваиваем путь выбранной папки
                    path = dialog.SelectedPath;

            //=======Добавляем файлы в ListBox=======//
            if (path == "") return;
            //Создаем массив с путями к файлам .txt формата
            string[] Files = Directory.GetFiles(path, "*.txt");
            if (Files.Length == 0)
            {
                MessageBox.Show("В папке нет файлов.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Добавляем это в ListBox
            lb_Files.Items.AddRange(Files);
            //Выбираем первый файл автоматически выделенным в ListBox
            lb_Files.SelectedIndex = 0;
            //Выводим количество найденых файлов
            l_FoundCount.Text = Files.Length.ToString();
        }

        private void cb_ChunkSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_ChunkSize.Text)
            {
                case "2":
                    CHUNCKSIZE = 2;
                    break;
                case "4":
                    CHUNCKSIZE = 4;
                    break;
                case "6":
                    CHUNCKSIZE = 6;
                    break;
                case "8":
                    CHUNCKSIZE = 8;
                    break;
                default:
                    CHUNCKSIZE = 2;
                    break;
            }
        }
    }
}
