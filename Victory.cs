using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matchingGame
{
    public partial class Victory : Form
    {
        public Victory()
        {
            InitializeComponent();
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            GameMenu menu = new GameMenu();
            menu.Show();
            this.Close();
        }
    }
}
