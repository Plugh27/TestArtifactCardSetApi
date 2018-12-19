namespace TestCardApi
{
    partial class MiniImageViewer
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
            this.components = new System.ComponentModel.Container();
            this.MiniImagePictureBox = new System.Windows.Forms.PictureBox();
            this.SoleContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClipboardSetImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clipboard64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clipboard128ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MiniImagePictureBox)).BeginInit();
            this.SoleContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MiniImagePictureBox
            // 
            this.MiniImagePictureBox.ContextMenuStrip = this.SoleContextMenuStrip;
            this.MiniImagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.MiniImagePictureBox.Name = "MiniImagePictureBox";
            this.MiniImagePictureBox.Size = new System.Drawing.Size(256, 223);
            this.MiniImagePictureBox.TabIndex = 0;
            this.MiniImagePictureBox.TabStop = false;
            // 
            // SoleContextMenuStrip
            // 
            this.SoleContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClipboardSetImageToolStripMenuItem,
            this.Clipboard64ToolStripMenuItem,
            this.Clipboard128ToolStripMenuItem});
            this.SoleContextMenuStrip.Name = "SoleContextMenuStrip";
            this.SoleContextMenuStrip.Size = new System.Drawing.Size(169, 70);
            // 
            // ClipboardSetImageToolStripMenuItem
            // 
            this.ClipboardSetImageToolStripMenuItem.Name = "ClipboardSetImageToolStripMenuItem";
            this.ClipboardSetImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClipboardSetImageToolStripMenuItem.Text = "クリップボードにコピー";
            this.ClipboardSetImageToolStripMenuItem.Click += new System.EventHandler(this.ClipboardSetImageToolStripMenuItem_Click);
            // 
            // Clipboard64ToolStripMenuItem
            // 
            this.Clipboard64ToolStripMenuItem.Name = "Clipboard64ToolStripMenuItem";
            this.Clipboard64ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Clipboard64ToolStripMenuItem.Text = "64x64でコピー";
            this.Clipboard64ToolStripMenuItem.Click += new System.EventHandler(this.Clipboard64ToolStripMenuItem_Click);
            // 
            // Clipboard128ToolStripMenuItem
            // 
            this.Clipboard128ToolStripMenuItem.Name = "Clipboard128ToolStripMenuItem";
            this.Clipboard128ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.Clipboard128ToolStripMenuItem.Text = "128x128でコピー";
            this.Clipboard128ToolStripMenuItem.Click += new System.EventHandler(this.Clipboard128ToolStripMenuItem_Click);
            // 
            // MiniImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 259);
            this.Controls.Add(this.MiniImagePictureBox);
            this.Name = "MiniImageViewer";
            this.Text = "MiniImageViewer";
            this.Load += new System.EventHandler(this.MiniImageViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MiniImagePictureBox)).EndInit();
            this.SoleContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MiniImagePictureBox;
        private System.Windows.Forms.ContextMenuStrip SoleContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClipboardSetImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Clipboard64ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Clipboard128ToolStripMenuItem;
    }
}