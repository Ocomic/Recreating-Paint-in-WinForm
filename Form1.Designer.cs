namespace Recreating_Paint_in_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_text = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.coordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.triangleBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_magnifier = new System.Windows.Forms.Button();
            this.btn_pickcolor = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tool_panel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1797, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(162, 36);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(162, 36);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(162, 36);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(69, 34);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tool_panel
            // 
            this.tool_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tool_panel.Controls.Add(this.triangleBtn);
            this.tool_panel.Controls.Add(this.lineBtn);
            this.tool_panel.Controls.Add(this.ellipseBtn);
            this.tool_panel.Controls.Add(this.btnRectangle);
            this.tool_panel.Controls.Add(this.button1);
            this.tool_panel.Controls.Add(this.label2);
            this.tool_panel.Controls.Add(this.comboBox1);
            this.tool_panel.Controls.Add(this.btn_magnifier);
            this.tool_panel.Controls.Add(this.btn_pickcolor);
            this.tool_panel.Controls.Add(this.btn_text);
            this.tool_panel.Controls.Add(this.label1);
            this.tool_panel.Controls.Add(this.btn_eraser);
            this.tool_panel.Controls.Add(this.btn_fill);
            this.tool_panel.Controls.Add(this.btn_pencil);
            this.tool_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_panel.Location = new System.Drawing.Point(0, 38);
            this.tool_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(1797, 220);
            this.tool_panel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1072, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Size:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "10",
            "25",
            "50",
            "100",
            "200",
            "500"});
            this.comboBox1.Location = new System.Drawing.Point(1072, 61);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_text
            // 
            this.btn_text.BackColor = System.Drawing.Color.Transparent;
            this.btn_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_text.FlatAppearance.BorderSize = 0;
            this.btn_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_text.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_text.ForeColor = System.Drawing.Color.White;
            this.btn_text.Location = new System.Drawing.Point(612, 25);
            this.btn_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(60, 62);
            this.btn_text.TabIndex = 4;
            this.btn_text.Text = "A";
            this.btn_text.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(528, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tools";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordinates});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1797, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // coordinates
            // 
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(33, 25);
            this.coordinates.Text = "XY";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Location = new System.Drawing.Point(12, 271);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1372, 923);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // triangleBtn
            // 
            this.triangleBtn.BackColor = System.Drawing.Color.Transparent;
            this.triangleBtn.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._8726558_triangle_icon;
            this.triangleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.triangleBtn.FlatAppearance.BorderSize = 0;
            this.triangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangleBtn.Location = new System.Drawing.Point(688, 104);
            this.triangleBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(60, 62);
            this.triangleBtn.TabIndex = 13;
            this.triangleBtn.UseVisualStyleBackColor = false;
            this.triangleBtn.Click += new System.EventHandler(this.triangleBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.BackColor = System.Drawing.Color.Transparent;
            this.lineBtn.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._8726075_line_alt_icon;
            this.lineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lineBtn.FlatAppearance.BorderSize = 0;
            this.lineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineBtn.Location = new System.Drawing.Point(848, 24);
            this.lineBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(60, 62);
            this.lineBtn.TabIndex = 12;
            this.lineBtn.UseVisualStyleBackColor = false;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.BackColor = System.Drawing.Color.Transparent;
            this.ellipseBtn.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._79641_draw_ellipse_icon;
            this.ellipseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ellipseBtn.FlatAppearance.BorderSize = 0;
            this.ellipseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseBtn.Location = new System.Drawing.Point(768, 24);
            this.ellipseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(60, 62);
            this.ellipseBtn.TabIndex = 11;
            this.ellipseBtn.UseVisualStyleBackColor = false;
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Transparent;
            this.btnRectangle.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._79511_draw_rectangle_icon;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Location = new System.Drawing.Point(688, 24);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(60, 62);
            this.btnRectangle.TabIndex = 10;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._45101_palette_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1072, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 62);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_magnifier
            // 
            this.btn_magnifier.BackColor = System.Drawing.Color.Transparent;
            this.btn_magnifier.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._3440910_ecommerce_find_magnifier_search_seo_icon;
            this.btn_magnifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_magnifier.FlatAppearance.BorderSize = 0;
            this.btn_magnifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_magnifier.Location = new System.Drawing.Point(612, 98);
            this.btn_magnifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_magnifier.Name = "btn_magnifier";
            this.btn_magnifier.Size = new System.Drawing.Size(60, 62);
            this.btn_magnifier.TabIndex = 6;
            this.btn_magnifier.UseVisualStyleBackColor = false;
            // 
            // btn_pickcolor
            // 
            this.btn_pickcolor.BackColor = System.Drawing.Color.Transparent;
            this.btn_pickcolor.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._3380386_eye_dropper_pipette_color_medical_icon;
            this.btn_pickcolor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pickcolor.FlatAppearance.BorderSize = 0;
            this.btn_pickcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pickcolor.Location = new System.Drawing.Point(540, 98);
            this.btn_pickcolor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pickcolor.Name = "btn_pickcolor";
            this.btn_pickcolor.Size = new System.Drawing.Size(60, 62);
            this.btn_pickcolor.TabIndex = 5;
            this.btn_pickcolor.UseVisualStyleBackColor = false;
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.Transparent;
            this.btn_eraser.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._46845_documents_draft_eraser_icon;
            this.btn_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_eraser.FlatAppearance.BorderSize = 0;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.Location = new System.Drawing.Point(468, 98);
            this.btn_eraser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(60, 62);
            this.btn_eraser.TabIndex = 2;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.Transparent;
            this.btn_fill.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._34165_paint_icon;
            this.btn_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fill.FlatAppearance.BorderSize = 0;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.Location = new System.Drawing.Point(540, 25);
            this.btn_fill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(60, 62);
            this.btn_fill.TabIndex = 1;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.Transparent;
            this.btn_pencil.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._285638_pencil_icon;
            this.btn_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pencil.FlatAppearance.BorderSize = 0;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.Location = new System.Drawing.Point(468, 25);
            this.btn_pencil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(60, 62);
            this.btn_pencil.TabIndex = 0;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1797, 1352);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.tool_panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel tool_panel;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_magnifier;
        private System.Windows.Forms.Button btn_pickcolor;
        private System.Windows.Forms.Button btn_text;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel coordinates;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.Button triangleBtn;
        private System.Windows.Forms.Button lineBtn;
    }
}

