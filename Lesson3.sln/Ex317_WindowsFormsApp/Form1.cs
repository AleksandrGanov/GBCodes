using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex317_WindowsFormsApp
{
 
    public partial class Form1 : Form
    {

        event Action<string, int, int> LogEvent; 

        public Form1()
        {
            InitializeComponent();


            



            button1.Click

            LogEvent = Log.LogConsole;
            LogEvent = Log.LogFile;
            

            this.Click += (s,e)=>
            {
                //if (e.KeyCode == Keys.Up) ;// Ship.Up();
                //if (e.KeyCode == Keys.Down) ;// Ship.Down();
            };

       


        }

        private void Button1_Click3(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Button1_Click2(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button1_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Огого");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
          
       

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            LogEvent("Вызвано button1_MouseDown", e.X, e.Y);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            LogEvent("Вызвано button1_MouseUp", e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                LogEvent("Вызвано Form1_MouseMove", e.X, e.Y);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEvent("Вызвано Form1_FormClosing", this.Left, this.Top);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogEvent?.Invoke("Вызвано Form1_Load", this.Left, this.Top);
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (LogEvent != null) LogEvent("Вызвано Form1_Move", this.Left, this.Top);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Debug.WriteLine("vcsdcsd");
        }

        void A()
        {
            for (int i = 0; i < 100; i++)
            {
                MessageBox.Show("vcsc");
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A) button1.Left -= 10;
            if(e.KeyCode == Keys.D) button1.Left += 10;
        }
    }
}
