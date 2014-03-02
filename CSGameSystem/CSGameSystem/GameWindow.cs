using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGameSystem
{

    public enum LocationA
    {
        UP, // 0
        DOWN, // 1
        RIGHT, // 2
        LEFT //3
    }

    public partial class GUIWindow : Form
    {
        int imageX;
        int imageY;

        DisplayView v = null;
        Dungeon dungeon;
        Game game = null;
        BattleSystem battle;

        public GUIWindow()
        {
            InitializeComponent();
            imageX = 30;
            imageY = 30;
            game = new Game();
            dungeon = new Dungeon();
            v = new DisplayView(this, dungeon);
            battle = new BattleSystem(v);
            dungeon.SetView(v);
            game = new Game(dungeon, v, battle);
            dungeon.SetGame(game);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Graphics g = this.CreateGraphics();
    
           // v = new View(this);

           // g.DrawLine(new Pen(Brushes.Black, 5), 0, 0, 200, 200);
           // viewTextOutput.AppendText(Environment.NewLine + "The player has mod left.");
           // v.sendOutput("The player has moved left.");
            testENUM(LocationA.UP);
        }

        public void testENUM(LocationA loc)
        {
            if (loc.ToString() == "UP")
            {
                MessageBox.Show("Location: " + LocationA.UP);
            }
        }

        public void SetTextOutput(String str)
        {
            //viewTextOutput.Text = str;
            viewTextOutput.AppendText(Environment.NewLine + str);
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
           // v.MovePartyUp();
            try
            {
                dungeon.getDirection(DirectionEnum.UP);
                v.PartyMoveUpdate();
            }
            catch(Exception exp)
            {
                MessageBox.Show("DEBUG: " + exp.ToString());
            }
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
            //v.MovePartyRight();
            dungeon.getDirection(DirectionEnum.RIGHT);
            v.PartyMoveUpdate();
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
           // v.MovePartyDown();
            dungeon.getDirection(DirectionEnum.DOWN);
            v.PartyMoveUpdate();
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
            //v.MovePartyLeft();
            dungeon.getDirection(DirectionEnum.LEFT);
            v.PartyMoveUpdate();
            /*
            if (imageX > 30)
            {
                imageX -= 85;
                this.Invalidate();
            }
             * */
        }

        /*
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GUIWindow
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "GUIWindow";
            this.Load += new System.EventHandler(this.GUIWindow_Load_1);
            this.ResumeLayout(false);

        }
         */

        private void GUIWindow_Load_1(object sender, EventArgs e)
        {

        }

        private void viewPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(Brushes.Black, 5), 0, 0, viewPanel.Width, viewPanel.Height);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
