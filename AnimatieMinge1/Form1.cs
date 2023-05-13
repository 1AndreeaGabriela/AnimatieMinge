using System.Windows.Forms;
using System.Drawing;
using System;

namespace AnimatieMinge1
{
    public partial class Form1 : Form
    {
        // variabile pentru pozitia si viteza mingii
        private float x = 50, y = 50;
        private float vx = 7, vy = 6;
        // variabile pentru dimensiunile cutiei
        private const float boxWidth = 400, boxHeight = 300;
        // variabila pentru culoarea mingii
        private Color ballColor = Color.Pink;
        public Form1()
        {
            InitializeComponent();
            // pornim timer-ul pentru actualizarea animatiei
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float centerX = (this.ClientSize.Width - boxWidth) / 2;
            float centerY = (this.ClientSize.Height - boxHeight) / 2;
            // desenam cutia folosind un Pen negru de grosime 2
            using (Pen pen = new Pen(Color.Black, 2))
            using (SolidBrush brush = new SolidBrush(Color.AliceBlue))
            {
                e.Graphics.FillRectangle(brush, centerX, centerY, boxWidth, boxHeight);
                e.Graphics.DrawRectangle(pen, centerX, centerY, boxWidth, boxHeight);
            }
            // desenam mingea folosind un Pen de culoarea selectata si de grosime 2
            using (Pen pen = new Pen(ballColor, 2))
            using (SolidBrush brush = new SolidBrush(ballColor))
            {
                float ballX = centerX + x;  // adjust the x position of the ball
                float ballY = centerY + y;  // adjust the y position of the ball
                e.Graphics.FillEllipse(brush, ballX, ballY, 30, 30);
                e.Graphics.DrawEllipse(pen, ballX, ballY, 30, 30);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            // actualizam pozitia mingii
            x += vx;
            y += vy;
            // detectam coliziunile cu marginile cutiei
            if (x < 0 || x > boxWidth - 20)
            {
                vx = -vx;
            }
            if (y < 0 || y > boxHeight - 20)
            {
                vy = -vy;
            }
            // redesenam forma
            Invalidate();
        }

        private void btnSchimbaCuloarea_Click(object sender, EventArgs e)
        {
            // afisam dialogul de selectie a culorii si actualizam culoarea mingii
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ballColor = colorDialog1.Color;
            }
        }
    }
}
