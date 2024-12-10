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
        Bitmap canvas_img,original_canvas_img;
        Color color=Color.Black;
        Point startpoint, endpoint;
        Graphics g;
        Graphics canvas_graphics;
        bool free_drawing = false;
        int thickness=2;
        string selected_tool; //what drawing tool the user has currently selected
        bool imported=false;
        double zoom_level = 1; //current state of zoom in/out in the editor canvas

        public Editor()
        {
            InitializeComponent();

            canvas_img = new Bitmap(canvas.Width, canvas.Height);   
            g = Graphics.FromImage(canvas_img);

            canvas.MouseWheel += canvas_MouseWheel;
            canvas_graphics = canvas.CreateGraphics();
        }

        public Editor(string file)
        {
            InitializeComponent();

            canvas_img = new Bitmap(Image.FromFile(Path.GetFullPath(file)), canvas.Size);
            g = Graphics.FromImage(canvas_img);

            imported = true;
            canvas.MouseWheel += canvas_MouseWheel;
            canvas_graphics = canvas.CreateGraphics();

        }

        private void canvas_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                zoom_in_to(e.X, e.Y);
            else
                zoom_out_from(e.X, e.Y);
        }

        public void zoom_in_to(int centerx, int centery)
        {
            canvas_img = new Bitmap(canvas_img,new Size(Convert.ToInt32(canvas_img.Width*1.1),Convert.ToInt32(canvas_img.Height*1.1)));
            canvas_graphics.Clear(Color.White);
            canvas_graphics.DrawImage(canvas_img, Convert.ToInt32(centerx*1.1-canvas_img.Width/2),
                Convert.ToInt32(1.1*centery - canvas_img.Height / 2));
        }

        public void zoom_out_from(int centerx, int centery)
        {
            canvas_img = new Bitmap(canvas_img, new Size(Convert.ToInt32(canvas_img.Width / 1.1), Convert.ToInt32(canvas_img.Height / 1.1)));
            canvas_graphics.Clear(Color.White);
            canvas_graphics.DrawImage(canvas_img, centerx - canvas_img.Width / 2, centery - canvas_img.Height / 2);
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
            toolTip.SetToolTip(this.free, "Draw freely using mouse");
            toolTip.SetToolTip(this.line, "Add line");
            toolTip.SetToolTip(this.rectangle, "Add rectangle");
            toolTip.SetToolTip(this.circle, "Add circle");
            toolTip.SetToolTip(this.triangle, "Add triangle");
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
               msg = MessageBox.Show("Are you sure you want to exit the editor? All unsaved chages will be lost.", "Exit", MessageBoxButtons.OKCancel);
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
                    g.DrawLine(new Pen(color,thickness),startpoint, endpoint);
                    canvas_graphics.Clear(Color.White);
                    canvas_graphics.DrawImage(canvas_img, 0, 0);
                    break;
                case "circle":
                    g.DrawEllipse(new Pen(color,thickness), new Rectangle(startpoint, new Size(endpoint.X-startpoint.X,
                        endpoint.Y-startpoint.Y)));
                    canvas_graphics.Clear(Color.White);
                    canvas_graphics.DrawImage(canvas_img, 0, 0);
                    break;
                case "rectangle":
                    g.DrawRectangle(new Pen(color, thickness), new Rectangle(startpoint, new Size(endpoint.X - startpoint.X,
                        endpoint.Y - startpoint.Y)));
                    canvas_graphics.Clear(Color.White);
                    canvas_graphics.DrawImage(canvas_img, 0, 0);
                    break;
                case "triangle":
                    Point[] corners = new Point[3];
                    corners[0] = startpoint;
                    corners[1] = endpoint;
                    corners[2] = new Point(startpoint.X - (endpoint.X - startpoint.X), endpoint.Y);
                    g.DrawPolygon(new Pen(color, thickness), corners);
                    canvas_graphics.Clear(Color.White);
                    canvas_graphics.DrawImage(canvas_img, 0, 0);
                    break;
                default:
                    break;
            }
        }

        private void brush_thickness_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;
            trackBar1.Visible = !trackBar1.Visible;
            if(trackBar1.Visible)
            {
                Graphics h = this.CreateGraphics();
                h.Clear(Color.Black);//only one button can be selected at a time
                h.FillRectangle(new SolidBrush(Color.Purple), new Rectangle(new Point(c.Location.X - 5, c.Location.Y - 5)
                    , new Size(c.Width + 10, c.Height + 10)));
            }
            else
            {
                Graphics h = this.CreateGraphics();
                h.Clear(Color.Black);//only one button can be selected at a time
            }
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
            canvas_graphics.Clear(Color.White);
            canvas_graphics.DrawImage(canvas_img, 0, 0);
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            color = canvas.BackColor;
        }

        private void change_background_Click(object sender, EventArgs e)
        {
            if (imported == false)
            {
                colorDialog2.ShowDialog();
                if (colorDialog2.Color != null)
                    canvas.BackColor = colorDialog2.Color;
                else
                    canvas.BackColor = Color.White;
                canvas_graphics.Clear(Color.White);
                canvas_graphics.DrawImage(canvas_img, 0, 0);
            }
            else
            {
                MessageBox.Show("Changing the background of an imported project is not currently supported");
            }
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
            {
                g.FillEllipse(new SolidBrush(color), new Rectangle(new Point(e.X, e.Y), new Size(thickness, thickness)));
                canvas_graphics.Clear(Color.White);
                canvas_graphics.DrawImage(canvas_img, 0, 0);
            }
        }
    }
}
