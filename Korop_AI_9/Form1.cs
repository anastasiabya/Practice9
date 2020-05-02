using System;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace Korop_AI_9
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private object locker = new object();
        int time = 100, cnt_circles = 10;
        public static int cnt_threads = 0;

        public Form1()
        {
            InitializeComponent();
            TextBox1.TextChanged += new EventHandler(Label1_Changed);
            TextBox2.TextChanged += new EventHandler(Label2_Changed);
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lock (locker)
            {
                if (cnt_threads < cnt_circles)
                {
                    cnt_threads++;
                    Thread thread = new Thread(new ThreadStart(new Circle(time, canvas).Draw));
                    thread.Start();
                }
            }
        }

        private void Label1_Changed(object sender, EventArgs e)
        {
            int.TryParse(TextBox1.Text, out time);
        }

        private void Label2_Changed(object sender, EventArgs e)
        {
            int.TryParse(TextBox2.Text, out cnt_circles);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;

        }
    }

    class Circle
    {
        Random rnd = new Random();
        Graphics draw;
        int time, rndX, rndY, r=0;
        Pen pen, penDelete;

        public Circle(int t, Label canvas)
        {
            var border = 3;
            time = t;
            draw = canvas.CreateGraphics();
            rndX = rnd.Next(0, canvas.Width);
            rndY = rnd.Next(0, canvas.Height);
            pen = new Pen(Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)), border);
            penDelete = new Pen(canvas.BackColor, border);
        }

        public void Draw()
        {
            for (int i = 0; i < time; i++)
            {
                draw.DrawEllipse(penDelete, rndX - r / 2, rndY - r / 2, r, r);
                r++;
                draw.DrawEllipse(pen, rndX - r / 2, rndY - r / 2, r, r);
                Thread.Sleep(25);
            }
            draw.DrawEllipse(penDelete, rndX - r / 2, rndY - r / 2, r, r);
            Interlocked.Decrement(ref Form1.cnt_threads);
        }
    }
}
