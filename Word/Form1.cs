using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Word
{

    public partial class Form1 : Form
    {
        public string DurFormat { get; set; }

        private string[] FilesDirs = new string[3];
        private bool[] FilesSAved = { false, false, false };
        private bool[] FilesActive = { false, false, false };
        private string[] FilesFormat = new string[3];
        private int durFile = 0;


        /// <summary>
        /// Создание нового окна. Открытие незакрытых в прошлый раз файлов.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine();
            butPa2Bold.Font = new Font(butPa2Bold.Font.FontFamily, 13);
            butPa2Strike.Font = new Font(butPa2Strike.Font.FontFamily, 13);
            butPa2Under.Font = new Font(butPa2Under.Font.FontFamily, 11);
            KeyPreview = true;
            FileText1.ContextMenuStrip = contextMenuStrip1;
            FileText2.ContextMenuStrip = contextMenuStrip1;
            FileText3.ContextMenuStrip = contextMenuStrip1;
            DurFormat = ".txt";
            try
            {
                using (StreamReader sr = new StreamReader("sett.txt"))
                {
                    string[] info = sr.ReadToEnd().Split("\r\n");
                    
                    BoxTime.Text = info[0];
                    timer1.Interval = int.Parse(info[0]) * 60000;
                    if (info[1] == "light")
                    {
                        buttonLight.PerformClick();
                    }
                    else
                    {
                        buttonDark.PerformClick();
                    }
                    if (info[2] != "..." && File.Exists(info[2]))
                    {
                        butPan2File1.Text = "LastFile1";
                        butPan2File1.Enabled = false;
                        butPan2File2.Enabled = true;
                        butPan2File3.Enabled = true;
                        FileText1.Visible = true;
                        FileText2.Visible = false;
                        FileText3.Visible = false;
                        Read(ref FileText1, info[2]);
                    }
                    if (info[3] != "..." && File.Exists(info[3]))
                    {
                        butPan2File2.Text = "LastFile2";
                        butPan2File1.Enabled = true;
                        butPan2File2.Enabled = false;
                        butPan2File3.Enabled = true;
                        FileText1.Visible = false;
                        FileText2.Visible = true;
                        FileText3.Visible = false;
                        Read(ref FileText2, info[3]);
                    }
                    if (info[4] != "..." && File.Exists(info[4]))
                    {
                        butPan2File3.Text = "LastFile3";
                        butPan2File1.Enabled = true;
                        butPan2File2.Enabled = true;
                        butPan2File3.Enabled = false;
                        FileText1.Visible = false;
                        FileText2.Visible = false;
                        FileText3.Visible = true;
                        Read(ref FileText3, info[4]);
                    }
                    for (int i = 0; i < 3; ++i)
                    {
                        string[] nameInfo = info[i + 2].Split(".");
                        if (info[2 + i] != "..." && File.Exists(info[i + 2]))
                        {
                            FilesSAved[i] = true;
                            FilesDirs[i] = info[i + 2];
                            FilesActive[i] = true;
                            Pan2IsSaved.Text = "Cохранено";
                            FilesFormat[i] = "." + nameInfo[nameInfo.Length - 1];
                        } 
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить настройки.");
            }
        }

        /// <summary>
        /// Востановление файла с данными "sett.txt" есои он пострадал.
        /// Сохранение данных о теме, времени автосохранений и т.п.
        /// </summary>
        private void SettGen()
        {
            string info = "";
            info += BoxTime.SelectedItem;
            info += (panel1.BackColor == Color.PaleTurquoise) ? "light" : "dark";
            for (int i = 0; i < 3; ++i)
            {
                info += (FilesActive[i] ? FilesDirs[i] : "...");
            }
            using (StreamWriter sw = new StreamWriter("sett.txt"))
            {
                    sw.Write(info);
            }
        }

        /// <summary>
        /// Обновление данных о теме в файле sett.txt.
        /// </summary>
        /// <param name="newStr"> Название новой темы. </param>
        private void SettGen(string newStr)
        {
            string[] inp;
            try
            {
                using (StreamReader sr = new StreamReader("sett.txt"))
                {
                    inp = sr.ReadToEnd().Split("\r\n");
                }
                inp[1] = newStr;
                using (StreamWriter sw = new StreamWriter("sett.txt"))
                {
                    sw.Write(string.Join("\r\n", inp));
                }
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить настройки.");
                SettGen();
            }
        }

        /// <summary>
        /// Обновление данных о времени автосохранений в файле sett.txt.
        /// <param name="newStr"> Новое время. </param>
        /// </summary>
        private void SettGen(int newInt)
        {
            string[] inp;
            try
            {
                using (StreamReader sr = new StreamReader("sett.txt"))
                {
                    inp = sr.ReadToEnd().Split("\r\n");
                }
                inp[0] = newInt + "";
                using (StreamWriter sw = new StreamWriter("sett.txt"))
                {
                    sw.Write(string.Join("\r\n", inp));
                }
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить настройки.");
                SettGen();
            }
        }
        /// <summary>
        /// Обновление данных о одном из файлов в файле sett.txt.
        /// <param name="newInt"> Индекс файла. </param>
        /// <param name="newStr"> Расположение файла. </param>
        /// </summary>
        private void SettGen(int newInt, string newStr)
        {
            string[] inp;
            try
            {
                using (StreamReader sr = new StreamReader("sett.txt"))
                {
                    inp = sr.ReadToEnd().Split("\r\n");
                }
                inp[2 + newInt] = newStr;
                using (StreamWriter sw = new StreamWriter("sett.txt"))
                {
                    sw.Write(string.Join("\r\n", inp));
                }
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить настройки.");
                SettGen();
            }
        }

        /// <summary>
        /// Реализация горячих клавиш.
        /// </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N && !e.Shift)
            {
                newFileToolStripMenuItem.PerformClick();
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.N)
            {
                Form1 searchForm = new Form1();
                searchForm.Show();
            }
            else if (e.Control && e.KeyCode == Keys.S && !e.Shift)
            {
                butPan2Save.PerformClick();
            }
            else if(e.Control && e.KeyCode == Keys.S && e.Shift)
            {
                int SaveDur = durFile;
                durFile = 0;
                butPan2Save.PerformClick();
                durFile = 1;
                butPan2Save.PerformClick();
                durFile = 2;
                butPan2Save.PerformClick();
                durFile = SaveDur;
            }
        }

        /// <summary>
        /// Закрытие панели открыть/создать.
        /// </summary>
        private void butPanClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        /// <summary>
        /// Cjplfybt файла .txt.
        /// </summary>
        private void butPanCreate_Click(object sender, EventArgs e)
        {
            var path = userDir.Text + "\\" + userName.Text + DurFormat;
            if (userName.Text == "" || userDir.Text == "")
            {
                Info.Text = "Введите путь и имя!";
            }
            else if (!Directory.Exists(userDir.Text))
            {
                Info.Text = "Нет такого каталога!";
            }
            else
            {
                if (File.Exists(path))
                {
                    Info.Text = "Уже есть такой файл!";
                }
                else
                {
                    if (DurFormat == ".txt")
                    {
                        using (File.Create(path)) { };
                        Info.Text = "Успешно создан!";
                    }
                    else
                    {
                        Info.Text = "Эта функция не поддерживается((";
                    }
                }
            }
        }

        /// <summary>
        /// Открытие файла и вывод его текста.
        /// </summary>
        /// <param name="tb"> TextBox куда нужно вывести текст. </param>
        /// <param name="path"> Расположение файла. </param>
        public void Read(ref RichTextBox tb, string path)
        {
            if (DurFormat == ".txt")
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    tb.Text = sr.ReadToEnd();
                }
            }
            else
            {
                tb.LoadFile(path);
            }
        }

        /// <summary>
        /// Открытие файла .txt или .rtf.
        /// </summary>
        /// <param name="ActiveNum"> Будущий индекс файла. </param>
        /// <param name="path"> Расположение файла. </param> 
        private void Open(int ActiveNum, string path)
        {
            durFile = ActiveNum;
            if (ActiveNum == 0)
            {
                butPan2File1.Text = userName.Text + DurFormat;
                butPan2File1.Enabled = false;
                butPan2File2.Enabled = true;
                butPan2File3.Enabled = true;
                FileText1.Visible = true;
                FileText2.Visible = false;
                FileText3.Visible = false;
                Read(ref FileText1, path);

            }
            else if (ActiveNum == 1)
            {
                butPan2File2.Text = userName.Text + DurFormat;
                butPan2File1.Enabled = true;
                butPan2File2.Enabled = false;
                butPan2File3.Enabled = true;
                FileText1.Visible = false;
                FileText2.Visible = true;
                FileText3.Visible = false;
                Read(ref FileText2, path);
            }
            else if (ActiveNum == 2)
            {
                butPan2File3.Text = userName.Text + DurFormat;
                butPan2File1.Enabled = true;
                butPan2File2.Enabled = true;
                butPan2File3.Enabled = false;
                FileText1.Visible = false;
                FileText2.Visible = false;
                FileText3.Visible = true;
                Read(ref FileText3, path);
            }
            FilesSAved[ActiveNum] = true;
            FilesDirs[ActiveNum] = path;
            FilesActive[ActiveNum] = true;
            Pan2IsSaved.Text = "Cохранено";
            FilesFormat[ActiveNum] = DurFormat;
            SettGen(durFile, path);
        }



        /// <summary>
        /// Проверка корректности данных пользователя для открытия файла.
        /// </summary>
        private void butPanOpen_Click(object sender, EventArgs e)
        {
            string path = userDir.Text + "\\" + userName.Text + DurFormat;
            if (userName.Text == "" || userDir.Text == "")
            {
                Info.Text = "Введите путь и имя!";
                return;
            }
            if (!Directory.Exists(userDir.Text))
            {
                Info.Text = "Нет такого каталога!";
                return;
            }
            if (!File.Exists(path))
            {
                Info.Text = "Нет такого файла!";
                return;
            }

            int ActiveNum = -1;
            if (!FilesActive[0])
                ActiveNum = 0;
            else if (!FilesActive[1])
                ActiveNum = 1;
            else if (!FilesActive[2])
                ActiveNum = 2;

            if (ActiveNum == -1)
            {
                Info.Text = "Уже открыто 3 файла. Закройте что-нибудь.";
                return;
            }
            Open(ActiveNum, path);
        }

        /// <summary>
        /// Открытие окна создание файла.
        /// </summary>
        /* private void butCreate_Click(object sender, EventArgs e)
        {
            label3.Text = "Создать файл txt";

            butPanCreate.Enabled = true;
            butPanOpen.Enabled = false;

            panel1.Visible = true;
        }*/
        /// <summary>
        /// Открытие окна открытие файла.
        /// </summary>
        private void butOpen_Click(object sender, EventArgs e)
        {
            label3.Text = "Открыть файл txt";

            butPanCreate.Enabled = false;
            butPanOpen.Enabled = true;

            panel1.Visible = true;
        }

        /// <summary>
        /// Сохранение открытого файла.
        /// </summary>
        /// <param name="tb"> TextBox. </param> 
        public void Save(ref RichTextBox tb)
        {
            if (FilesFormat[durFile] == ".txt")
            {
                using (StreamWriter sw = new StreamWriter(FilesDirs[durFile]))
                    sw.Write(tb.Text[durFile]);
            }
            else
            {
                tb.SaveFile(FilesDirs[durFile]);
            }
        }


        /// <summary>
        /// Обработка нажатия на кнопку сохранить.
        /// </summary>
        private void butPan2Save_Click(object sender, EventArgs e)
        {
            if (FilesActive[durFile])
            {
                if (durFile == 0)
                    Save(ref FileText1);
                if (durFile == 1)
                    Save(ref FileText2);
                if (durFile == 2)
                    Save(ref FileText3);
                FilesSAved[durFile] = true;
                Pan2IsSaved.Text = "Cохранено";
            }
        }

        /// <summary>
        /// Переключение на 1-й файл.
        /// </summary>
        private void butPan2File1_Click(object sender, EventArgs e)
        {
            durFile = 0;
            butPan2File1.Enabled = false;
            butPan2File2.Enabled = true;
            butPan2File3.Enabled = true;
            FileText1.Visible = true;
            FileText2.Visible = false;
            FileText3.Visible = false;
            Pan2IsSaved.Text = FilesSAved[durFile] ? "Cохранено" : "Не сохранено";
        }

        /// <summary>
        /// Переключение на 2-й файл.
        /// </summary>
        private void butPan2File2_Click(object sender, EventArgs e)
        {
            durFile = 1;
            butPan2File1.Enabled = true;
            butPan2File2.Enabled = false ;
            butPan2File3.Enabled = true;
            FileText1.Visible = false;
            FileText2.Visible = true;
            FileText3.Visible = false;
            Pan2IsSaved.Text = FilesSAved[durFile] ? "Cохранено" : "Не сохранено";
        }

        /// <summary>
        /// Переключение на 3-й файл.
        /// </summary>
        private void butPan2File3_Click(object sender, EventArgs e)
        {
            durFile = 2;
            butPan2File1.Enabled = true;
            butPan2File2.Enabled = true;
            butPan2File3.Enabled = false;
            FileText1.Visible = false;
            FileText2.Visible = false;
            FileText3.Visible = true;
            Pan2IsSaved.Text = FilesSAved[durFile] ? "Cохранено" : "Не сохранено";
        }

        /// <summary>
        /// Закрытие текущего файла.
        /// </summary>
        public void FileClose()
        {
            FilesSAved[durFile] = true;
            FilesActive[durFile] = false;
            if (durFile == 0)
            {
                butPan2File1.Text = "...";
                FileText1.Text = "...";
            }
            else if (durFile == 1)
            {
                butPan2File2.Text = "...";
                FileText2.Text = "...";
            }
            else if (durFile == 2)
            {
                butPan2File3.Text = "...";
                FileText3.Text = "...";
            }
            SettGen(durFile, "...");
        }

        /// <summary>
        /// Обработка кнопки закрыть с предложением 3-х вариантов для несохраненного файла.
        /// </summary>
        private void Pan2Close_Click(object sender, EventArgs e)
        {
            if (!FilesActive[durFile])
                return;
            if (!FilesSAved[durFile])
            {
                panel3.Visible = true;
                panel1.Enabled = false;
                panelBuf.Enabled = false;
            }
            else
            {
                FileClose();
            }
        }


        /// <summary>
        /// Закрыть текущий файл не сохраняя.
        /// </summary>
        private void Pan3Close_Click(object sender, EventArgs e)
        {
            FileClose();
            panel1.Enabled = true;
            panelBuf.Enabled = true;
            panel3.Visible = false;
        }

        /// <summary>
        /// Отмена закрытия.
        /// </summary>
        private void Pa3Stop_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panelBuf.Enabled = true;
            panel3.Visible = false;
        }

        /// <summary>
        /// Закрыть текущий файл сохранив.
        /// </summary>
        private void Pa3Save_Click(object sender, EventArgs e)
        {
            if (FilesActive[durFile])
            {
                if (durFile == 0)
                    Save(ref FileText1);
                if (durFile == 1)
                    Save(ref FileText2);
                if (durFile == 2)
                    Save(ref FileText3);
                FileClose();
                panel1.Enabled = true;
                panelBuf.Enabled = true;
                panel3.Visible = false;
            }
        }

        /// <summary>
        /// Открыть панель Создать файл.
        /// </summary>
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Создать файл";

            butPanCreate.Enabled = true;
            butPanOpen.Enabled = false;

            panel1.Visible = true;
        }

        /// <summary>
        /// Открыть панель Открыть файл.
        /// </summary>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Открыть файл";

            butPanCreate.Enabled = false;
            butPanOpen.Enabled = true;

            panel1.Visible = true;
        }

        /// <summary>
        /// Открыть панель Настройки.
        /// </summary>
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pa5Name.Text = "Настройки";
            BoxTime.Enabled = true;
            panel4.Visible = true;
            buttonDark.Enabled = true;
            buttonLight.Enabled = true;
            TextTypeBox.Enabled = false;
        }

        /// <summary>
        /// Закрыть панель Настройки/Формат.
        /// </summary>
        private void pa4Close_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        /// <summary>
        /// Выбрать .rtf.
        /// </summary>
        private void butPanRtf_Click(object sender, EventArgs e)
        {
            butPanRtf.Enabled = false;
            butPanTxt.Enabled = true;
            DurFormat = ".rtf";

        }

        /// <summary>
        /// Выбрать .txt.
        /// </summary>
        private void butPanTxt_Click(object sender, EventArgs e)
        {
            butPanRtf.Enabled = true;
            butPanTxt.Enabled = false;
            DurFormat = ".txt";
        }

        /// <summary>
        /// Автосохранение  файлов.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FilesActive[0])
            {
                Save(ref FileText1);
                FilesSAved[0] = true;
            }
            if (FilesActive[1])
            {
                Save(ref FileText2);
                FilesSAved[1] = true;
            }
            if (FilesActive[2])
            {
                Save(ref FileText3);
                FilesSAved[2] = true;
            }
            Pan2IsSaved.Text = "Cохранено";
        }

        /// <summary>
        /// Изменения частоты автосохранений файлов.
        /// </summary>
        private void BoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettGen(int.Parse((string)BoxTime.SelectedItem));
            timer1.Interval = int.Parse((string)BoxTime.SelectedItem) * 60000;
        }

        /// <summary>
        /// Изменение темы на светлую.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            SettGen("light");
            panel1.BackColor = Color.PaleTurquoise;
            panel2.BackColor = Color.PaleTurquoise;
            panel3.BackColor = Color.PaleTurquoise;
            panel4.BackColor = Color.PaleTurquoise;
            panelBuf.BackColor = Color.PaleTurquoise;
            BackColor = Color.BlanchedAlmond;
            butPanClose.BackColor = Color.Tomato;
            pa4Close.BackColor = Color.Tomato;
            Par2Close.BackColor = Color.Tomato;
            pictureBox1.Visible = true;
            Pan3Warning.BackColor = Color.PaleTurquoise;

        }

        /// <summary>
        /// Изменение темы на темную.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            SettGen("dark");
            panel1.BackColor = Color.Gray;
            panel2.BackColor = Color.Gray;
            panel3.BackColor = Color.Gray;
            panel4.BackColor = Color.Gray;
            panelBuf.BackColor = Color.Gray;
            BackColor = Color.Silver;
            butPanClose.BackColor = Color.DarkGray;
            pa4Close.BackColor = Color.DarkGray;
            Par2Close.BackColor = Color.DarkGray;
            Pan3Warning.BackColor = Color.Gray;
            pictureBox1.Visible = false;
        }

        /// <summary>
        /// Открыть панель Формат.
        /// </summary>
        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pa5Name.Text = "Формат";
            BoxTime.Enabled = false;
            buttonDark.Enabled = false;
            buttonLight.Enabled = false;
            TextTypeBox.Enabled = true;
            panel4.Visible = true;
        }

        /// <summary>
        /// Изменение шрифта.
        /// </summary>
        private void TextTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilesActive[durFile] && FilesFormat[durFile] == ".rtf")
            {
                string type = "";
                if (TextTypeBox.SelectedIndex == 0)
                {
                    type = "Default";
                }
                else if (TextTypeBox.SelectedIndex == 1)
                {
                    type = "Elephant";
                }
                if (durFile == 0)
                {
                    FileText1.SelectionFont = new Font(type, FileText1.Font.Size, FileText1.Font.Style);
                }
                else if (durFile == 1)
                {
                    FileText2.SelectionFont = new Font(type, FileText2.Font.Size, FileText1.Font.Style);
                }
                else
                {
                    FileText3.SelectionFont = new Font(type, FileText3.Font.Size, FileText1.Font.Style);
                }
            }
                 
        }

        /// <summary>
        /// Зачеркнуть выбранный фрагмент текста.
        /// </summary>
        private void butPa2Strike_Click(object sender, EventArgs e)
        {
            FileText1.SelectionFont = new Font(FileText1.SelectionFont, FontStyle.Strikeout ^ FileText1.SelectionFont.Style);
        }

        /// <summary>
        /// Подчеркнуть выбранный фрагмент текста.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
           FileText1.SelectionFont = new Font(FileText1.SelectionFont, FontStyle.Underline ^ FileText1.SelectionFont.Style);
        }

        /// <summary>
        /// Сделать жирным выбранный фрагмент текста.
        /// </summary>
        private void button2_Click_1(object sender, EventArgs e)
        {
            FileText1.SelectionFont = new Font(FileText1.SelectionFont, FontStyle.Bold ^ FileText1.SelectionFont.Style);
        }

        /// <summary>
        /// Сделать косым выбранный фрагмент текста.
        /// </summary>
        private void butPa2Italic_Click(object sender, EventArgs e)
        {
            FileText1.SelectionFont = new Font(FileText1.SelectionFont, FontStyle.Italic ^ FileText1.SelectionFont.Style);
        }

        /// <summary>
        /// Выбрать всё.
        /// </summary>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FileText1.SelectAll();
        }

        /// <summary>
        /// Копировать.
        /// </summary>
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (durFile == 0)
            {
                richTextBoxCopy.Text = FileText1.SelectedText;
            }
            else if (durFile == 1)
            {
                richTextBoxCopy.Text = FileText1.SelectedText;
            }
            else
            {
                richTextBoxCopy.Text = FileText1.SelectedText;
            }
        }

        /// <summary>
        /// Вставить.
        /// </summary>
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (durFile == 0)
            {
                FileText1.SelectedText = richTextBoxCopy.Text;
            }
            else if (durFile == 1)
            {
                FileText2.SelectedText = richTextBoxCopy.Text;
            }
            else
            {
                FileText3.SelectedText = richTextBoxCopy.Text;
            }
            
        }

        /// <summary>
        /// Изменение текста в 1-й вкладке.
        /// </summary>
        private void FileText1_TextChanged(object sender, EventArgs e)
        {
            if (FilesActive[durFile] == false)
                return;
            FilesSAved[durFile] = false;
            Pan2IsSaved.Text = "Не сохранено";
        }

        /// <summary>
        /// Изменение текста в 2-й вкладке.
        /// </summary>
        private void FileText2_TextChanged(object sender, EventArgs e)
        {
            if (FilesActive[durFile] == false)
                return;
            FilesSAved[durFile] = false;
            Pan2IsSaved.Text = "Не сохранено";
        }

        /// <summary>
        /// Изменение текста в 3-й вкладке.
        /// </summary>
        private void FileText3_TextChanged(object sender, EventArgs e)
        {
            if (FilesActive[durFile] == false)
                return;
            FilesSAved[durFile] = false;
            Pan2IsSaved.Text = "Не сохранено";
        }

        /// <summary>
        /// Изменение текста в 1-й вкладке.
        /// </summary>
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (durFile == 0)
            {
                richTextBoxCopy.Text = FileText1.SelectedText;
                FileText1.SelectedText = "";
            }
            else if (durFile == 1)
            {
                richTextBoxCopy.Text = FileText2.SelectedText;
                FileText2.SelectedText = "";
            }
            else
            {
                richTextBoxCopy.Text = FileText3.SelectedText;
                FileText3.SelectedText = "";
            }
            
        }

        /// <summary>
        /// Изменение шрифта на Default.
        /// </summary>
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (FilesActive[durFile] && FilesFormat[durFile] == ".rtf")
            {
                string type = "Default";
                if (durFile == 0)
                {
                    FileText1.SelectionFont = new Font(type, FileText1.Font.Size, FileText1.Font.Style);
                }
                else if (durFile == 1)
                {
                    FileText2.SelectionFont = new Font(type, FileText2.Font.Size, FileText1.Font.Style);
                }
                else
                {
                    FileText3.SelectionFont = new Font(type, FileText3.Font.Size, FileText1.Font.Style);
                }
            }
        }

        /// <summary>
        /// Изменение шрифта на Elephant.
        /// </summary>
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (FilesActive[durFile] && FilesFormat[durFile] == ".rtf")
            {
                string type = "Elephant";
                if (durFile == 0)
                {
                    FileText1.SelectionFont = new Font(type, FileText1.Font.Size, FileText1.Font.Style);
                }
                else if (durFile == 1)
                {
                    FileText2.SelectionFont = new Font(type, FileText2.Font.Size, FileText1.Font.Style);
                }
                else
                {
                    FileText3.SelectionFont = new Font(type, FileText3.Font.Size, FileText1.Font.Style);
                }
            }
        }

       
    }
}
