using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaMemo
{
public partial class Form1 : Form
{
    int timeLeft;

public Form1()
{
InitializeComponent();
}
    byte wtf = 0;
    PictureBox wtf1;
    byte uee = 6;

    void SEILA()
    {
        foreach (Control x in this.Controls)
    {
        if (x is PictureBox)
    {
    (x as PictureBox).Image = Properties.Resources._0;
    }
    }
    }
        void oi()
    {
         foreach (Control x in this.Controls)
    {
        if (x is PictureBox)
    {
    (x as PictureBox).Tag = "0";
    }
    }
    }
        void hue()
    {
        int[] nn = new int [12];
            Random ss = new Random();

            byte i = 0;
                while (i<12)

    {
        int s = ss.Next(1, 13);
        if (Array.IndexOf(nn, s) == -1)
    {
    nn[i] = s;
    i++;
    }
    }
        for(byte a = 0; a < 12; a++)
    {
        if (nn[a] > 6) nn[a] -= 6;
    }
        byte b = 0;
            foreach (Control x in this.Controls)
    {
        if (x is PictureBox)
    {
    x.Tag = nn[b].ToString();
    b++;
    }
    }
    }
        void meudeus(PictureBox br, PictureBox br1)
    {
        if (br.Tag.ToString() == br1.Tag.ToString())
    {

    Application.DoEvents();
   
    System.Threading.Thread.Sleep(500);
    br.Visible = false;
    br1.Visible = false;
    uee--;
    if (uee == 0)
    {
        SEILA();
        oi();
        hue();
       
        timer1.Stop();
        left.Text = "Concluido";
        MessageBox.Show("Parabéns você terminou o jogo! Clique em jogar para uma nova partida.","PARABÉNS");





    }
        else
        left.Text = "Faltam: " + uee;

    
    }
        else
    {
    Application.DoEvents();
    System.Threading.Thread.Sleep(500);
    br.Image = Image.FromFile("0.png");
    br1.Image = Image.FromFile("0.png");
    
    }
    }
        private void Form1_Load(object sender, EventArgs e)
    {
        this.Text = "Jogo da memória - MARVEL";
            SEILA();
            oi();
            hue();
    
    
    }

        private void pictureBox1_Click(object sender, EventArgs e)
    {
    PictureBox hello = (sender as PictureBox);
    hello.Image = Image.FromFile((sender as PictureBox).Tag.ToString() + ".png");
        if (wtf == 0)
    {
    wtf1 = hello;
    wtf++;
    }
        else {
            if(wtf1 == hello)
    {
    MessageBox.Show("Selecione outra carta.", "Cuidado!");
    wtf = 0;
    wtf1.Image = Image.FromFile("0.png");

    }
        else
    {
    meudeus(wtf1, hello);
    wtf = 0;
    }
    }
    }
        void memorizar()
    {
        foreach (Control x in this.Controls)
    {
        if (x is PictureBox)
    {
    (x as PictureBox).Image = Image.FromFile(x.Tag.ToString() + ".png");
    }
    }
    }
        void memorizardois()
    {
        foreach (Control x in this.Controls)
    {
        if (x is PictureBox)
    {
    (x as PictureBox).Image = Image.FromFile("0.png");
    }
    }
    }
        private void button1_Click(object sender, EventArgs e)
    {
        
    
    memorizar();
    Application.DoEvents(); 
    System.Threading.Thread.Sleep(500);
    memorizardois();
    wtf = 0;

    button1.BackgroundImage = Image.FromFile("7.png");





    button1.Enabled = false;
    

    }

        void visibilidade()
    {
        foreach (Control x in this.Controls)
    {
        if (x is PictureBox)
    {
    (x as PictureBox).Visible = true;
    }
    }
    }
        private void button2_Click(object sender, EventArgs e)
    {
   
    button2.Visible = true;
    SEILA();
    oi();
    hue();
    visibilidade();
    uee = 6;
    wtf = 0;
    

    
    button1.Enabled = true;
    
    pictureBox1.Enabled = true;
    pictureBox2.Enabled = true;
    pictureBox3.Enabled = true;
    pictureBox4.Enabled = true;
    pictureBox5.Enabled = true;
    pictureBox6.Enabled = true;
    pictureBox7.Enabled = true;
    pictureBox8.Enabled = true;
    pictureBox9.Enabled = true;
    pictureBox10.Enabled = true;
    pictureBox11.Enabled = true;
    pictureBox12.Enabled = true;

    timeLeft = 15;
    timeLabel.Text = "15 Segundos";
    timer1.Start();
    button1.Visible = true;

    left.Text = "Faltam: 6";
    button1.BackgroundImage = Image.FromFile("tony.png");
    
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        if (timeLeft > 0)
        {
            timeLeft = timeLeft - 1;
            timeLabel.Text = timeLeft + " Segundos";
        }
        else
        {
            timer1.Stop();
            timeLabel.Text = "Esgotado";
            MessageBox.Show("Você não terminou a tempo, clique em jogar novamente.", "TEMPO ESGOTADO");
            button2.Enabled = true;
            button1.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;


        }
    }

        private void left_Click(object sender, EventArgs e)
    {

    }

  

}
}
