namespace TestCardApi
{
    partial class ReferencesViewer
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
            this.SoleListView = new BrightIdeasSoftware.ObjectListView();
            ((System.ComponentModel.ISupportInitialize)(this.SoleListView)).BeginInit();
            this.SuspendLayout();
            // 
            // SoleListView
            // 
            this.SoleListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoleListView.CellEditUseWholeCell = false;
            this.SoleListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.SoleListView.Location = new System.Drawing.Point(12, 12);
            this.SoleListView.Name = "SoleListView";
            this.SoleListView.Size = new System.Drawing.Size(776, 426);
            this.SoleListView.TabIndex = 0;
            this.SoleListView.UseCompatibleStateImageBehavior = false;
            this.SoleListView.View = System.Windows.Forms.View.Details;
            // 
            // ReferencesViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SoleListView);
            this.Name = "ReferencesViewer";
            this.Text = "ReferencesViewer";
            this.Load += new System.EventHandler(this.ReferencesViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoleListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView SoleListView;
    }
}