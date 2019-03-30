namespace MiniPaint
{
    partial class MiniPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniPaint));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Colors = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.LoadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BrushButton = new System.Windows.Forms.ToolStripButton();
            this.RectangleButton = new System.Windows.Forms.ToolStripButton();
            this.EllipseButton = new System.Windows.Forms.ToolStripButton();
            this.ClearButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.ColorButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.EnglishButton = new System.Windows.Forms.ToolStripButton();
            this.PolishButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Colors.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.BottomToolStripPanel, "toolStripContainer1.BottomToolStripPanel");
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.LeftToolStripPanel, "toolStripContainer1.LeftToolStripPanel");
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.RightToolStripPanel, "toolStripContainer1.RightToolStripPanel");
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.TopToolStripPanel, "toolStripContainer1.TopToolStripPanel");
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Colors, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Colors
            // 
            resources.ApplyResources(this.Colors, "Colors");
            this.Colors.Controls.Add(this.flowLayoutPanel1);
            this.Colors.Name = "Colors";
            this.Colors.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.SaveButton,
            this.LoadButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.BrushButton,
            this.RectangleButton,
            this.EllipseButton,
            this.ClearButton,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripComboBox1,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.ColorButton,
            this.toolStripSeparator4,
            this.toolStripLabel5,
            this.EnglishButton,
            this.PolishButton});
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Stretch = true;
            // 
            // toolStripLabel2
            // 
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            this.toolStripLabel2.Name = "toolStripLabel2";
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            resources.ApplyResources(this.LoadButton, "LoadButton");
            this.LoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripLabel1
            // 
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            this.toolStripLabel1.Name = "toolStripLabel1";
            // 
            // BrushButton
            // 
            resources.ApplyResources(this.BrushButton, "BrushButton");
            this.BrushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BrushButton.Name = "BrushButton";
            this.BrushButton.Click += new System.EventHandler(this.ToolsClick);
            // 
            // RectangleButton
            // 
            resources.ApplyResources(this.RectangleButton, "RectangleButton");
            this.RectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Click += new System.EventHandler(this.ToolsClick);
            // 
            // EllipseButton
            // 
            resources.ApplyResources(this.EllipseButton, "EllipseButton");
            this.EllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Click += new System.EventHandler(this.ToolsClick);
            // 
            // ClearButton
            // 
            resources.ApplyResources(this.ClearButton, "ClearButton");
            this.ClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripLabel3
            // 
            resources.ApplyResources(this.toolStripLabel3, "toolStripLabel3");
            this.toolStripLabel3.Name = "toolStripLabel3";
            // 
            // toolStripComboBox1
            // 
            resources.ApplyResources(this.toolStripComboBox1, "toolStripComboBox1");
            this.toolStripComboBox1.Items.AddRange(new object[] {
            resources.GetString("toolStripComboBox1.Items"),
            resources.GetString("toolStripComboBox1.Items1"),
            resources.GetString("toolStripComboBox1.Items2")});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripLabel4
            // 
            resources.ApplyResources(this.toolStripLabel4, "toolStripLabel4");
            this.toolStripLabel4.Name = "toolStripLabel4";
            // 
            // ColorButton
            // 
            resources.ApplyResources(this.ColorButton, "ColorButton");
            this.ColorButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.ColorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ColorButton.Name = "ColorButton";
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // toolStripLabel5
            // 
            resources.ApplyResources(this.toolStripLabel5, "toolStripLabel5");
            this.toolStripLabel5.Name = "toolStripLabel5";
            // 
            // EnglishButton
            // 
            resources.ApplyResources(this.EnglishButton, "EnglishButton");
            this.EnglishButton.Checked = true;
            this.EnglishButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnglishButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Click += new System.EventHandler(this.EnglishButton_Click);
            // 
            // PolishButton
            // 
            resources.ApplyResources(this.PolishButton, "PolishButton");
            this.PolishButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolishButton.Name = "PolishButton";
            this.PolishButton.Click += new System.EventHandler(this.PolishButton_Click);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            this.saveFileDialog1.FilterIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // MiniPaint
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MiniPaint";
            this.SizeChanged += new System.EventHandler(this.MiniPaint_SizeChanged);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Colors.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton BrushButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Colors;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton LoadButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RectangleButton;
        private System.Windows.Forms.ToolStripButton EllipseButton;
        private System.Windows.Forms.ToolStripButton ClearButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton ColorButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton PolishButton;
        private System.Windows.Forms.ToolStripButton EnglishButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

