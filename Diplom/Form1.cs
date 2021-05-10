using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Form1 : Form
    {

        Bitmap pic;
        private Color currentColor;

        private int lastX;
        private int lastY;

        public Form1()
        {
            
            InitializeComponent();
            pic = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            
            
            lastX = lastY = 0;
            currentColor = Color.Brown;
            Graphics g = Graphics.FromImage(pic);
            g.Clear(Color.Teal);
            drawGrid();            
        }

        private void buttonPorch_Click(object sender, EventArgs e)
        {
            currentColor = Color.SteelBlue;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(currentColor);
            Graphics g = Graphics.FromImage(pic);
            //посмотреть  интегральную формулу коши
            if(e.Button == MouseButtons.Left)
            {

                for(int i = 0; i<=pic.Height; i+= (pic.Height / 100))
                {
                    if((i>=e.Y)&&(e.Y<=(i+ (pic.Height / 100))))
                    {
                        lastY = i;
                        break;
                    }
                }
                for(int i = 0; i<=pic.Width; i+= (pic.Width / 100))
                {
                    if((i>=e.X)&&(e.X<=(i+ (pic.Width / 100))))
                    {
                        lastX = i;
                        break;
                    }
                }

                //g.DrawRectangle(pen, lastX+1, lastY+1, (pic.Width / 100)-2, (pic.Height / 100)-2);
                g.FillRectangle(pen.Brush, lastX + 1, lastY + 1, (pic.Width / 100) - 2, (pic.Height / 100) - 2);
                pictureBox1.Image = pic;
            }

            drawGrid();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            currentColor = Color.Brown;
        }

        private void buttonRoad_Click(object sender, EventArgs e)
        {
            currentColor = Color.FromKnownColor(KnownColor.ControlDark);
        }

        private void buttonBarrier_Click(object sender, EventArgs e)
        {
            currentColor = Color.FromKnownColor(KnownColor.ActiveCaptionText);
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            currentColor = Color.Teal;
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            currentColor = Color.White;
            drawGrid();
        }

        private void drawGrid()
        {
            Pen pen = new Pen(Color.Gray);
            Graphics g = Graphics.FromImage(pic);
            for (int i = pic.Height/100; i < pic.Height - (pic.Width / 100); i += (pic.Height/100) )
            {
                g.DrawLine(pen, 0, i, pic.Width, i);           
            }
            for (int i = pic.Width / 100; i < pic.Width - (pic.Width / 100); i += (pic.Width / 100))
            {
                g.DrawLine(pen, i, 0, i, pic.Height);
            }
            pictureBox1.Image = pic;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pic = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pic);
            g.Clear(Color.Teal);
            pictureBox1.Image = pic;
            drawGrid();
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if(saveFileDialog1.FileName != "")
            {
                pic.Save(saveFileDialog1.FileName);
            }
            
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "")
                {
                    pic = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = pic;
                }
             }
            catch
            {

            }
            
        }

        private void аToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Graph graph = new Graph(pic);
            //graph.shortiesWay();
            pictureBox1.Image = graph.getBitmap();
        }
    }
}
