using Tyuiu.PiskulinIY.Sprint7.Task0.V13.Lib;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
namespace Tyuiu.PiskulinIY.Sprint7.Task0.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        DataService ds = new DataService();

        // Объвление переменной
        string openFilePath;
        private void button3_Click(object sender, EventArgs e)
        {
            // Справка
            MessageBox.Show("Выполнил студент Пискулин Игорь Юрьевич группы: ИСТНб-24-1", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Указываем путь к файлу
            string ruFilePath = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint7\Tyuiu.PiskulinIY.Sprint7.Task0.V13\bin\Debug\net8.0-windows\Russia.txt";

            string americaFilePath = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint7\Tyuiu.PiskulinIY.Sprint7.Task0.V13\bin\Debug\net8.0-windows\America.txt";

            string ChinaFilePath = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint7\Tyuiu.PiskulinIY.Sprint7.Task0.V13\bin\Debug\net8.0-windows\China.txt";

            string JapanesFilePath = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint7\Tyuiu.PiskulinIY.Sprint7.Task0.V13\bin\Debug\net8.0-windows\Japanes.txt";

            string EnglandFilePath = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint7\Tyuiu.PiskulinIY.Sprint7.Task0.V13\bin\Debug\net8.0-windows\England.txt";

            string VaticanFilePath = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint7\Tyuiu.PiskulinIY.Sprint7.Task0.V13\bin\Debug\net8.0-windows\Vatican.txt";

            string SerbiaFilePath = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint7\Tyuiu.PiskulinIY.Sprint7.Task0.V13\bin\Debug\net8.0-windows\Serbia.txt";

            //string "" @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint7\Tyuiu.PiskulinIY.Sprint7.Task0.V13\bin\Debug\net8.0-windows\

            try
            {
                // Считываем содержимое файла через метод FileRead объекта DataService
                string fileContent = ds.FileRead(openFilePath);

                // Устанавливаем текст файла в текстовое поле textBoxResult
                textBoxResult.Text = fileContent;

                // Проверяем, что пользователь ввел "Россия" в текстовое поле textBoxVvod
                if (textBoxVvod.Text.Trim().Equals("Россия", StringComparison.OrdinalIgnoreCase))
                {
                    // Проверяем, существует ли файл с текстом для России
                    if (File.Exists(ruFilePath))
                    {
                        // Считываем содержимое файла для России
                        string ruContent = File.ReadAllText(ruFilePath);

                        // Устанавливаем содержимое файла в текстовое поле textBoxResult
                        textBoxResult.Text = ruContent;

                    }
                }
                // если Америка
                else if (textBoxVvod.Text.Trim().Equals("США", StringComparison.OrdinalIgnoreCase))
                {
                    // Проверка файла
                    if ((File.Exists(americaFilePath)))
                    {
                        // Считываем содержимое файла для Америки
                        string americaContent = File.ReadAllText(americaFilePath);

                        // Устанавливаем содержимое файла в текстовое поле textBoxResult
                        textBoxResult.Text = americaContent;
                    }
                }
                // если Китай
                else if (textBoxVvod.Text.Trim().Equals("Китай", StringComparison.OrdinalIgnoreCase))
                {
                    // Проверка файла
                    if ((File.Exists(ChinaFilePath)))
                    {
                        // Считываем содержимое файла для Китая
                        string ChinaContent = File.ReadAllText(ChinaFilePath);

                        // Устанавливаем содержимое файла в текстовое поле textBoxResult
                        textBoxResult.Text = ChinaContent;
                    }
                }
                // если Япония
                else if (textBoxVvod.Text.Trim().Equals("Япония", StringComparison.OrdinalIgnoreCase))
                {
                    // Проверка файла
                    if ((File.Exists(JapanesFilePath)))
                    {
                        // Считываем содержимое файла для Японии
                        string JapanesContent = File.ReadAllText(JapanesFilePath);

                        // Устанавливаем содержимое файла в текстовое поле textBoxResult
                        textBoxResult.Text = JapanesContent;
                    }
                }
                // если Англия
                else if (textBoxVvod.Text.Trim().Equals("Англия", StringComparison.OrdinalIgnoreCase))
                {
                    // Проверка файла
                    if ((File.Exists(EnglandFilePath)))
                    {
                        // Считываем содержимое файла для Англии
                        string EnglandContent = File.ReadAllText(EnglandFilePath);

                        // Устанавливаем содержимое файла в текстовое поле textBoxResult
                        textBoxResult.Text = EnglandContent;

                    }
                }
                else if (textBoxVvod.Text.Trim().Equals("Ватикан", StringComparison.OrdinalIgnoreCase))
                {
                    // Проверка файла
                    if ((File.Exists(VaticanFilePath)))
                    {
                        // Считываем содержимое файла для Ватикана
                        string VaticanContent = File.ReadAllText(VaticanFilePath);

                        // Устанавливаем содержимое файла в текстовое поле textBoxResult
                        textBoxResult.Text = VaticanContent;

                    }
                }
                else if (textBoxVvod.Text.Trim().Equals("Сербия", StringComparison.OrdinalIgnoreCase))
                {
                    // Проверка файла
                    if ((File.Exists(SerbiaFilePath)))
                    {
                        // Считываем содержимое файла для Ватикана
                        string SerbiaContent = File.ReadAllText(SerbiaFilePath);

                        // Устанавливаем содержимое файла в текстовое поле textBoxResult
                        textBoxResult.Text = SerbiaContent;

                    }
                }
                else
                {
                    // Если файл не найден, показываем сообщение об ошибке
                    MessageBox.Show($"Неправильное название или нет в списке внесенных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            { 
            }
        }

        private void textBoxVvod_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxdada_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonVopros_Click(object sender, EventArgs e)
        {
            // Список стран
            MessageBox.Show("Для ввода необходимо ввести страну, которая вас интересует. Список стран: Россия, США, Китай, Япония, Англия, Ватикан, Сербия. ", "Правила ввода", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelStrana_Click(object sender, EventArgs e)
        {
        }
    }
}
