using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Window
{
    public partial class GUIWindow : Form
    {
        int imageX;
        int imageY;

        View v = null;

        public GUIWindow()
        {
            InitializeComponent();
            imageX = 30;
            imageY = 30;
            v = new View(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Graphics g = this.CreateGraphics();
    
           // v = new View(this);

           // g.DrawLine(new Pen(Brushes.Black, 5), 0, 0, 200, 200);
            
        }

        private void GUIWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           // v = new View(g, this);
           // v.setGraphicsObject(g);
            v.View_Paint(g);

     
          //  Image party = Image.FromFile(@"C:\Users\Anonymous\Documents\Visual Studio 2013\Projects\GUI Window\GUI Window\images\party2.png");
            

           // g.DrawImage(party, imageX, imageY, 50, 50);
        }

        private void GUIWindow_Load(object sender, EventArgs e)
        {

        }

        private void GUIWindow_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyData.Equals(Keys.Right))
                imageX += 60;
            else if (e.KeyData.Equals(Keys.Left))
                imageX -= 20;
            else if (e.KeyData.Equals(Keys.Up))
                imageY -= 20;
            else if (e.KeyData.Equals(Keys.Down))
                imageY += 20;
        

            this.Invalidate();
             * */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // UP
            v.MovePartyUp();
            /*
            if (imageY > 30)
            {
                imageY -= 85;
                this.Invalidate();
            }
             * */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            v.MovePartyRight();
            // Right
            /*
            if (imageX <= 300)
            {
                // Right
                imageX += 85;
                this.Invalidate();
            }
             * */
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            v.MovePartyDown();
            /*
           if (imageY <= 300)
            {
                imageY += 85;
                this.Invalidate();
            }
             * */
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            v.MovePartyLeft();
            /*
            if (imageX > 30)
            {
                imageX -= 85;
                this.Invalidate();
            }
             * */
        }

    }
}
