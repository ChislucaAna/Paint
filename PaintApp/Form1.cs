using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editor form = new Editor();
            form.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = AppContext.BaseDirectory;
            dlg.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                Editor form = new Editor(dlg.FileName);
                form.ShowDialog();
                this.Show();
            }
        }
    }
}
