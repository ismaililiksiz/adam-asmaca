using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adam_asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sehirler[0] = "İSTANBUL";
            sehirler[1] = "HAKKARİ";
            sehirler[2] = "MUĞLA";
            sehirler[3] = "MARDİN";
            sehirler[4] = "SİVAS";
            sehirler[5] = "ANKARA";
            sehirler[6] = "ANTALYA";
            sehirler[7] = "İZMİR";
            sehirler[8] = "SAMSUN";
            sehirler[9] = "TRABZON";
            
        }
        char[] alfabe = new char[29];
        string[] sehirler = new string[10];
        int sehir_uzunlugu;
        string sehir;
        bool oyunbasladi = false;

        private void button1_Click(object sender, EventArgs e)
        {

            if (oyunbasladi == true)
            {
                Application.Exit();
            }
            else
            {
                oyunbasladi = true;
                Random rastgele = new Random();
                int rastgelesehir = rastgele.Next(0, sehirler.Length);
                char[] alfabe = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ".ToCharArray();
                sehir = sehirler[rastgelesehir];


                for (int i = 0; i < alfabe.Length; i++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + alfabe[i].ToString();
                    btn.Text = alfabe[i].ToString();
                    btn.Width = 32;
                    btn.Height = 32;
                    flowLayoutPanel1.Controls.Add(btn);
                //    btn.Click += new EventHandler(btn_Click);
                    Controls.Add(btn);
                }
                sehir_uzunlugu = sehir.Length;
                for (int i = 0; i < sehir.Length; i++)
                {
                    TextBox txt = new TextBox();
                    txt.Name = "txt" + alfabe[i].ToString();
                    txt.Width = 32;
                    txt.Height = 32;
                    flowLayoutPanel2.Controls.Add(txt);
                }
               // private void btn_Click(object sender, EventArgs e)
               // {
               //     MessageBox.Show("Test");
               // }








            }
        }
    }
}
