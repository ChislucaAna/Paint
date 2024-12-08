namespace PaintApp
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.triangle = new System.Windows.Forms.PictureBox();
            this.circle = new System.Windows.Forms.PictureBox();
            this.rectangle = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.free = new System.Windows.Forms.PictureBox();
            this.change_background = new System.Windows.Forms.PictureBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.brush_thickness = new System.Windows.Forms.PictureBox();
            this.eraser = new System.Windows.Forms.PictureBox();
            this.select_color = new System.Windows.Forms.PictureBox();
            this.clear_all = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.free)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.change_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brush_thickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear_all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(749, 20);
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(241, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 2;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // triangle
            // 
            this.triangle.Image = global::PaintApp.Properties.Resources.triangle;
            this.triangle.Location = new System.Drawing.Point(919, 295);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(50, 50);
            this.triangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.triangle.TabIndex = 13;
            this.triangle.TabStop = false;
            this.triangle.Click += new System.EventHandler(this.selected_tool_changed);
            // 
            // circle
            // 
            this.circle.Image = global::PaintApp.Properties.Resources.circle;
            this.circle.Location = new System.Drawing.Point(919, 239);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(50, 50);
            this.circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circle.TabIndex = 12;
            this.circle.TabStop = false;
            this.circle.Click += new System.EventHandler(this.selected_tool_changed);
            // 
            // rectangle
            // 
            this.rectangle.Image = global::PaintApp.Properties.Resources.rectangle;
            this.rectangle.Location = new System.Drawing.Point(919, 183);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(50, 50);
            this.rectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rectangle.TabIndex = 11;
            this.rectangle.TabStop = false;
            this.rectangle.Click += new System.EventHandler(this.selected_tool_changed);
            // 
            // line
            // 
            this.line.Image = global::PaintApp.Properties.Resources.line;
            this.line.Location = new System.Drawing.Point(919, 127);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(50, 50);
            this.line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.line.TabIndex = 10;
            this.line.TabStop = false;
            this.line.Click += new System.EventHandler(this.selected_tool_changed);
            // 
            // free
            // 
            this.free.Image = global::PaintApp.Properties.Resources.free_drawing;
            this.free.Location = new System.Drawing.Point(919, 71);
            this.free.Name = "free";
            this.free.Size = new System.Drawing.Size(50, 50);
            this.free.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.free.TabIndex = 9;
            this.free.TabStop = false;
            this.free.Click += new System.EventHandler(this.selected_tool_changed);
            // 
            // change_background
            // 
            this.change_background.Image = global::PaintApp.Properties.Resources.background_color;
            this.change_background.Location = new System.Drawing.Point(363, 20);
            this.change_background.Name = "change_background";
            this.change_background.Size = new System.Drawing.Size(50, 50);
            this.change_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.change_background.TabIndex = 8;
            this.change_background.TabStop = false;
            this.change_background.Click += new System.EventHandler(this.change_background_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(27, 105);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(716, 423);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canvas.TabIndex = 6;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // brush_thickness
            // 
            this.brush_thickness.Image = global::PaintApp.Properties.Resources.select_thickness;
            this.brush_thickness.Location = new System.Drawing.Point(307, 20);
            this.brush_thickness.Name = "brush_thickness";
            this.brush_thickness.Size = new System.Drawing.Size(50, 50);
            this.brush_thickness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brush_thickness.TabIndex = 5;
            this.brush_thickness.TabStop = false;
            this.brush_thickness.Click += new System.EventHandler(this.brush_thickness_Click);
            // 
            // eraser
            // 
            this.eraser.Image = global::PaintApp.Properties.Resources.eraser;
            this.eraser.Location = new System.Drawing.Point(251, 20);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(50, 50);
            this.eraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eraser.TabIndex = 4;
            this.eraser.TabStop = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // select_color
            // 
            this.select_color.Image = global::PaintApp.Properties.Resources.select_color;
            this.select_color.Location = new System.Drawing.Point(195, 20);
            this.select_color.Name = "select_color";
            this.select_color.Size = new System.Drawing.Size(50, 50);
            this.select_color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.select_color.TabIndex = 3;
            this.select_color.TabStop = false;
            this.select_color.Click += new System.EventHandler(this.colorpicker_Click);
            // 
            // clear_all
            // 
            this.clear_all.Image = global::PaintApp.Properties.Resources.clear_all;
            this.clear_all.Location = new System.Drawing.Point(139, 21);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(50, 50);
            this.clear_all.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clear_all.TabIndex = 2;
            this.clear_all.TabStop = false;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // save
            // 
            this.save.Image = global::PaintApp.Properties.Resources.save;
            this.save.Location = new System.Drawing.Point(83, 21);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(50, 50);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.save.TabIndex = 1;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.Image = global::PaintApp.Properties.Resources.close;
            this.exit.Location = new System.Drawing.Point(27, 21);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 50);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1016, 558);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.line);
            this.Controls.Add(this.free);
            this.Controls.Add(this.change_background);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.brush_thickness);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.select_color);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.free)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.change_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brush_thickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear_all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.PictureBox clear_all;
        private System.Windows.Forms.PictureBox select_color;
        private System.Windows.Forms.PictureBox eraser;
        private System.Windows.Forms.PictureBox brush_thickness;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox change_background;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.PictureBox free;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.PictureBox rectangle;
        private System.Windows.Forms.PictureBox circle;
        private System.Windows.Forms.PictureBox triangle;
    }
}