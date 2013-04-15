using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace RGB
{
    public partial class GUI : Form
    {
        private Bitmap bitmap = new Bitmap(1,1);
        private bool isDown = false;
        private int prevX, prevY;
        private int x = 0, y = 0;
        Thread puppet;

        public GUI()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            puppet = new Thread(new ThreadStart(doNothing));
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            DialogResult r = saveFileDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName);
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (puppet.IsAlive)
            {
                convertButton.Text = "Convert"; bitmap = new Bitmap(1, 1);
                puppet.Abort();
                Invalidate();
                Pixelizer.progress = 0;
            }
            else
            {
                puppet = new Thread(new ThreadStart(convert));
                puppet.Start();
                convertButton.Text = "Cancel";
            }
        }

        private void convert()
        {
            try
            {
                Bitmap input = new Bitmap(textBox.Text);
                bitmap = null;
                this.Invalidate();
                bitmap = Pixelizer.convert(input, (int)pixelNUD.Value);
                Console.WriteLine("Finished!");
                this.Invalidate();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid file");
            }
            catch (Exception)
            {
                
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                prevX = e.X;
                prevY = e.Y;
                isDown = true;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                int dx = e.X - prevX;
                int dy = e.Y - prevY;
                prevX = e.X;
                prevY = e.Y;
                x += dx;
                y += dy;
                this.Invalidate();
            }
        }

        private void pixelNUD_ValueChanged(object sender, EventArgs e)
        {
            pixelNUD.Value -= pixelNUD.Value % 3;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, x, y + toolbar.Height + progressBar.Height);
                if (Pixelizer.progress > 0) exportButton.Enabled = true;
                convertButton.Text = "Convert";
            }
            catch
            {
                Font f = new Font(SystemFonts.StatusFont, FontStyle.Bold);
                e.Graphics.DrawString("Rendering...", f, Brushes.Black, new PointF(this.Width / 2 - 45, this.Height / 2 - 20));
                exportButton.Enabled = false;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                textBox.Text = openFileDialog.FileName;
                convertButton.Enabled = true;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0 && File.Exists(textBox.Text))
            {
                convertButton.Enabled = true;
            }
            else
            {
                convertButton.Enabled = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value = Pixelizer.progress;
        }

        private void doNothing()
        {
        }
    }
}
