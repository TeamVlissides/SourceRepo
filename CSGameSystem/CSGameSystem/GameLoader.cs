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
    public partial class GameLoader : Form
    {
        public GameLoader()
        {
            InitializeComponent();
        }

        private void GameLoader_Load(object sender, EventArgs e)
        {
            GUIWindow guiWindow = new GUIWindow();
            guiWindow.ShowDialog();
            this.Close();
            
        }
    }
}
