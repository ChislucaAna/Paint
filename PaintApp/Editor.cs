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
        Color color=Color.Black;
        Point startpoint, endpoint;
        Graphics g;
        bool free_drawing = false;
        int thickness=2;
        string selected_tool; //what drawing tool the user has currently selected

        public Editor()
        {
            InitializeComponent();
            canvas_img = new Bitmap(canvas.Width, canvas.Height);   
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
            {
                canvas.BackgroundImage = canvas_img;
            }
        }

        public void create_frontend()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.brush_thickness, "Modify brush thickness");
            toolTip.SetToolTip(this.save, "Save project");
            toolTip.SetToolTip(this.eraser, "Eraser");
            toolTip.SetToolTip(this.select_color, "Pick brush Color");
            toolTip.SetToolTip(this.exit, "Exit");
            toolTip.SetToolTip(this.clear_all, "Clear canvas");
            toolTip.SetToolTip(this.change_background, "Pick canvas color");
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "New Project";
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.Filter = "png files (*.png)|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                canvas.DrawToBitmap(canvas_img, new Rectangle(0, 0, canvas.Width, canvas.Height));
                canvas_img.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
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
                color = colorDialog1.Color;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if(selected_tool=="free")
                free_drawing = true;
            else
                startpoint = new Point(e.X, e.Y);

        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (selected_tool == "free")
                free_drawing = false;
            else
            {
                endpoint = new Point(e.X, e.Y);
                draw_new_element();
            }
        }

        public void draw_new_element()
        {
            switch (selected_tool)
            {
                case "line":
                    g.DrawLine(new Pen(color),startpoint, endpoint);
                    break;
                case "circle":
                    g.DrawEllipse(new Pen(color), new Rectangle(startpoint, new Size(endpoint.X-startpoint.X,
                        endpoint.Y-startpoint.Y)));
                    break;
                case "rectangle":
                    g.DrawRectangle(new Pen(color), new Rectangle(startpoint, new Size(endpoint.X - startpoint.X,
                        endpoint.Y - startpoint.Y)));
                    break;
                case "triangle":
                    break;
                default:
                    break;
            }
        }

        private void brush_thickness_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = !trackBar1.Visible;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            thickness = trackBar1.Value;
        }

        private void clear_all_Click(object sender, EventArgs e)
        {
            DialogResult msg;
                msg = MessageBox.Show("Are you sure you want to reset canvas?", "Exit", MessageBoxButtons.OKCancel);
            if (msg == DialogResult.OK)
                g.Clear(Color.White);
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            color = canvas.BackColor;
        }

        private void change_background_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            if (colorDialog2.Color != null)
                canvas.BackColor = colorDialog2.Color;
            else
                canvas.BackColor = Color.White;
        }

        private void selected_tool_changed(object sender, EventArgs e)
        {
            Control c = sender as Control;
            selected_tool = c.Name;
            Graphics h = this.CreateGraphics();
            h.Clear(Color.Black);//only one button can be selected at a time
            h.FillRectangle(new SolidBrush(Color.Purple), new Rectangle(new Point(c.Location.X - 5, c.Location.Y - 5)
                , new Size(c.Width + 10, c.Height + 10) ));
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (free_drawing)
                g.FillEllipse(new SolidBrush(color), new Rectangle(new Point(e.X, e.Y), new Size(thickness, thickness)));
        }
    }
}
