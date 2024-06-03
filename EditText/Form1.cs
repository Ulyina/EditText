using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonOpen_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл 
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName;
                //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
                //Передаем содержимое файла в richTextBox 
            }

        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            {
                saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
                saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации. 
                {
                    var name = saveFileDialog1.FileName; //Задаем имя файлу 
                    File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251 
                }
                richTextBox.Clear();

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            richTextBox.Select();  // выравнивание только выделенного текста 
            richTextBox.SelectionAlignment = HorizontalAlignment.Left; 

        }

        private void Right_Click(object sender, EventArgs e)
        {
            richTextBox.Select();  // выравнивание только выделенного текста 
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Center_Click(object sender, EventArgs e)
        {
            richTextBox.Select();  // выравнивание только выделенного текста 
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);

        }


        private void PrintSettings_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void PrintD_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void ShowD_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void CutContext_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void CopeContext_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void PasteContext_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void ClearContext_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void CelectContext_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл 
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName;
                //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
                //Передаем содержимое файла в richTextBox 
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
                saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации. 
                {
                    var name = saveFileDialog1.FileName; //Задаем имя файлу 
                    File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251 
                }
                richTextBox.Clear();

            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                richTextBox.SelectionColor = selectedColor;
                richTextBox.SelectionLength = 0;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog.Font;
                richTextBox.SelectionFont = selectedFont;
                richTextBox.SelectionLength = 0;
            }

        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 Form = new AboutBox1();
            Form.Show();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл 
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName;
                //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
                //Передаем содержимое файла в richTextBox 
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
                saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации. 
                {
                    var name = saveFileDialog1.FileName; //Задаем имя файлу 
                    File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251 
                }
                richTextBox.Clear();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выделитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = richTextBox.Text.Length;
            richTextBox.Focus();
        }
    }
}
