using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public int lol = 7;
        int j = 0;
        int[] hubr = new int[7];
        string[] st = new string[7];
        struct Zakzhic
        {
            
            public string NumberZakaza;
            public string NameClient;
            public int typePhoto;
            public int sizePhoto;
            public int numberPhoto;
            public int urgencyPhoto;
            public int ab;
            public int PriceFoto()
            {
                int a = typePhoto + sizePhoto + urgencyPhoto;
                return a;
            }
            public int PriceZakaza()
            {
                int a = PriceFoto() * numberPhoto;
                return a;
            }
        };        
        
        Zakzhic[] zak = new Zakzhic[7];
        StreamReader readfl;
        StreamWriter writefl;

        public Form1()
        {       
            
            InitializeComponent();
            labelNom.Text = j.ToString();
            CloseList();

        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            input();
        }
        private void input()
        {
            CloseLast();
            if (radioButtonSize1.Checked != false || radioButtonSize2.Checked != false || radioButtonSize3.Checked != false
                    || radioButtonVid1.Checked != false || radioButtonVid1.Checked != false)
            {
                if (numericFoto.Value != 0)
                {

                    zak[j].NameClient = textBoxName.Text.ToString();
                    zak[j].NumberZakaza = textBoxNumber.Text.ToString();
                    zak[j].numberPhoto = int.Parse(numericFoto.Value.ToString());
                    if (checkBox.Checked == true) zak[j].urgencyPhoto = 1;
                    if (radioButtonSize1.Checked == true) zak[j].sizePhoto = 10;
                    if (radioButtonSize2.Checked == true) zak[j].sizePhoto = 20;
                    if (radioButtonSize3.Checked == true) zak[j].sizePhoto = 30;
                    if (radioButtonVid1.Checked == true) zak[j].typePhoto = 5;
                    if (radioButtonVid2.Checked == true) zak[j].typePhoto = 3;
                    zak[j].ab = zak[j].PriceZakaza();
                    //string Vivod = "Номер заказа № " + zak[j].NumberZakaza + " Заказчик: " + zak[j].NameClient + " Стоимость: " + a + " руб. " + j;
                    //MessageBox.Show(Vivod);

                }
                else
                {
                    MessageBox.Show("Не указанно количество книг!");
                    CloseList();
                }
            }
            else
            {
                MessageBox.Show("Выберите размер фото или вид упаковки!");
                CloseList();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            CloseList();
        }       
        private void CloseList()
        {
            if (j < lol)
            {
                radioButtonSize1.Checked = false;
                radioButtonSize2.Checked = false;
                radioButtonSize3.Checked = false;
                radioButtonVid1.Checked = false;
                radioButtonVid2.Checked = false;
                checkBox.Checked = false;
                numericFoto.Value = 0;
                textBoxName.Text = "";
                textBoxNumber.Text = "";
                zak[j].NameClient = null;
                zak[j].NumberZakaza = null;
            }
        }
        private void CloseLast()
        {
            zak[j].urgencyPhoto = 0;
            zak[j].sizePhoto = 0;
            zak[j].typePhoto = 0;
            zak[j].NumberZakaza = null;
            zak[j].NameClient = null;
            zak[j].ab = 0;
        }
        private void fors()
        {
            if (j < lol)
                j++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fors();
            CloseList();
            labelNom.Text = j.ToString();
        }

        private void buttonMasiv_Click(object sender, EventArgs e)
        {
            string viv = null;
            for (int a=0;a<lol; a++)
            {
                viv+= "Номер заказа № " + zak[a].NumberZakaza + " Заказчик: " + zak[a].NameClient + " Стоимость: " + zak[a].ab + " руб.                                       " ;
            }
            MessageBox.Show(viv);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            int min = 0;
            int num = 0;
            int max = 1000;
            for (int h = 0; h < lol; h++)
            {

                if (h + 1 == lol)
                {
                    for (int j = 0; j < lol; j++)
                    {
                        if (zak[j].ab < max)
                            hubr[h] = j;
                        else hubr[h] = 0;
                    }
                }
                else
                {
                    for (int j = 0; j < lol; j++)
                    {

                        if (zak[j].ab >= min && zak[j].ab < max)
                        {
                            min = zak[j].ab;
                            num = j;
                        }
                    }
                    min = 0;
                    max = zak[num].ab;
                    hubr[h] = num;
                }
            }
            string viv = null;
            for (int a = 0; a < lol; a++)
            {
                viv += "Номер заказа № " + zak[hubr[a]].NumberZakaza + " Заказчик: " + zak[hubr[a]].NameClient + " Стоимость: " + zak[hubr[a]].ab + " руб.                                       ";
            }
            MessageBox.Show(viv);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int min = 0;
            int num = 0;
            int max = 100000;
            for (int h = 0; h < lol; h++)
            {

                if (h + 1 == lol)
                {
                    for (int j = 0; j < lol; j++)
                    {
                        if (int.Parse(zak[j].NumberZakaza) < max)
                            hubr[h] = j;
                        
                    }
                }
                else
                {
                    for (int j = 0; j < lol; j++)
                    {

                        if (int.Parse(zak[j].NumberZakaza) >= min && int.Parse(zak[j].NumberZakaza) < max)
                        {
                            min = int.Parse(zak[j].NumberZakaza);
                            num = j;
                        }
                    }
                    min = 0;
                    max = int.Parse(zak[num].NumberZakaza);
                    hubr[h] = num;
                }
            }
            string viv = null;
            for (int a = 0; a < lol; a++)
            {
                viv += "Номер заказа № " + zak[hubr[a]].NumberZakaza + " Заказчик: " + zak[hubr[a]].NameClient + " Стоимость: " + zak[hubr[a]].ab + " руб.                                       ";
            }
            MessageBox.Show(viv);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            StreamWriter sw = new StreamWriter("Test.txt");

            for (int a = 0; a < lol; a++)
            {
                string viv = "Номер заказа № " + zak[a].NumberZakaza + " Заказчик: " + zak[a].NameClient + " Стоимость: " + zak[a].ab + " руб.";
                st[a] = viv;
            }
                foreach (var node in st)
                {
                    
                    sw.WriteLine(node + Environment.NewLine);
                    //sw.Close();
                }
            
            sw.Close();

            Console.ReadLine();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int k = 0;
            string kok = null;
            string dop = null;
            for (int j = 0; j < lol; j++)
            {
                if (zak[j].ab >= numericUpDown1.Value)
                    k++;
            }
            int[] nev = new int[k];
            string [] vivod = new string[k];
            int i = 0;
            for (int j=0;j<lol;j++)
            {
                if (zak[j].ab >= numericUpDown1.Value)
                    dop += "Номер заказа № " + zak[j].NumberZakaza + " Заказчик: " + zak[j].NameClient + " Стоимость: " + zak[j].ab + " руб.                                       ";
            }
            MessageBox.Show(dop);
           

        }


        private void button6_Click(object sender, EventArgs e)
        {
            int k = 0;
            string kok = null;
            string dop = null;
            for (int j = 0; j < lol; j++)
            {
                if (zak[j].numberPhoto >= numericUpDown2.Value)
                    k++;
            }
            int[] nev = new int[k];
            string[] vivod = new string[k];
            int i = 0;
            for (int j = 0; j < lol; j++)
            {
                if (zak[j].numberPhoto >= numericUpDown2.Value)
                    dop += "Номер заказа № " + zak[j].NumberZakaza + " Заказчик: " + zak[j].NameClient + " Стоимость: " + zak[j].ab + " руб.                                       ";
            }
            MessageBox.Show(dop);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int j = 0;
            string str;
            if (File.Exists("данные.txt"))
                readfl = new StreamReader("данные.txt");
            else
            {
                MessageBox.Show("Такого файла нет");
                return;
            }
            while (readfl.EndOfStream == false )
            {
                str = readfl.ReadLine();
                string[] s = str.Split(';');

                zak[j].NumberZakaza = s[0];
                zak[j].NameClient = s[1];
                zak[j].ab = Convert.ToInt32(s[2]);
                j++;
            }
            readfl.Close();
            //print();

            string viv = null;
            for (int a = 0; a < j; a++)
            {
                viv += "Номер заказа № " + zak[a].NumberZakaza + " Заказчик: " + zak[a].NameClient + " Стоимость: " + zak[a].ab + " руб.                                       ";
            }
            MessageBox.Show(viv);
        }
    }
}
