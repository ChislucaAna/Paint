using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Editor : Form
    {
        Bitmap canvas_img;
        bool unsaved_changes = false;
        Color color;
        Point startpoint, endpoint;
        Graphics g;
        bool free_drawing = false;
        int thickness;

        public Editor()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
        }

        public Editor(string file)
        {
            InitializeComponent();
            canvas_img = new Bitmap(Image.FromFile(Path.GetFullPath(file)), canvas.Size);
            g = canvas.CreateGraphics();

        }

        private void Editor_Load(object sender, EventArgs e)
        {
            create_frontend();
            if (canvas_img != null)
                g.DrawImage(canvas_img, new Point(0, 0));
        }

        public void create_frontend()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.brush_thickness, "Modify brush thickness");
            toolTip.SetToolTip(this.save, "Save project");
            toolTip.SetToolTip(this.eraser, "Eraser");
            toolTip.SetToolTip(this.select_color, "Pick Brush Color");
            toolTip.SetToolTip(this.exit, "Exit");
            toolTip.SetToolTip(this.clear_all, "Clear canvas");
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "New Project";
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.Filter = "png files (*.png)|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                canvas_img.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult msg;
            if (!unsaved_changes)
                msg = MessageBox.Show("Are you sure you want to exit the editor?", "Exit", MessageBoxButtons.OKCancel);
            else
                msg = MessageBox.Show("You have unsaved changes. Do you want to discard current state of project?", "Exit", MessageBoxButtons.OKCancel);
            if (msg == DialogResult.OK)
                this.Close();
        }

        private void colorpicker_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.Color != null)
            {
                color = colorDialog1.Color;
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            free_drawing = true;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            free_drawing = false;
            //endpoint = new Point(e.X, e.Y);
            //draw_new_line();
        }

        private void brush_thickness_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = !trackBar1.Visible;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            thickness = trackBar1.Value;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (free_drawing)
                g.FillEllipse(new SolidBrush(color), new Rectangle(new Point(e.X, e.Y), new Size(thickness, thickness)));
        }
    }
}
