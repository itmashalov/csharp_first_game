using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        Button btn = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();
        Button btn5 = new Button();
        Button btn6 = new Button();
        Button btn7 = new Button();
        Button btn8 = new Button();
        Button btn9 = new Button();
        Button btn10 = new Button();
       // private bool button1WasClicked = false;
       // private bool button2WasClicked = false;

        string[,] button1WasClicked = new string[2, 2] { { "false", "true" }, { "true", "true" } };
        string[,] button2WasClicked = new string[2, 2] { { "false", "true" }, { "true", "true" } };
       
        string[,] button3WasClicked = new string[2, 2] { { "false", "true" }, { "true", "true" } };
        string[,] button4WasClicked = new string[2, 2] { { "false", "true" }, { "true", "true" } };

        string[,] button5WasClicked = new string[2, 2] { { "false", "true" }, { "true", "true" } };
        string[,] button6WasClicked = new string[2, 2] { { "false", "true" }, { "true", "true" } };

        string[,] button7WasClicked = new string[2, 2] { { "false", "true" }, { "true", "true" } };
        string[,] button8WasClicked = new string[2, 2] { { "false", "true" }, { "true", "true" } };
 
        string[,] button9WasClicked = new string[2, 2] { { "false", "true" }, { "true", "true" } };
        string[,] button10WasClicked = new string[2, 2] { { "false", "true" }, { "true", "true" } };
        
        PictureBox imageControl = new PictureBox();
        //some sounds here but I didnt unCommented it because I am not sure if you have that path on your computer
       // System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");
        public Form1()
        {
           // Form2 newgGame = new Form2();
            // newgGame.Show();
            
            program();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void program()
        {
            this.Size = new System.Drawing.Size(700, 700);
            InitializeComponent();
            
            btn.SetBounds(30, 30, 40, 40);
            btn.BackColor = Color.PowderBlue;
            btn.MouseEnter += new EventHandler(this.btn_MouseEnter);
            btn.MouseLeave += new EventHandler(this.btn_MouseLeave);

            btn.Click += new EventHandler(this.btnEvent_Click);

            Controls.Add(btn);


            btn2.SetBounds(80, 130, 40, 40);
            btn2.BackColor = Color.PowderBlue;
            btn2.MouseEnter += new EventHandler(this.btn2_MouseEnter);
            btn2.MouseLeave += new EventHandler(this.btn2_MouseLeave);
            btn2.Click += new EventHandler(this.btn2Event_Click);
            Controls.Add(btn2);

            btn3.SetBounds(30, 130, 40, 40);
            btn3.BackColor = Color.PowderBlue;
            btn3.MouseEnter += new EventHandler(this.btn3_MouseEnter);
            btn3.MouseLeave += new EventHandler(this.btn3_MouseLeave);
            btn3.Click += new EventHandler(this.btn3Event_Click);
            Controls.Add(btn3);

            btn4.SetBounds(80, 30, 40, 40);
            btn4.BackColor = Color.PowderBlue;
            btn4.MouseEnter += new EventHandler(this.btn4_MouseEnter);
            btn4.MouseLeave += new EventHandler(this.btn4_MouseLeave);
            btn4.Click += new EventHandler(this.btn4Event_Click);
            Controls.Add(btn4);


            btn5.SetBounds(130, 30, 40, 40);
            btn5.BackColor = Color.PowderBlue;
            btn5.MouseEnter += new EventHandler(this.btn5_MouseEnter);
            btn5.MouseLeave += new EventHandler(this.btn5_MouseLeave);
            btn5.Click += new EventHandler(this.btn5Event_Click);
            Controls.Add(btn5);

            btn6.SetBounds(130, 130, 40, 40);
            btn6.BackColor = Color.PowderBlue;
            btn6.MouseEnter += new EventHandler(this.btn6_MouseEnter);
            btn6.MouseLeave += new EventHandler(this.btn6_MouseLeave);
            btn6.Click += new EventHandler(this.btn6Event_Click);
            Controls.Add(btn6);

            btn7.SetBounds(130, 180, 40, 40);
            btn7.BackColor = Color.PowderBlue;
            btn7.MouseEnter += new EventHandler(this.btn7_MouseEnter);
            btn7.MouseLeave += new EventHandler(this.btn7_MouseLeave);
            btn7.Click += new EventHandler(this.btn7Event_Click);
            Controls.Add(btn7);

            btn8.SetBounds(80, 80, 40, 40);
            btn8.BackColor = Color.PowderBlue;
            btn8.MouseEnter += new EventHandler(this.btn8_MouseEnter);
            btn8.MouseLeave += new EventHandler(this.btn8_MouseLeave);
            btn8.Click += new EventHandler(this.btn8Event_Click);
            Controls.Add(btn8);

            btn9.SetBounds(130, 80, 40, 40);
            btn9.BackColor = Color.PowderBlue;
            btn9.MouseEnter += new EventHandler(this.btn9_MouseEnter);
            btn9.MouseLeave += new EventHandler(this.btn9_MouseLeave);
            btn9.Click += new EventHandler(this.btn9Event_Click);
            Controls.Add(btn9);

            btn10.SetBounds(30, 180, 40, 40);
            btn10.BackColor = Color.PowderBlue;
            btn10.MouseEnter += new EventHandler(this.btn10_MouseEnter);
            btn10.MouseLeave += new EventHandler(this.btn10_MouseLeave);
            btn10.Click += new EventHandler(this.btn10Event_Click);
            Controls.Add(btn10);
        }












        void btnEvent_Click(object sender, EventArgs e)
        { 
            btn.Enabled = false;// we need this because if we dont have it will can clear two buttons while we are clicking only on one!
          
            if (button1WasClicked[0, 0] == "true" && button2WasClicked[0, 0] != "true")
            {
                button2WasClicked[0, 0] = "true";
                btn.BackColor = Color.Green;


               




                

            }
            if (button1WasClicked[0, 0] == "true" && button2WasClicked[0, 0] == "true")
            {
                Controls.Remove(btn);
                Controls.Remove(btn2);
                //startSoundPlayer.Play();
            }
            if (button1WasClicked[0, 0] != "true" && button2WasClicked[0, 0] != "true")
            {
                button1WasClicked[0, 0] = "true";
                btn.BackColor = Color.Green;
               

            }
          
          
        }
        
        void btn_MouseEnter(object sender, EventArgs e)
        {
            
            //if (button1WasClicked[0,0] == "false" && button2WasClicked[0,0] == "false")
            //{
          //      btn.BackColor = Color.Red;
                
            //}
            imageControl.Width = 500;
            imageControl.Height = 500;

            Bitmap image = new Bitmap("1.gif");
            //imageControl.Dock = DockStyle.Fill;
            
            Size size = new Size(350, 354);
            //Padding Padding = new Padding(420, 60, 10, 10);
           // imageControl.Padding = Padding;
            imageControl.Size = size;
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
           // Controls.Remove(btn);
            //Controls.Remove(imageControl)
        }
        void btn_MouseLeave(object sender, EventArgs e)
        {
           
            if (button1WasClicked[0, 0] == "false" && button2WasClicked[0, 0] == "false")
            {
                //btn.BackColor = Color.PowderBlue;
            }
            if (button1WasClicked[0, 0] == "false" && button2WasClicked[0, 0] == "true")
            {
           //     btn.BackColor = Color.PowderBlue;
            }
            

           // }
           Controls.Remove(imageControl);
            // Controls.Remove(btn);
        }


        void btn2Event_Click(object sender, EventArgs e)
        {
            btn2.Enabled = false;
            if (button1WasClicked[0, 0] == "true" && button2WasClicked[0, 0] == "true")
            {

                btn2.BackColor = Color.Yellow;
            }
            if (button1WasClicked[0, 0] == "true" && button2WasClicked[0, 0] != "true")
            {
                button2WasClicked[0, 0] = "true";
                btn2.BackColor = Color.Green;
                Controls.Remove(btn);
                Controls.Remove(btn2);
                //startSoundPlayer.Play();
            }
            if (button1WasClicked[0, 0] != "true" || button2WasClicked[0, 0] != "true")
            {
                button1WasClicked[0, 0] = "true";
                btn2.BackColor = Color.Green;
            }
        }
        
        void btn2_MouseEnter(object sender, EventArgs e)
        {
           // if (button1WasClicked == false)
          //  {
          //      btn2.BackColor = Color.Red;
          //  }
            imageControl.Width = 500;
            imageControl.Height = 500;

            Bitmap image = new Bitmap("1.gif");
            //imageControl.Dock = DockStyle.Fill;

            Size size = new Size(350, 354);
            //Padding Padding = new Padding(420, 60, 10, 10);
            // imageControl.Padding = Padding;
            imageControl.Size = size;
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
            // Controls.Remove(btn);
            //Controls.Remove(imageControl)
        }
        void btn2_MouseLeave(object sender, EventArgs e)
        {
           // if (button1WasClicked == false)
           // {
            //    btn2.BackColor = Color.PowderBlue;
           // }
            Controls.Remove(imageControl);
            // Controls.Remove(btn);
        }
        

        ///////////////////////////////////////////////////////////////////////////////////second pair of images////////////////////////////////////////////////////////////
        void btn3Event_Click(object sender, EventArgs e)
        {
            btn3.Enabled = false;
            if (button3WasClicked[0, 0] == "true" && button4WasClicked[0, 0] == "true")
            {

                btn3.BackColor = Color.Yellow;
            }
            if (button3WasClicked[0, 0] == "true" && button4WasClicked[0, 0] != "true")
            {
                button4WasClicked[0, 0] = "true";
                btn3.BackColor = Color.Green;
                Controls.Remove(btn3);
                Controls.Remove(btn4);
                //startSoundPlayer.Play();

            }
            if (button3WasClicked[0, 0] != "true" || button4WasClicked[0, 0] != "true")
            {
                button3WasClicked[0, 0] = "true";
                btn3.BackColor = Color.Green;
            }


        }

        void btn3_MouseEnter(object sender, EventArgs e)
        {
            //if (button3WasClicked[0,0] == "false" && button4WasClicked[0,0] == "false")
            //{
            //      btn3.BackColor = Color.Red;

            //}
            imageControl.Width = 500;
            imageControl.Height = 500;

            Bitmap image = new Bitmap("dog.gif");
            //imageControl.Dock = DockStyle.Fill;

             Size size = new Size(585,455);
            //Padding Padding = new Padding(420, 60, 100, 101);
           // imageControl.Padding = Padding;
            imageControl.Size = size;
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
            // Controls.Remove(btn3);
            //Controls.Remove(imageControl)
        }
        void btn3_MouseLeave(object sender, EventArgs e)
        {
            if (button3WasClicked[0, 0] == "false" && button4WasClicked[0, 0] == "false")
            {
                //btn3.BackColor = Color.PowderBlue;
            }
            if (button3WasClicked[0, 0] == "false" && button4WasClicked[0, 0] == "true")
            {
                //     btn3.BackColor = Color.PowderBlue;
            }


            // }
            Controls.Remove(imageControl);
            // Controls.Remove(btn3);
        }


        void btn4Event_Click(object sender, EventArgs e)
        {
            btn4.Enabled = false;
            if (button3WasClicked[0, 0] == "true" && button4WasClicked[0, 0] == "true")
            {

                btn4.BackColor = Color.Yellow;
            }
            if (button3WasClicked[0, 0] == "true" && button4WasClicked[0, 0] != "true")
            {
                button4WasClicked[0, 0] = "true";
                btn4.BackColor = Color.Green;
                Controls.Remove(btn3);
                Controls.Remove(btn4);
                //startSoundPlayer.Play();
            }
            if (button3WasClicked[0, 0] != "true" || button4WasClicked[0, 0] != "true")
            {
                button3WasClicked[0, 0] = "true";
                btn4.BackColor = Color.Green;
            }
        }

        void btn4_MouseEnter(object sender, EventArgs e)
        {
            // if (button3WasClicked == false)
            //  {
            //      btn4.BackColor = Color.Red;
            //  }
            imageControl.Width = 500;
            imageControl.Height = 500;

            Bitmap image = new Bitmap("dog.gif");
            //imageControl.Dock = DockStyle.Fill;


            Size size = new Size(585, 455);
            //Padding Padding = new Padding(420, 60, 100, 101);
            // imageControl.Padding = Padding;
            imageControl.Size = size;
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
            // Controls.Remove(btn);
            //Controls.Remove(imageControl)
        }
        void btn4_MouseLeave(object sender, EventArgs e)
        {
            // if (button3WasClicked == false)
            // {
            //    btn4.BackColor = Color.PowderBlue;
            // }
            Controls.Remove(imageControl);
            // Controls.Remove(btn);
        }

        ///////////////////////////////////////////////////////////////////////////////////third pair of images////////////////////////////////////////////////////////////
        void btn5Event_Click(object sender, EventArgs e)
        {
            btn5.Enabled = false;
            if (button5WasClicked[0, 0] == "true" && button6WasClicked[0, 0] == "true")
            {

                btn5.BackColor = Color.Yellow;
            }
            if (button5WasClicked[0, 0] == "true" && button6WasClicked[0, 0] != "true")
            {
                button6WasClicked[0, 0] = "true";
                btn5.BackColor = Color.Green;
                Controls.Remove(btn5);
                Controls.Remove(btn6);
                //startSoundPlayer.Play();

            }
            if (button5WasClicked[0, 0] != "true" || button6WasClicked[0, 0] != "true")
            {
                button5WasClicked[0, 0] = "true";
                btn5.BackColor = Color.Green;
            }


        }

        void btn5_MouseEnter(object sender, EventArgs e)
        {
            //if (button5WasClicked[0,0] == "false" && button6WasClicked[0,0] == "false")
            //{
            //      btn5.BackColor = Color.Red;

            //}
            imageControl.Width = 500;
            imageControl.Height = 500;

            Bitmap image = new Bitmap("mouse.gif");
            //imageControl.Dock = DockStyle.Fill;

            Size size = new Size(462, 300);
            //Padding Padding = new Padding(420, 60, 100, 101);
            // imageControl.Padding = Padding;
            imageControl.Size = size;
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
            // Controls.Remove(btn5);
            //Controls.Remove(imageControl)
        }
        void btn5_MouseLeave(object sender, EventArgs e)
        {
            if (button5WasClicked[0, 0] == "false" && button6WasClicked[0, 0] == "false")
            {
                //btn5.BackColor = Color.PowderBlue;
            }
            if (button5WasClicked[0, 0] == "false" && button6WasClicked[0, 0] == "true")
            {
                //     btn5.BackColor = Color.PowderBlue;
            }


            // }
            Controls.Remove(imageControl);
            // Controls.Remove(btn5);
        }


        void btn6Event_Click(object sender, EventArgs e)
        {
            btn6.Enabled = false;
            if (button5WasClicked[0, 0] == "true" && button6WasClicked[0, 0] == "true")
            {

                btn6.BackColor = Color.Yellow;
            }
            if (button5WasClicked[0, 0] == "true" && button6WasClicked[0, 0] != "true")
            {
                button6WasClicked[0, 0] = "true";
                btn6.BackColor = Color.Green;
                Controls.Remove(btn5);
                Controls.Remove(btn6);
                //startSoundPlayer.Play();
            }
            if (button5WasClicked[0, 0] != "true" || button6WasClicked[0, 0] != "true")
            {
                button5WasClicked[0, 0] = "true";
                btn6.BackColor = Color.Green;
            }
        }

        void btn6_MouseEnter(object sender, EventArgs e)
        {
            // if (button5WasClicked == false)
            //  {
            //      btn6.BackColor = Color.Red;
            //  }
            imageControl.Width = 500;
            imageControl.Height = 500;

            Bitmap image = new Bitmap("mouse.gif");
            //imageControl.Dock = DockStyle.Fill;


            Size size = new Size(462, 300);
            //Padding Padding = new Padding(420, 60, 100, 101);
            // imageControl.Padding = Padding;
            imageControl.Size = size;
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
            // Controls.Remove(btn);
            //Controls.Remove(imageControl)
        }
        void btn6_MouseLeave(object sender, EventArgs e)
        {
            // if (button5WasClicked == false)
            // {
            //    btn6.BackColor = Color.PowderBlue;
            // }
            Controls.Remove(imageControl);
            // Controls.Remove(btn);
        }

        ///////////////////////////////////////////////////////////////////////////////////fourth pair of images////////////////////////////////////////////////////////////
        void btn7Event_Click(object sender, EventArgs e)
        {
            btn7.Enabled = false;
            if (button7WasClicked[0, 0] == "true" && button8WasClicked[0, 0] == "true")
            {

                btn7.BackColor = Color.Yellow;
            }
            if (button7WasClicked[0, 0] == "true" && button8WasClicked[0, 0] != "true")
            {
                button8WasClicked[0, 0] = "true";
                btn7.BackColor = Color.Green;
                Controls.Remove(btn7);
                Controls.Remove(btn8);
                //startSoundPlayer.Play();

            }
            if (button7WasClicked[0, 0] != "true" || button8WasClicked[0, 0] != "true")
            {
                button7WasClicked[0, 0] = "true";
                btn7.BackColor = Color.Green;
            }


        }

        void btn7_MouseEnter(object sender, EventArgs e)
        {
            //if (button7WasClicked[0,0] == "false" && button8WasClicked[0,0] == "false")
            //{
            //      btn7.BackColor = Color.Red;

            //}
            imageControl.Width = 500;
            imageControl.Height = 500;

            Bitmap image = new Bitmap("homer.gif");
            //imageControl.Dock = DockStyle.Fill;

            Size size = new Size(500, 375);
            //Padding Padding = new Padding(420, 60, 100, 101);
            // imageControl.Padding = Padding;
            imageControl.Size = size;
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
            // Controls.Remove(btn7);
            //Controls.Remove(imageControl)
        }
        void btn7_MouseLeave(object sender, EventArgs e)
        {
            if (button7WasClicked[0, 0] == "false" && button8WasClicked[0, 0] == "false")
            {
                //btn7.BackColor = Color.PowderBlue;
            }
            if (button7WasClicked[0, 0] == "false" && button8WasClicked[0, 0] == "true")
            {
                //     btn7.BackColor = Color.PowderBlue;
            }


            // }
            Controls.Remove(imageControl);
            // Controls.Remove(btn7);
        }


        void btn8Event_Click(object sender, EventArgs e)
        {
            btn8.Enabled = false;
            if (button7WasClicked[0, 0] == "true" && button8WasClicked[0, 0] == "true")
            {

                btn8.BackColor = Color.Yellow;
            }
            if (button7WasClicked[0, 0] == "true" && button8WasClicked[0, 0] != "true")
            {
                button8WasClicked[0, 0] = "true";
                btn8.BackColor = Color.Green;
                Controls.Remove(btn7);
                Controls.Remove(btn8);
                //startSoundPlayer.Play();
            }
            if (button7WasClicked[0, 0] != "true" || button8WasClicked[0, 0] != "true")
            {
                button7WasClicked[0, 0] = "true";
                btn8.BackColor = Color.Green;
            }
        }

        void btn8_MouseEnter(object sender, EventArgs e)
        {
            // if (button7WasClicked == false)
            //  {
            //      btn8.BackColor = Color.Red;
            //  }
            imageControl.Width = 500;
            imageControl.Height = 500;

            Bitmap image = new Bitmap("homer.gif");
            //imageControl.Dock = DockStyle.Fill;


            Size size = new Size(500, 375);
            //Padding Padding = new Padding(420, 60, 100, 101);
            // imageControl.Padding = Padding;
            imageControl.Size = size;
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
            // Controls.Remove(btn);
            //Controls.Remove(imageControl)
        }
        void btn8_MouseLeave(object sender, EventArgs e)
        {
            // if (button7WasClicked == false)
            // {
            //    btn8.BackColor = Color.PowderBlue;
            // }
            Controls.Remove(imageControl);
            // Controls.Remove(btn);
        }

        ///////////////////////////////////////////////////////////////////////////////////fifth pair of images////////////////////////////////////////////////////////////
        void btn9Event_Click(object sender, EventArgs e)
        {
            btn9.Enabled = false;
            if (button9WasClicked[0, 0] == "true" && button10WasClicked[0, 0] == "true")
            {

                btn9.BackColor = Color.Yellow;
            }
            if (button9WasClicked[0, 0] == "true" && button10WasClicked[0, 0] != "true")
            {
                button10WasClicked[0, 0] = "true";
                btn9.BackColor = Color.Green;
                Controls.Remove(btn9);
                Controls.Remove(btn10);
                //startSoundPlayer.Play();

            }
            if (button9WasClicked[0, 0] != "true" || button10WasClicked[0, 0] != "true")
            {
                button9WasClicked[0, 0] = "true";
                btn9.BackColor = Color.Green;
            }


        }

        void btn9_MouseEnter(object sender, EventArgs e)
        {
            //if (button9WasClicked[0,0] == "false" && button10WasClicked[0,0] == "false")
            //{
            //      btn9.BackColor = Color.Red;

            //}
            imageControl.Width = 500;
            imageControl.Height = 500;

            Bitmap image = new Bitmap("willie.gif");
            //imageControl.Dock = DockStyle.Fill;

            Size size = new Size(500, 375);
            //Padding Padding = new Padding(420, 60, 100, 101);
            // imageControl.Padding = Padding;
            imageControl.Size = size;
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
            // Controls.Remove(btn9);
            //Controls.Remove(imageControl)
        }
        void btn9_MouseLeave(object sender, EventArgs e)
        {
            if (button9WasClicked[0, 0] == "false" && button10WasClicked[0, 0] == "false")
            {
                //btn9.BackColor = Color.PowderBlue;
            }
            if (button9WasClicked[0, 0] == "false" && button10WasClicked[0, 0] == "true")
            {
                //     btn9.BackColor = Color.PowderBlue;
            }


            // }
            Controls.Remove(imageControl);
            // Controls.Remove(btn9);
        }


        void btn10Event_Click(object sender, EventArgs e)
        {
            btn10.Enabled = false;
            if (button9WasClicked[0, 0] == "true" && button10WasClicked[0, 0] == "true")
            {

                btn10.BackColor = Color.Yellow;
            }
            if (button9WasClicked[0, 0] == "true" && button10WasClicked[0, 0] != "true")
            {
                button10WasClicked[0, 0] = "true";
                btn10.BackColor = Color.Green;
                Controls.Remove(btn9);
                Controls.Remove(btn10);
                //startSoundPlayer.Play();
            }
            if (button9WasClicked[0, 0] != "true" || button10WasClicked[0, 0] != "true")
            {
                button9WasClicked[0, 0] = "true";
                btn10.BackColor = Color.Green;
            }
        }

        void btn10_MouseEnter(object sender, EventArgs e)
        {
            // if (button9WasClicked == false)
            //  {
            //      btn10.BackColor = Color.Red;
            //  }
            imageControl.Width = 500;
            imageControl.Height = 500;

            Bitmap image = new Bitmap("willie.gif");
            //imageControl.Dock = DockStyle.Fill;


            Size size = new Size(500, 375);
            //Padding Padding = new Padding(420, 60, 100, 101);
            // imageControl.Padding = Padding;
            imageControl.Size = size;
            imageControl.Image = (Image)image;

            Controls.Add(imageControl);
            // Controls.Remove(btn);
            //Controls.Remove(imageControl)
        }
        void btn10_MouseLeave(object sender, EventArgs e)
        {
            // if (button9WasClicked == false)
            // {
            //    btn10.BackColor = Color.PowderBlue;
            // }
            Controls.Remove(imageControl);
            // Controls.Remove(btn);
        }
        


      
    }
}
