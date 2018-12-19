namespace TestCardApi
{
    partial class IngameImageViewer
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
            this.IngameImagePictureBox = new System.Windows.Forms.PictureBox();
            this.SoleContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClipboardSetImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.IngameImagePictureBox)).BeginInit();
            this.SoleContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // IngameImagePictureBox
            // 
            this.IngameImagePictureBox.ContextMenuStrip = this.SoleContextMenuStrip;
            this.IngameImagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.IngameImagePictureBox.Name = "IngameImagePictureBox";
            this.IngameImagePictureBox.Size = new System.Drawing.Size(213, 175);
            this.IngameImagePictureBox.TabIndex = 0;
            this.IngameImagePictureBox.TabStop = false;
            // 
            // SoleContextMenuStrip
            // 
            this.SoleContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClipboardSetImageToolStripMenuItem});
            this.SoleContextMenuStrip.Name = "SoleContextMenuStrip";
            this.SoleContextMenuStrip.Size = new System.Drawing.Size(169, 26);
            // 
            // ClipboardSetImageToolStripMenuItem
            // 
            this.ClipboardSetImageToolStripMenuItem.Name = "ClipboardSetImageToolStripMenuItem";
            this.ClipboardSetImageToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ClipboardSetImageToolStripMenuItem.Text = "クリップボードにコピー";
            this.ClipboardSetImageToolStripMenuItem.Click += new System.EventHandler(this.ClipboardSetImageToolStripMenuItem_Click);
            // 
            // IngameImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 200);
            this.Controls.Add(this.IngameImagePictureBox);
            this.Name = "IngameImageViewer";
            this.Text = "IngameImageViewer";
            this.Load += new System.EventHandler(this.IngameImageViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IngameImagePictureBox)).EndInit();
            this.SoleContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IngameImagePictureBox;
        private System.Windows.Forms.ContextMenuStrip SoleContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClipboardSetImageToolStripMenuItem;
    }
}