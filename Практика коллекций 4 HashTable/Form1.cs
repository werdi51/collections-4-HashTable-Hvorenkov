using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Практика_коллекций_4_HashTable
{
    public partial class Form1 : Form
    {
        Hashtable collection = new Hashtable();
        int rez = 0;
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool test = int.TryParse(textBox1.Text, out rez);

            if (!test)
            {
                MessageBox.Show("Введите число");
            }
            else if (rez <= 0)
            {
                MessageBox.Show("число не может быть меньше 1");
            }
            else
            {
                panel2.Visible = true;
                panel1.Visible = false;
                int Counter = 1;
                while (true)
                {
                    if (rez == comboBox1.Items.Count)
                    {
                        break;
                    }
                    else
                    {
                        comboBox1.Items.Add("плейлист №" + Counter);
                        Disk PlayList = new Disk();
                        PlayList.NamePlaylist = "плейлист №" + Counter;

                        collection.Add(Counter, PlayList);

                        Counter++;
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("вы не выбрали плейлист");
            }
            else
            {
                panel3.Visible = true;
                panel2.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox3.Text != null)
            {
                int i = comboBox1.SelectedIndex;
                comboBox1.Items[i] = textBox3.Text;
                panel3.Visible = false;
                panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("введите название плейлиста");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали плейлист");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введите название песни");
            }
            else
            {
                int selected = comboBox1.SelectedIndex + 1;  
                Disk selectedDisk = (Disk)collection[selected];

                selectedDisk.Songs.Add(textBox2.Text);

                // Обновляем список песен
                UpdateSongsList(selectedDisk);

                textBox2.Clear(); 
            }
        }

        // обновления списка песен 
        private void UpdateSongsList(Disk disk)
        {
            listBox1.Items.Clear();
            foreach (string song in disk.Songs)
            {
                listBox1.Items.Add(song);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали плейлист");
            }
            else if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите песню для удаления");
            }
            else
            {
                int selected = comboBox1.SelectedIndex + 1;
                Disk selectedDisk = (Disk)collection[selected];

                // Удаля песню
                selectedDisk.Songs.RemoveAt(listBox1.SelectedIndex);

                // Обновляем список
                UpdateSongsList(selectedDisk);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                int selected = comboBox1.SelectedIndex + 1;
                Disk selectedDisk = (Disk)collection[selected];
                UpdateSongsList(selectedDisk);
            }
        }
    }
}
