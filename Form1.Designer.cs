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
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_text = new System.Windows.Forms.Button();
            this.btn_magnifier = new System.Windows.Forms.Button();
            this.btn_pickcolor = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tool_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 25);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // tool_panel
            // 
            this.tool_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tool_panel.Controls.Add(this.btn_magnifier);
            this.tool_panel.Controls.Add(this.btn_pickcolor);
            this.tool_panel.Controls.Add(this.btn_text);
            this.tool_panel.Controls.Add(this.label1);
            this.tool_panel.Controls.Add(this.btn_eraser);
            this.tool_panel.Controls.Add(this.btn_fill);
            this.tool_panel.Controls.Add(this.btn_pencil);
            this.tool_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_panel.Location = new System.Drawing.Point(0, 25);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(1198, 143);
            this.tool_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(352, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tools";
            // 
            // btn_text
            // 
            this.btn_text.BackColor = System.Drawing.Color.Transparent;
            this.btn_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_text.FlatAppearance.BorderSize = 0;
            this.btn_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_text.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_text.ForeColor = System.Drawing.Color.White;
            this.btn_text.Location = new System.Drawing.Point(408, 16);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(40, 40);
            this.btn_text.TabIndex = 4;
            this.btn_text.Text = "A";
            this.btn_text.UseVisualStyleBackColor = false;
            // 
            // btn_magnifier
            // 
            this.btn_magnifier.BackColor = System.Drawing.Color.Transparent;
            this.btn_magnifier.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._3440910_ecommerce_find_magnifier_search_seo_icon;
            this.btn_magnifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_magnifier.FlatAppearance.BorderSize = 0;
            this.btn_magnifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_magnifier.Location = new System.Drawing.Point(408, 64);
            this.btn_magnifier.Name = "btn_magnifier";
            this.btn_magnifier.Size = new System.Drawing.Size(40, 40);
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
            this.btn_pickcolor.Location = new System.Drawing.Point(360, 64);
            this.btn_pickcolor.Name = "btn_pickcolor";
            this.btn_pickcolor.Size = new System.Drawing.Size(40, 40);
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
            this.btn_eraser.Location = new System.Drawing.Point(312, 64);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(40, 40);
            this.btn_eraser.TabIndex = 2;
            this.btn_eraser.UseVisualStyleBackColor = false;
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.Transparent;
            this.btn_fill.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._34165_paint_icon;
            this.btn_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fill.FlatAppearance.BorderSize = 0;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.Location = new System.Drawing.Point(360, 16);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(40, 40);
            this.btn_fill.TabIndex = 1;
            this.btn_fill.UseVisualStyleBackColor = false;
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.Transparent;
            this.btn_pencil.BackgroundImage = global::Recreating_Paint_in_WinForm.Properties.Resources._285638_pencil_icon;
            this.btn_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pencil.FlatAppearance.BorderSize = 0;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.Location = new System.Drawing.Point(312, 16);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(40, 40);
            this.btn_pencil.TabIndex = 0;
            this.btn_pencil.UseVisualStyleBackColor = false;
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Location = new System.Drawing.Point(8, 176);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(800, 600);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1198, 879);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.tool_panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
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
    }
}

