namespace TestCardApi
{
    partial class LargeImageViewer
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
            this.LargeImagePictureBox = new System.Windows.Forms.PictureBox();
            this.SoleContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClipboardSetImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClipBoardWidth180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.LargeImagePictureBox)).BeginInit();
            this.SoleContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LargeImagePictureBox
            // 
            this.LargeImagePictureBox.ContextMenuStrip = this.SoleContextMenuStrip;
            this.LargeImagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.LargeImagePictureBox.Name = "LargeImagePictureBox";
            this.LargeImagePictureBox.Size = new System.Drawing.Size(791, 426);
            this.LargeImagePictureBox.TabIndex = 0;
            this.LargeImagePictureBox.TabStop = false;
            // 
            // SoleContextMenuStrip
            // 
            this.SoleContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClipboardSetImageToolStripMenuItem,
            this.ClipBoardWidth180ToolStripMenuItem});
            this.SoleContextMenuStrip.Name = "SoleContextMenuStrip";
            this.SoleContextMenuStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // ClipboardSetImageToolStripMenuItem
            // 
            this.ClipboardSetImageToolStripMenuItem.Name = "ClipboardSetImageToolStripMenuItem";
            this.ClipboardSetImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClipboardSetImageToolStripMenuItem.Text = "クリップボードにコピー";
            this.ClipboardSetImageToolStripMenuItem.Click += new System.EventHandler(this.ClipboardSetImageToolStripMenuItem_Click);
            // 
            // ClipBoardWidth180ToolStripMenuItem
            // 
            this.ClipBoardWidth180ToolStripMenuItem.Name = "ClipBoardWidth180ToolStripMenuItem";
            this.ClipBoardWidth180ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClipBoardWidth180ToolStripMenuItem.Text = "横180でコピー";
            this.ClipBoardWidth180ToolStripMenuItem.Click += new System.EventHandler(this.ClipBoardWidth180ToolStripMenuItem_Click);
            // 
            // LargeImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 456);
            this.Controls.Add(this.LargeImagePictureBox);
            this.Name = "LargeImageViewer";
            this.Text = "LargeImageViewer";
            this.Load += new System.EventHandler(this.LargeImageViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LargeImagePictureBox)).EndInit();
            this.SoleContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LargeImagePictureBox;
        private System.Windows.Forms.ContextMenuStrip SoleContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClipboardSetImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClipBoardWidth180ToolStripMenuItem;
    }
}