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

        // ��������� ����������
        string openFilePath;
        private void button3_Click(object sender, EventArgs e)
        {
            // �������
            MessageBox.Show("�������� ������� �������� ����� ������� ������: �����-24-1", "�������", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // ��������� ���� � �����
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
                // ��������� ���������� ����� ����� ����� FileRead ������� DataService
                string fileContent = ds.FileRead(openFilePath);

                // ������������� ����� ����� � ��������� ���� textBoxResult
                textBoxResult.Text = fileContent;

                // ���������, ��� ������������ ���� "������" � ��������� ���� textBoxVvod
                if (textBoxVvod.Text.Trim().Equals("������", StringComparison.OrdinalIgnoreCase))
                {
                    // ���������, ���������� �� ���� � ������� ��� ������
                    if (File.Exists(ruFilePath))
                    {
                        // ��������� ���������� ����� ��� ������
                        string ruContent = File.ReadAllText(ruFilePath);

                        // ������������� ���������� ����� � ��������� ���� textBoxResult
                        textBoxResult.Text = ruContent;

                    }
                }
                // ���� �������
                else if (textBoxVvod.Text.Trim().Equals("���", StringComparison.OrdinalIgnoreCase))
                {
                    // �������� �����
                    if ((File.Exists(americaFilePath)))
                    {
                        // ��������� ���������� ����� ��� �������
                        string americaContent = File.ReadAllText(americaFilePath);

                        // ������������� ���������� ����� � ��������� ���� textBoxResult
                        textBoxResult.Text = americaContent;
                    }
                }
                // ���� �����
                else if (textBoxVvod.Text.Trim().Equals("�����", StringComparison.OrdinalIgnoreCase))
                {
                    // �������� �����
                    if ((File.Exists(ChinaFilePath)))
                    {
                        // ��������� ���������� ����� ��� �����
                        string ChinaContent = File.ReadAllText(ChinaFilePath);

                        // ������������� ���������� ����� � ��������� ���� textBoxResult
                        textBoxResult.Text = ChinaContent;
                    }
                }
                // ���� ������
                else if (textBoxVvod.Text.Trim().Equals("������", StringComparison.OrdinalIgnoreCase))
                {
                    // �������� �����
                    if ((File.Exists(JapanesFilePath)))
                    {
                        // ��������� ���������� ����� ��� ������
                        string JapanesContent = File.ReadAllText(JapanesFilePath);

                        // ������������� ���������� ����� � ��������� ���� textBoxResult
                        textBoxResult.Text = JapanesContent;
                    }
                }
                // ���� ������
                else if (textBoxVvod.Text.Trim().Equals("������", StringComparison.OrdinalIgnoreCase))
                {
                    // �������� �����
                    if ((File.Exists(EnglandFilePath)))
                    {
                        // ��������� ���������� ����� ��� ������
                        string EnglandContent = File.ReadAllText(EnglandFilePath);

                        // ������������� ���������� ����� � ��������� ���� textBoxResult
                        textBoxResult.Text = EnglandContent;

                    }
                }
                else if (textBoxVvod.Text.Trim().Equals("�������", StringComparison.OrdinalIgnoreCase))
                {
                    // �������� �����
                    if ((File.Exists(VaticanFilePath)))
                    {
                        // ��������� ���������� ����� ��� ��������
                        string VaticanContent = File.ReadAllText(VaticanFilePath);

                        // ������������� ���������� ����� � ��������� ���� textBoxResult
                        textBoxResult.Text = VaticanContent;

                    }
                }
                else if (textBoxVvod.Text.Trim().Equals("������", StringComparison.OrdinalIgnoreCase))
                {
                    // �������� �����
                    if ((File.Exists(SerbiaFilePath)))
                    {
                        // ��������� ���������� ����� ��� ��������
                        string SerbiaContent = File.ReadAllText(SerbiaFilePath);

                        // ������������� ���������� ����� � ��������� ���� textBoxResult
                        textBoxResult.Text = SerbiaContent;

                    }
                }
                else
                {
                    // ���� ���� �� ������, ���������� ��������� �� ������
                    MessageBox.Show($"������������ �������� ��� ��� � ������ ���������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // ������ �����
            MessageBox.Show("��� ����� ���������� ������ ������, ������� ��� ����������. ������ �����: ������, ���, �����, ������, ������, �������, ������. ", "������� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelStrana_Click(object sender, EventArgs e)
        {
        }
    }
}
