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
            this.brush_thickness = new System.Windows.Forms.PictureBox();
            this.eraser = new System.Windows.Forms.PictureBox();
            this.select_color = new System.Windows.Forms.PictureBox();
            this.clear_all = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.brush_thickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear_all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
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
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(27, 105);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(716, 423);
            this.canvas.TabIndex = 6;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(373, 25);
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(262, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 2;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1016, 558);
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
            ((System.ComponentModel.ISupportInitialize)(this.brush_thickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear_all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
    }
}