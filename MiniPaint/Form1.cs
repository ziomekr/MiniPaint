using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class MiniPaint : Form
    {
        Bitmap PaintArea;
        Point lastPoint = Point.Empty;
        Label activeColor;
        bool isMouseDown = false;
        int thickness = 2;
        public MiniPaint()
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("en");
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = thickness - 1;
            InitializeCanvas();
            AddColors();
        }

        private void InitializeCanvas()
        {
            PaintArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            using (Graphics g = Graphics.FromImage(PaintArea))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Image = PaintArea;
        }

        private void ChangeLanguage(String lang)
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture(lang);
            ComponentResourceManager crm = new ComponentResourceManager(typeof(MiniPaint));
            //var OldThickness = toolStripComboBox1.SelectedIndex;
            foreach (ToolStripItem t in toolStrip1.Items)
            {
                crm.ApplyResources(t, t.Name);
            }
            crm.ApplyResources(Colors, Colors.Name);
            //toolStripComboBox1.SelectedIndex = OldThickness;
            //toolStripComboBox1.Invalidate();
        }
       
        private void AddColors()
        {
            ColorButton.BackColor = Color.Black;
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                Bitmap back = new Bitmap(25, 25);
                using (Graphics g = Graphics.FromImage(back))
                {
                    g.Clear(Color.FromKnownColor(color));
                }
                Label l = new Label();
                l.Size = new Size(25, 25);
                l.FlatStyle = FlatStyle.Flat;
                l.Margin = new Padding(3);
                l.Image = back;
                l.BackColor = Color.FromKnownColor(color);
                if (l.BackColor == Color.Black)
                {
                    activeColor = l;
                    Color_Label_Click(activeColor, new EventArgs());
                }
                l.Click += new EventHandler(this.Color_Label_Click);
                flowLayoutPanel1.Controls.Add(l);
            }
        }
        private void Color_Label_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            using (Graphics g = Graphics.FromImage(activeColor.Image))
            {
                g.Clear(activeColor.BackColor);
            }
            activeColor = l;
            using (Graphics g = Graphics.FromImage(activeColor.Image))
            {
                Color c = Color.FromArgb(activeColor.BackColor.ToArgb() ^ 0xffffff);
                Pen p = new Pen(c, 3);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawRectangle(p, 1, 1, 22, 22);
                p.Dispose();
            }
            ColorButton.BackColor = activeColor.BackColor;
            flowLayoutPanel1.Refresh();
        }


        private void LineDraw(Point p)
        {

            if (lastPoint != Point.Empty)

            {

                using (Graphics g = Graphics.FromImage(pictureBox1.Image))

                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawLine(new Pen(activeColor.BackColor, thickness), lastPoint, p);
                    
                }

                lastPoint = p;
                pictureBox1.Refresh();
                    
            }
        }

        private Point ValidStart(Point p)
        {
            return new Point(lastPoint.X < p.X ? lastPoint.X : p.X, 
                lastPoint.Y < p.Y ? lastPoint.Y : p.Y);
        }

        private void RectangleDraw(Point p)
        {
            if (lastPoint != Point.Empty)

            {
                Bitmap temp = new Bitmap(PaintArea);

                using (Graphics g = Graphics.FromImage(temp))

                {
                    Point valid = ValidStart(p);
                    g.DrawRectangle(new Pen(activeColor.BackColor, thickness), valid.X, valid.Y, Math.Abs(lastPoint.X - p.X), Math.Abs(lastPoint.Y - p.Y));
                    
                }
                pictureBox1.Image = temp;
                pictureBox1.Refresh();
                System.GC.Collect();

            }
        }

        private void EllipseDraw(Point p)
        {
            if (lastPoint != Point.Empty)

            {
                Bitmap temp = new Bitmap(PaintArea);

                using (Graphics g = Graphics.FromImage(temp))

                {
                    Point valid = ValidStart(p);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawEllipse(new Pen(activeColor.BackColor, thickness), valid.X, valid.Y, Math.Abs(lastPoint.X - p.X), Math.Abs(lastPoint.Y - p.Y));
                    
                }

                pictureBox1.Image = temp;
                pictureBox1.Refresh();
                System.GC.Collect();
            }
        }

     
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (isMouseDown) {

                if (BrushButton.Checked)
                    LineDraw(e.Location);
                else if (RectangleButton.Checked)
                    RectangleDraw(e.Location);
                else if (EllipseButton.Checked)
                    EllipseDraw(e.Location);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = e.Location;
                isMouseDown = true;
            }

            else if (e.Button == MouseButtons.Right)
            {
                lastPoint = Point.Empty;
                isMouseDown = false;
                pictureBox1.Image = PaintArea;
            }
 
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = Point.Empty;
                isMouseDown = false;
                PaintArea = (Bitmap)pictureBox1.Image;
            }
        }

        private void ToolsClick(object sender, EventArgs e)
        {
            ToolStripButton clicked = (ToolStripButton)sender;
            if (clicked.Checked)
            {
                clicked.Checked = false;
                return;
            }
            List<ToolStripButton> buttons = new List<ToolStripButton> { BrushButton, RectangleButton, EllipseButton };
            foreach (ToolStripButton b in buttons)
            {
                b.Checked = false;
            }
            clicked.Checked = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InitializeCanvas();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            thickness = toolStripComboBox1.SelectedIndex + 1;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap toLoad = new Bitmap(openFileDialog1.FileName);
                Size max = SystemInformation.MaxWindowTrackSize;
                if (toLoad.Size.Height > max.Height || toLoad.Width > max.Width)
                {
                    this.Size = max;
                    toLoad = new Bitmap(toLoad, pictureBox1.Size);
                    PaintArea = toLoad;
                    pictureBox1.Image = PaintArea;
                    pictureBox1.Refresh();
                    this.Invalidate();
                }
                else
                {
                    Size diff = toLoad.Size - PaintArea.Size;
                    this.SizeChanged -= MiniPaint_SizeChanged;
                    PaintArea = toLoad;
                    pictureBox1.Size = PaintArea.Size;
                    pictureBox1.Image = PaintArea;
                    pictureBox1.Refresh();
                    this.Size = this.Size + diff;
                    this.Invalidate();
                    this.SizeChanged += MiniPaint_SizeChanged;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ImageFormat format = ImageFormat.Bmp;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                switch (saveFileDialog1.FilterIndex)
                {
                    case 0:
                        format = ImageFormat.Bmp;
                        break;
                    case 1:
                        format = ImageFormat.Jpeg;
                        break;
                    case 2:
                        format = ImageFormat.Png;
                        break;
                }
                
                PaintArea.Save(saveFileDialog1.FileName, format);
            }
        }

        private void MiniPaint_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))

            {
                g.Clear(Color.White);
                g.DrawImageUnscaled(PaintArea, 0, 0);
            }

            PaintArea = (Bitmap)pictureBox1.Image;
            
        }

        private void EnglishButton_Click(object sender, EventArgs e)
        {
            if (EnglishButton.Checked)
                return;
            ChangeLanguage("en");
            PolishButton.Checked = false;
            EnglishButton.Checked = true;
        }

        private void PolishButton_Click(object sender, EventArgs e)
        {
            if (PolishButton.Checked)
                return;
            ChangeLanguage("pl-PL");
            PolishButton.Checked = true;
            EnglishButton.Checked = false;
        }
    }
}
