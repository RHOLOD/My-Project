using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace task5
{
    public partial class Form1 : Form
    {
        struct Zakzhic
        {

            public string NumberZakaza;
            public string NameClient;
            public string typePhoto;
            public string sizePhoto;
            public string urgencyPhoto;
            public int numberPhoto;            
            public int PriceOneFoto()
            {
                int b = 0;
                int c = 0;
                int g = 0;
                if (typePhoto == "пленка") b = 5;
                if (typePhoto == "файл") b = 3;
                if (sizePhoto == "15 X 15") c = 10;
                if (sizePhoto == "20 X 35") c = 20;
                if (sizePhoto == "50 X 40") c = 30;
                if (urgencyPhoto == "да") g = 1;
                int a = b + c +g;
                return a;
            }
            public int PriceZakaza()
            {
                int a = PriceOneFoto() * numberPhoto;
                return a;
            }
        };
        List<Zakzhic> spisok = new List<Zakzhic>();
        StreamReader readfl;
        StreamWriter writefl;        
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//чтение файла
        {
            spisok.Clear();
            dataGridView1.Rows.Clear();
            string str;
            if (File.Exists("данные.txt"))
                readfl = new StreamReader("данные.txt");
            else
            {
                MessageBox.Show("Такого файла нет");
                return;
            }
            while (readfl.EndOfStream == false)
            {
                Zakzhic note;
                str = readfl.ReadLine();
                string[] s = str.Split(';');
                note.NumberZakaza = s[0];
                note.NameClient = s[1];
                note.typePhoto = s[2];
                note.sizePhoto = s[3];
                note.urgencyPhoto = s[4];
                note.numberPhoto = Convert.ToInt32(s[5]);
                spisok.Add(note);
            }
            readfl.Close();
            dataGridView1.Rows.Clear();
            foreach (var t in spisok)
                dataGridView1.Rows.Add(t.NumberZakaza,t.NameClient,t.typePhoto,t.sizePhoto, t.urgencyPhoto,t.numberPhoto, t.PriceOneFoto(),t.PriceZakaza());
            //DataTime();
        }          
        private void button2_Click(object sender, EventArgs e)//сохранение файла
        {
            string result;

            writefl = File.CreateText("date.txt");
            result = string.Format("{0,5}{1,16}{2,13}{3,10}{4,12}{5,8}{6,15}{7,15}", "№", "Заказчик",
                                             "тип фото", "размер фото", "срочность","количество","за 1 фото","стоимость");
            writefl.WriteLine(result);
            for (int k = 0; k < dataGridView1.Rows.Count - 1; k++)
            {
                result = string.Format("{0,5}{1,16}{2,13}{3,10}{4,12}{5,8}{6,15}{7,15}",
                                dataGridView1.Rows[k].Cells[0].Value+"|",
                                dataGridView1.Rows[k].Cells[1].Value + "|",
                                dataGridView1.Rows[k].Cells[2].Value + "|",
                                dataGridView1.Rows[k].Cells[3].Value + "|",
                                dataGridView1.Rows[k].Cells[4].Value + "|",
                                dataGridView1.Rows[k].Cells[5].Value + "|",
                                dataGridView1.Rows[k].Cells[6].Value + "|",
                                dataGridView1.Rows[k].Cells[7].Value + "|");
            writefl.WriteLine(result);
            }
            writefl.Close();
        }
        private void button3_Click(object sender, EventArgs e)//отбор файла
        {
            int tx = Convert.ToInt32(textBox1.Text);
            var otbor = from x in spisok
                        where x.PriceZakaza() > tx
                        select x;
            dataGridView1.Rows.Clear();
            foreach (var t in otbor)
                dataGridView1.Rows.Add(t.NumberZakaza, t.NameClient, t.typePhoto, t.sizePhoto, t.urgencyPhoto, t.numberPhoto, t.PriceOneFoto(), t.PriceZakaza());
            //DataTime();
        }
        private void button4_Click(object sender, EventArgs e) //сортивровка
        {

            var sort = from x in spisok orderby x.NameClient ascending select x;
            dataGridView1.Rows.Clear();
            foreach (var t in sort)
                dataGridView1.Rows.Add(t.NumberZakaza, t.NameClient, t.typePhoto, t.sizePhoto, t.urgencyPhoto, t.numberPhoto, t.PriceOneFoto(), t.PriceZakaza());

        }
        public void DataTime()
        {
            string s = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");
            dataGridView1.Rows.Add("Дата просмотра:");
            dataGridView1.Rows.Add(s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tx = textBox2.Text;
            var otbor = from x in spisok
                        where x.NameClient == tx
                        select x;
            dataGridView1.Rows.Clear();
            foreach (var t in otbor)
                dataGridView1.Rows.Add(t.NumberZakaza, t.NameClient, t.typePhoto, t.sizePhoto, t.urgencyPhoto, t.numberPhoto, t.PriceOneFoto(), t.PriceZakaza());

        }
    }
}
