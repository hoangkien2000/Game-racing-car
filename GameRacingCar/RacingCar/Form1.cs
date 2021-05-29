using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            linemove(carspeed);
            gameover();
            totalsocre();   
        }

        Random pos = new Random();
        void linemove(int speed)
        {
            if (pictureBox1.Top > 500) pictureBox1.Top = 0;
            else pictureBox1.Top += speed;
            if (pictureBox2.Top > 500) pictureBox2.Top = 0;
            else pictureBox2.Top += speed;
            if (pictureBox3.Top > 500) pictureBox3.Top = 0;
            else pictureBox3.Top += speed;
            if (moto1.Top > 500)
            {
                score++;
                moto1.Left = pos.Next(0, 200);
                moto1.Top = pos.Next(0, 40);
                moto1.Top = 0;
            }
            else moto1.Top += speed;
            if (moto2.Top > 500)
            {
                score++;
                moto2.Left = pos.Next(0, 200);
                moto2.Top = pos.Next(0, 40);
                moto2.Top = 0;
            }
            else moto2.Top += speed;
            if (moto3.Top > 500)
            {
                score++;
                moto3.Left = pos.Next(250, 400);
                moto3.Top = pos.Next(0, 40);

                moto3.Top = 0;
            }
            else moto3.Top += speed;
            if (moto4.Top > 500)
            {
                score++;    
                moto4.Left = pos.Next(250, 400);
                moto4.Top = pos.Next(0, 40);
                moto4.Top = 0;
            }
            else moto4.Top += speed;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        int carspeed = 2;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && mycar.Left>0) mycar.Left -= 5;
            if (e.KeyCode == Keys.Right && mycar.Left < 400) mycar.Left += 5;
            if (e.KeyCode == Keys.Up && carspeed < 30) carspeed++;
            if (e.KeyCode == Keys.Down && carspeed >2) carspeed--;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int score;
        void totalsocre()
        {
            textBox1.Text = score.ToString(); 
        }
        void gameover()
        {
            if(mycar.Bounds.IntersectsWith(moto1.Bounds) || mycar.Bounds.IntersectsWith(moto2.Bounds)|| mycar.Bounds.IntersectsWith(moto3.Bounds)|| mycar.Bounds.IntersectsWith(moto4.Bounds))
            {
                timer1.Enabled = false;
                DialogResult go = MessageBox.Show("Do you want play again ? ", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                switch(go)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        timer1.Enabled = true;
                        score = 0;
                        moto1.Left = pos.Next(0, 200);
                        moto1.Top = 0;
                        moto2.Left = pos.Next(0, 200);
                        moto2.Top = 0;
                        moto3.Left = pos.Next(250, 390);
                        moto3.Top = 0;
                        moto4.Left = pos.Next(250, 390);
                        moto4.Top = 0;
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        Home a = new Home();
                        a.Show();
                        this.Visible = false;
                        break;

                }
              
            }

        }

        private void moto4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
