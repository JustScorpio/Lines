using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lines
{
    public partial class Form1 : Form
    {

        int formWidth;
        int formHeight;

        Random rnd;
        Graphics g;

        Color[] colors;

        public Form1()
        {
            InitializeComponent();

            formWidth = Width;
            formHeight = Height;

            rnd = new Random();
            g = this.CreateGraphics();
            colors = new Color[] 
            {
                Color.Black, 
                Color.Red, 
                Color.Green, 
                Color.Yellow, 
                Color.Blue, 
                Color.Violet, 
                Color.Aquamarine,
                Color.Azure,
                Color.Brown,
                Color.DeepSkyBlue,
                Color.AliceBlue,
                Color.LightPink,
                Color.IndianRed,
                Color.GreenYellow
            };
        }

        private void buttonHoriz_Click(object sender, EventArgs e)
        {
            var varWidth = rnd.Next(1, 5);
            var varColor = colors[rnd.Next(0, colors.Length)];
            var xStart = rnd.Next(5, formWidth - 5);
            var yStart = rnd.Next(5, formHeight - 5);
            var xEnd = rnd.Next(5, formWidth - 5);

            g.DrawLine(new Pen(varColor, varWidth), xStart, yStart, xEnd, yStart);
        }

        private void buttonVert_Click(object sender, EventArgs e)
        {
            var varWidth = rnd.Next(1, 5);
            var varColor = colors[rnd.Next(0, colors.Length)];
            var xStart = rnd.Next(5, formWidth - 5);
            var yStart = rnd.Next(5, formHeight - 5);
            var yEnd = rnd.Next(5, formHeight - 5);

            g.DrawLine(new Pen(varColor, varWidth), xStart, yStart, xStart, yEnd);
        }
    }
}
