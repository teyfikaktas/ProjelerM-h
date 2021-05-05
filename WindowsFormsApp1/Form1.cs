using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        public double EntropiHesaplama(double yes, double no)
        {



            double Entropi1 = -(yes / (yes + no)) * Math.Log(yes / (yes + no), 2);
            double Entropi2 = -(no / (yes + no)) * Math.Log(no / (yes + no), 2);
            double Entropi = Entropi1 + Entropi2;


            return Entropi;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double Deneme1 = Convert.ToDouble(A.Text.ToString());
            double Deneme2 = Convert.ToDouble(B.Text.ToString());
            double Deneme3 = Convert.ToDouble(C.Text.ToString());
            double Deneme4 = Convert.ToDouble(D.Text.ToString());
            double Deneme5 = Convert.ToDouble(E.Text.ToString());
            double Deneme11 = Convert.ToDouble(A1.Text.ToString());
            double Deneme21 = Convert.ToDouble(B1.Text.ToString());
            double Deneme31 = Convert.ToDouble(C1.Text.ToString());
            double Deneme41 = Convert.ToDouble(D1.Text.ToString());
            double Deneme51 = Convert.ToDouble(E1.Text.ToString());

            double Entropi1 = EntropiHesaplama(Deneme1, Deneme11);
            double Entropi2 = EntropiHesaplama(Deneme2, Deneme21);
            double Entropi3 = EntropiHesaplama(Deneme3, Deneme31);
            double Entropi4 = EntropiHesaplama(Deneme4, Deneme41);
            double Entropi5 = EntropiHesaplama(Deneme5, Deneme51);

            double sonucentropisi =
                RasyonelSayilar(Convert.ToDouble(K1.Text.ToString()), Convert.ToDouble(K11.Text.ToString()), Entropi1)
         + RasyonelSayilar(Convert.ToDouble(K2.Text.ToString()), Convert.ToDouble(K12.Text.ToString()), Entropi2) +

            RasyonelSayilar(Convert.ToDouble(K3.Text.ToString()), Convert.ToDouble(K13.Text.ToString()), Entropi3)
            + RasyonelSayilar(Convert.ToDouble(K4.Text.ToString()), Convert.ToDouble(K14.Text.ToString()), Entropi4) +
            RasyonelSayilar(Convert.ToDouble(K5.Text.ToString()), Convert.ToDouble(K15.Text.ToString()), Entropi5);

            sonuc.Text = sonucentropisi.ToString();
            sonuc1.Text = sonucentropisi.ToString();

            /*

                            double Entropi1 = -(yes / (yes + no)) * Math.Log(yes / (yes + no), 2);
                            double Entropi2 = -(no / (yes + no)) * Math.Log(no / (yes + no), 2);
                            double Entropi = Entropi1 + Entropi2;

                */




        }
        public double RasyonelSayilar(double Pay, double Payda, double CarpilacakSayi)
        {
            return ((Pay * CarpilacakSayi) / Payda);
        }
        public double RasyonelSayilar(double Pay, double Payda)
        {
            return ((Pay / Payda));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double yes = Convert.ToDouble(OlumluHareket.Text);
            double no = Convert.ToDouble(OlumsuzHreket.Text);

            double Entropi1 = -(yes / (yes + no)) * Math.Log(yes / (yes + no), 2);
            double Entropi2 = -(no / (yes + no)) * Math.Log(no / (yes + no), 2);
            double Entropi = Entropi1 + Entropi2;

            SistemSonuc.Text = Entropi.ToString();
            sonucbox.Text = Entropi.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void OlumluHareket_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double sonuc11 = Convert.ToDouble(sonucbox.Text);
            double sonuc2 = Convert.ToDouble(sonuc1.Text);
            asilson.Text = (sonuc11 - sonuc2).ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Deneme1 = Convert.ToDouble(A.Text.ToString());
            double Deneme2 = Convert.ToDouble(B.Text.ToString());

            double Deneme11 = Convert.ToDouble(A1.Text.ToString());
            double Deneme21 = Convert.ToDouble(B1.Text.ToString());


            double Entropi1 = EntropiHesaplama(Deneme1, Deneme11);
            double Entropi2 = EntropiHesaplama(Deneme2, Deneme21);


            double sonucentropisi =
                RasyonelSayilar(Convert.ToDouble(K1.Text.ToString()), Convert.ToDouble(K11.Text.ToString()), Entropi1)
         + RasyonelSayilar(Convert.ToDouble(K2.Text.ToString()), Convert.ToDouble(K12.Text.ToString()), Entropi2);

            sonuc.Text = sonucentropisi.ToString();
            sonuc1.Text = sonucentropisi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double sonuc = 1 - ((Math.Pow((a / (a + b)),2)+ Math.Pow((b / (a + b)),2)));
            label19.Text = sonuc.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double tsol = Convert.ToDouble(textBox2.Text)  ;
            double tsag = Convert.ToDouble(textBox3.Text);
            double gini1 = Convert.ToDouble(textBox6.Text);
            double gini2 = Convert.ToDouble(textBox7.Text);
            double N = Convert.ToDouble(textBox1.Text);

            double sonuc2 = (((tsol * gini1) + (tsag * gini2)))/N;
            label20.Text = sonuc2.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(text1.Text);
            double a1 = Convert.ToDouble(text2.Text);
            double b = Convert.ToDouble(text3.Text);
            double b1 = Convert.ToDouble(text4.Text);
            double c = Convert.ToDouble(text5.Text);
            double c1 = Convert.ToDouble(text6.Text);
            double sonuc = (Math.Pow(a - a1, 2)) + (Math.Pow(b - b1, 2)) + (Math.Pow(c - c1, 2));
            label23.Text = sonuc.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Deneme1 = Convert.ToDouble(A.Text.ToString());
            double Deneme2 = Convert.ToDouble(B.Text.ToString());
            double Deneme3 = Convert.ToDouble(C.Text.ToString());
          
            double Deneme11 = Convert.ToDouble(A1.Text.ToString());
            double Deneme21 = Convert.ToDouble(B1.Text.ToString());
            double Deneme31 = Convert.ToDouble(C1.Text.ToString());


            double Entropi1 = EntropiHesaplama(Deneme1, Deneme11);
            double Entropi2 = EntropiHesaplama(Deneme2, Deneme21);
            double Entropi3 = EntropiHesaplama(Deneme3, Deneme31);


            double sonucentropisi =
                RasyonelSayilar(Convert.ToDouble(K1.Text.ToString()), Convert.ToDouble(K11.Text.ToString()), Entropi1)
         + RasyonelSayilar(Convert.ToDouble(K2.Text.ToString()), Convert.ToDouble(K12.Text.ToString()), Entropi2) +

            RasyonelSayilar(Convert.ToDouble(K3.Text.ToString()), Convert.ToDouble(K13.Text.ToString()), Entropi3)
           ;

            sonuc.Text = sonucentropisi.ToString();
            sonuc1.Text = sonucentropisi.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double Deneme1 = Convert.ToDouble(A.Text.ToString());
            double Deneme2 = Convert.ToDouble(B.Text.ToString());
            double Deneme3 = Convert.ToDouble(C.Text.ToString());
            double Deneme4 = Convert.ToDouble(D.Text.ToString());
    
            double Deneme11 = Convert.ToDouble(A1.Text.ToString());
            double Deneme21 = Convert.ToDouble(B1.Text.ToString());
            double Deneme31 = Convert.ToDouble(C1.Text.ToString());
            double Deneme41 = Convert.ToDouble(D1.Text.ToString());

            double Entropi1 = EntropiHesaplama(Deneme1, Deneme11);
            double Entropi2 = EntropiHesaplama(Deneme2, Deneme21);
            double Entropi3 = EntropiHesaplama(Deneme3, Deneme31);
            double Entropi4 = EntropiHesaplama(Deneme4, Deneme41);

            double sonucentropisi =
                RasyonelSayilar(Convert.ToDouble(K1.Text.ToString()), Convert.ToDouble(K11.Text.ToString()), Entropi1)
         + RasyonelSayilar(Convert.ToDouble(K2.Text.ToString()), Convert.ToDouble(K12.Text.ToString()), Entropi2) +

            RasyonelSayilar(Convert.ToDouble(K3.Text.ToString()), Convert.ToDouble(K13.Text.ToString()), Entropi3)
            + RasyonelSayilar(Convert.ToDouble(K4.Text.ToString()), Convert.ToDouble(K14.Text.ToString()), Entropi4);

            sonuc.Text = sonucentropisi.ToString();
            sonuc1.Text = sonucentropisi.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double Deneme1 = Convert.ToDouble(A.Text.ToString());
  
            double Deneme11 = Convert.ToDouble(A1.Text.ToString());
      

            double Entropi1 = EntropiHesaplama(Deneme1, Deneme11);


            double sonucentropisi =
                RasyonelSayilar(Convert.ToDouble(K1.Text.ToString()), Convert.ToDouble(K11.Text.ToString()), Entropi1)
         ;

            sonuc.Text = sonucentropisi.ToString();
            sonuc1.Text = sonucentropisi.ToString();
        }
    }
}
