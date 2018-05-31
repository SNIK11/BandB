using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        double x1, x2, y1, y2;
        double angle, speed1, speed2;
        int score = 0;

        private void t4_Tick(object sender, EventArgs e)
        {
            this.Text = score.ToString();
            value1 = rnd.Next(0, 254);
            value2 = rnd.Next(0, 254);
            value3 = rnd.Next(0, 254);
            o1.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
            o2.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
            o3.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
            o4.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
            o5.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
            o6.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
            if (score == 20)
            {
                t4.Enabled = false;
                MessageBox.Show("Вы победили!!!");
                this.Close();
                
            }
        }

        Random rnd = new Random();
        int value1, value2, value3,valueo1,valueo2, valueo3, valueo4, valueo5, valueo6;

        private void t3_Tick(object sender, EventArgs e)
        {
            
            if ((z.Top > 620) && (z.Top < 650))
            {
                valueo1 = rnd.Next(2, 1000);
                valueo2 = rnd.Next(2, 1000);
                valueo3 = rnd.Next(2, 1000);
                valueo4 = rnd.Next(2, 1000);
                valueo5 = rnd.Next(2, 1000);
                valueo6 = rnd.Next(2, 1000);
                t3.Enabled = false;
            }
        }


        Button o1 = new Button();
        Button o2 = new Button();
        Button o3 = new Button();
        Button o4 = new Button();
        Button o5 = new Button();
        Button o6 = new Button();
        private void t1_Tick(object sender, EventArgs e)
        {
            value1 = rnd.Next(0, 254);
            value2 = rnd.Next(0, 254);
            value3 = rnd.Next(0, 254);
            y1 -= speed1 * Math.Cos(angle);
                z.Top = (int)y1;
            if ((z.Top > 620) && (z.Top < 650))
            {
                if ((valueo1 % 10 == 0)|| (valueo1 % 10 == 1) || (valueo1 % 10 == 2) || (valueo1 % 10 == 3))
                {
                   
                    o1.Location = new System.Drawing.Point(10, 10);
                    o1.Size = new Size(90, 90);
                    o1.Visible = true;
                    o1.Enabled = false;
                    Controls.Add(o1);
                }
                if ((valueo2 % 10 == 8) || (valueo2 % 10 == 1) || (valueo2 % 10 == 2) || (valueo2 % 10 == 3))
                {
                   
                    o2.Location = new System.Drawing.Point(105, 10);
                    o2.Size = new Size(90, 90);
                    o2.Visible = true;
                    o2.Enabled = false;
                    Controls.Add(o2);
                }
                if ((valueo3 % 10 == 5) || (valueo3 % 10 == 1) || (valueo3 % 10 == 2) || (valueo3 % 10 == 3))
                {
                    
                    o3.Location = new System.Drawing.Point(200, 10);
                    o3.Size = new Size(90, 90);
                    o3.Visible = true;
                    o3.Enabled = false;
                    Controls.Add(o3);
                }
                if ((valueo4 % 10 == 7) || (valueo4 % 10 == 1) || (valueo4 % 10 == 4) || (valueo4 % 10 == 3))
                {
                   
                    o4.Location = new System.Drawing.Point(295, 10);
                    o4.Size = new Size(90, 90);
                    o4.Visible = true;
                    o4.Enabled = false;
                    Controls.Add(o4);
                }
                if ((valueo5 % 10 == 0) || (valueo5 % 10 == 1) || (valueo5 % 10 == 2) || (valueo5 % 10 == 3))
                {
                    
                    o5.Location = new System.Drawing.Point(390, 10);
                    o5.Size = new Size(90, 90);
                    o5.Visible = true;
                    o5.Enabled = false;
                    Controls.Add(o5);
                }
                if ((valueo6 % 10 == 0) || (valueo6 % 10 == 1) || (valueo6 % 10 == 2) || (valueo6 % 10 == 3))
                {
                   
                    o6.Location = new System.Drawing.Point(485, 10);
                    o6.Size = new Size(90, 90);
                    o6.Visible = true;
                    o6.Enabled = false;
                    Controls.Add(o6);
                }
            }
            if ((z.Top < 15 + o1.Height) && (z.Left > 10) && (z.Left < 100))
            {
                speed1 = -1 * speed1;
                o1.Width = 0;
                o1.Height = 0;
                score++;
            }
            if ((z.Top < 15 + o2.Height) && (z.Left > 100) && (z.Left < 195))
            {
                speed1 = -1 * speed1;
                o2.Width = 0;
                o2.Height = 0;
                score++;
            }
            if ((z.Top < 15 + o3.Height) && (z.Left > 195) && (z.Left < 290))
            {
                speed1 = -1 * speed1;
                o3.Width = 0;
                o3.Height = 0;
                score++;
            }
            if ((z.Top < 15 + o4.Height) && (z.Left > 290) && (z.Left < 385))
            {
                speed1 = -1 * speed1;
                o4.Width = 0;
                o4.Height = 0;
                score++;
            }
            if ((z.Top < 15 + o5.Height) && (z.Left > 385) && (z.Left < 480))
            {
                speed1 = -1 * speed1;
                o5.Width = 0;
                o5.Height = 0;
                score++;
            }
            if ((z.Top < 15 + o6.Height) && (z.Left > 480) && (z.Left < 590))
            {
                speed1 = -1 * speed1;
                o6.Width = 0;
                o6.Height = 0;
                score++;
            }



            

            if (z.Top < 10)
            {
                speed1 = -1 * speed1;
            }
            if ((z.Top > 620) && (z.Top < 650))
                {
                    speed1 = 0;
                    speed2 = 0;
                t1.Enabled = false;
                t2.Enabled = false;
                t3.Enabled = true;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void t2_Tick_1(object sender, EventArgs e)
        {
            x1 -= speed2 * Math.Sin(angle);
            z.Left = (int)x1;
            if ((z.Top < 12 + o1.Height) && (((z.Left > 10) && (z.Left < 15)) || ((z.Left > 100) && (z.Left < 103))))
            {
                speed2 = -1 * speed2;
                o1.Width = 0;
                o1.Height = 0;
                score++;
            }

            if ((z.Top < 12 + o2.Height) && (((z.Left > 103) && (z.Left < 110)) || ((z.Left > 285) && (z.Left < 193))))
            {
                speed2 = -1 * speed2;
                o2.Width = 0;
                o2.Height = 0;
                score++;
            }

            if ((z.Top < 12 + o3.Height) && (((z.Left > 193) && (z.Left < 200)) || ((z.Left > 285) && (z.Left < 293))))
            {
                speed2 = -1 * speed2;
                o3.Width = 0;
                o3.Height = 0;
                score++;
            }

            if ((z.Top < 12 + o4.Height) && (((z.Left > 293) && (z.Left < 300)) || ((z.Left > 385) && (z.Left < 393))))
            {
                speed2 = -1 * speed2;
                o4.Width = 0;
                o4.Height = 0;
                score++;
            }
            if ((z.Top < 12 + o5.Height) && (((z.Left > 393) && (z.Left < 400)) || ((z.Left > 485) && (z.Left < 493))))
            {
                speed2 = -1 * speed2;
                o5.Width = 0;
                o5.Height = 0;
                score++;
            }
            if ((z.Top < 12 + o6.Height) && (((z.Left > 493) && (z.Left < 500)) || ((z.Left > 585) && (z.Left < 593))))
            {
                speed2 = -1 * speed2;
                o6.Width = 0;
                o6.Height = 0;
                score++;
            }
            if (((z.Left > 0) && (z.Left < 10)) || ((z.Left > 550) && (z.Left < 560)))
            {
                speed2 = -1 * speed2;
            }
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if ((z.Top > 620) && (z.Top < 650))
            {
                x1 = z.Left;
                y1 = z.Top;
                x2 = e.X;
                y2 = e.Y;
                speed1 = 8;
                speed2 = 8;
                angle = GetAngle();
                


                if ((y2 > 0) && (y2 < 700) && (x2 > 0) && (x2 < 600))
                {
                    t1.Enabled = true;
                    t2.Enabled = true;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            angle = 0;
        }
        double GetAngle()
            {
            return Math.Atan2((x1 - x2), (y1 - y2));
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            z.Top = 621;
            z.Left = 280;
            this.Width = 600;
            this.Height = 700;
            this.BackColor = Color.Black;
            this.Top = 10;
            this.Left = 350;
            MessageBox.Show("Кликните мышкой по форме для запуска");
            if ((valueo1 % 10 == 0) || (valueo1 % 10 == 1) || (valueo1 % 10 == 2) || (valueo1 % 10 == 3))
            {

                o1.Location = new System.Drawing.Point(10, 10);
                o1.Size = new Size(90, 90);
                o1.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
                o1.Visible = true;
                o1.Enabled = false;
                Controls.Add(o1);
                valueo1 = rnd.Next(1, 10000);
            }
            if ((valueo2 % 10 == 8) || (valueo2 % 10 == 1) || (valueo2 % 10 == 2) || (valueo2 % 10 == 3))
            {

                o2.Location = new System.Drawing.Point(105, 10);
                o2.Size = new Size(90, 90);
                o2.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
                o2.Visible = true;
                o2.Enabled = false;
                Controls.Add(o2);
                valueo2 = rnd.Next(1, 10000);
            }
            if ((valueo3 % 10 == 5) || (valueo3 % 10 == 1) || (valueo3 % 10 == 2) || (valueo3 % 10 == 3))
            {

                o3.Location = new System.Drawing.Point(200, 10);
                o3.Size = new Size(90, 90);
                o3.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
                o3.Visible = true;
                o3.Enabled = false;
                Controls.Add(o3);
                valueo3 = rnd.Next(1, 10000);            }
            if ((valueo4 % 10 == 7) || (valueo4 % 10 == 1) || (valueo4 % 10 == 4) || (valueo4 % 10 == 3))
            {

                o4.Location = new System.Drawing.Point(295, 10);
                o4.Size = new Size(90, 90);
                o4.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
                o4.Visible = true;
                o4.Enabled = false;
                Controls.Add(o4);
                valueo4 = rnd.Next(1, 10000);            }
            if ((valueo5 % 10 == 0) || (valueo5 % 10 == 1) || (valueo5 % 10 == 2) || (valueo5 % 10 == 3))
            {

                o5.Location = new System.Drawing.Point(390, 10);
                o5.Size = new Size(90, 90);
                o5.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
                o5.Visible = true;
                o5.Enabled = false;
                Controls.Add(o5);
                valueo5 = rnd.Next(1, 10000);
            }
            if ((valueo6 % 10 == 0) || (valueo6 % 10 == 1) || (valueo6 % 10 == 2) || (valueo6 % 10 == 3))
            {

                o6.Location = new System.Drawing.Point(485, 10);
                o6.Size = new Size(90, 90);
                o6.BackColor = Color.FromArgb(value1 = rnd.Next(0, 254), value2 = rnd.Next(0, 254), value3 = rnd.Next(0, 254));
                o6.Visible = true;
                o6.Enabled = false;
                Controls.Add(o6);
                valueo6 = rnd.Next(1, 10000);
            }
        }
    }
}
