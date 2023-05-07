using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Principal;

namespace WindowsFormsApp_21._04._2023_HM
{
    public partial class Form1 : Form
    {
        public SynchronizationContext context;
        string t1, t2, t3, t4, t5;

        public Form1()
        {
            InitializeComponent();
            context = SynchronizationContext.Current;
            t1= textBox1.Text;
            t2 = textBox2.Text;
            t3 = textBox3.Text;
            t4 = textBox4.Text;
            t5 = textBox5.Text;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    context.Send(d => listBox1.Items.Clear(), null);

                    List<Tuple<string, string, string, string>> myList = new List<Tuple<string, string, string, string>>();
                    myList.Add(Tuple.Create("Билал Наима Мажедовна","19.11.2003", "380933775600", "Филатова"));
                    myList.Add(Tuple.Create("Сидоров Артем Максимочвич", "03.01.1999", "380985239654", "Садовая"));
                    myList.Add(Tuple.Create("Осиков Владимир Ильич", "12.05.2000", "380967891134", "Королева"));
                    myList.Add(Tuple.Create("Шишкова Алена Владимировна", "17.05.2000", "380967893134", "Королева"));

                    foreach (var i in myList)
                    {
                        if (textBox1.Text == i.Item4)
                        {
                            listBox1.Items.Add(i.Item1);
                            listBox1.Items.Add(i.Item2);
                            listBox1.Items.Add(i.Item3);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    context.Send(d => listBox1.Items.Clear(), null);

                    List<Tuple<string, string, string>> mylist1 = new List<Tuple<string, string, string>>();
                    mylist1.Add(Tuple.Create("Билал Наима Мажедовна", "2003", "Одесса"));
                    mylist1.Add(Tuple.Create("Сидоров Артем Максимочвич", "1999", "Одесса"));
                    mylist1.Add(Tuple.Create("Осиков Владимир Ильич", "1901", "Николаев"));
                    mylist1.Add(Tuple.Create("Шишкова Алена Владимировна", "1901", "Харьков"));

                    foreach (var i in mylist1)
                    {
                        if (textBox2.Text == i.Item2)
                        {
                            listBox1.Items.Add(i.Item1);
                            listBox1.Items.Add(i.Item2);
                            listBox1.Items.Add(i.Item3);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    context.Send(d => listBox1.Items.Clear(), null);

                    List<Tuple<string, string, string>> myList2 = new List<Tuple<string, string, string>>();
                    myList2.Add(Tuple.Create("Билал Наима Мажедовна", "212", "10"));
                    myList2.Add(Tuple.Create("Сидоров Артем Максимочвич", "213", "9"));
                    myList2.Add(Tuple.Create("Осиков Владимир Ильич", "211", "12"));
                    myList2.Add(Tuple.Create("Шишкова Алена Владимировна", "212", "12"));

                    foreach (var i in myList2)
                    {
                        if (textBox3.Text == i.Item3)
                        {
                            listBox1.Items.Add(i.Item1);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            });
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    context.Send(d => listBox1.Items.Clear(), null);

                    List<Tuple<string,string, string, string>> list = new List<Tuple<string, string, string, string>>();
                    list.Add(Tuple.Create("Дневник памяти", "Остин", "19", "25"));
                    list.Add(Tuple.Create("Оно", "Кинг", "19", "19"));

                    foreach (var i in list)
                    {
                        if (textBox4.Text == i.Item4&&i.Item3!=i.Item4)
                        {
                            listBox1.Items.Add(i.Item1);
                            listBox1.Items.Add(i.Item2);
                            listBox1.Items.Add(i.Item3);
                            listBox1.Items.Add(i.Item4);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    context.Send(d => listBox1.Items.Clear(), null);

                    List<Tuple<string, string, string>> list = new List<Tuple<string, string,string>>();
                    list.Add(Tuple.Create("Мясные", "11", "11"));
                    list.Add(Tuple.Create("Молочные", "11", "10"));
                    list.Add(Tuple.Create("Сладости", "11", "11"));
                    list.Add(Tuple.Create("Овощи и фрукты", "11", "09"));

                    foreach (var i in list)
                    {
                        if (textBox5.Text == i.Item2&&i.Item2!=i.Item3)
                        {
                            listBox1.Items.Add(i.Item1);
                            listBox1.Items.Add(i.Item2);
                            listBox1.Items.Add(i.Item3);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}
