namespace TestCardApi
{
    partial class CardDetailViewer
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
            this.SoleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AttackTextBox = new System.Windows.Forms.TextBox();
            this.ArmorTextBox = new System.Windows.Forms.TextBox();
            this.HitPointsTextBox = new System.Windows.Forms.TextBox();
            this.CardNameTextBox = new System.Windows.Forms.TextBox();
            this.CopyToClipboardCardNameButton = new System.Windows.Forms.Button();
            this.CardInfoTextBox = new System.Windows.Forms.TextBox();
            this.CopyToClipboardCardInfoButton = new System.Windows.Forms.Button();
            this.SoleTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoleTableLayoutPanel
            // 
            this.SoleTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoleTableLayoutPanel.ColumnCount = 2;
            this.SoleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SoleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SoleTableLayoutPanel.Controls.Add(this.label1, 0, 2);
            this.SoleTableLayoutPanel.Controls.Add(this.label2, 0, 3);
            this.SoleTableLayoutPanel.Controls.Add(this.label3, 0, 4);
            this.SoleTableLayoutPanel.Controls.Add(this.AttackTextBox, 1, 2);
            this.SoleTableLayoutPanel.Controls.Add(this.ArmorTextBox, 1, 3);
            this.SoleTableLayoutPanel.Controls.Add(this.HitPointsTextBox, 1, 4);
            this.SoleTableLayoutPanel.Controls.Add(this.CardNameTextBox, 1, 0);
            this.SoleTableLayoutPanel.Controls.Add(this.CopyToClipboardCardNameButton, 0, 0);
            this.SoleTableLayoutPanel.Controls.Add(this.CardInfoTextBox, 1, 1);
            this.SoleTableLayoutPanel.Controls.Add(this.CopyToClipboardCardInfoButton, 0, 1);
            this.SoleTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.SoleTableLayoutPanel.Name = "SoleTableLayoutPanel";
            this.SoleTableLayoutPanel.RowCount = 5;
            this.SoleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.SoleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.SoleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.SoleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.SoleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SoleTableLayoutPanel.Size = new System.Drawing.Size(776, 245);
            this.SoleTableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "attack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "armor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "hit_points";
            // 
            // AttackTextBox
            // 
            this.AttackTextBox.Location = new System.Drawing.Point(391, 97);
            this.AttackTextBox.Name = "AttackTextBox";
            this.AttackTextBox.Size = new System.Drawing.Size(100, 19);
            this.AttackTextBox.TabIndex = 3;
            // 
            // ArmorTextBox
            // 
            this.ArmorTextBox.Location = new System.Drawing.Point(391, 144);
            this.ArmorTextBox.Name = "ArmorTextBox";
            this.ArmorTextBox.Size = new System.Drawing.Size(100, 19);
            this.ArmorTextBox.TabIndex = 4;
            // 
            // HitPointsTextBox
            // 
            this.HitPointsTextBox.Location = new System.Drawing.Point(391, 221);
            this.HitPointsTextBox.Name = "HitPointsTextBox";
            this.HitPointsTextBox.Size = new System.Drawing.Size(100, 19);
            this.HitPointsTextBox.TabIndex = 5;
            // 
            // CardNameTextBox
            // 
            this.CardNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CardNameTextBox.Location = new System.Drawing.Point(391, 16);
            this.CardNameTextBox.Name = "CardNameTextBox";
            this.CardNameTextBox.Size = new System.Drawing.Size(350, 19);
            this.CardNameTextBox.TabIndex = 6;
            // 
            // CopyToClipboardCardNameButton
            // 
            this.CopyToClipboardCardNameButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CopyToClipboardCardNameButton.Location = new System.Drawing.Point(253, 14);
            this.CopyToClipboardCardNameButton.Name = "CopyToClipboardCardNameButton";
            this.CopyToClipboardCardNameButton.Size = new System.Drawing.Size(132, 23);
            this.CopyToClipboardCardNameButton.TabIndex = 7;
            this.CopyToClipboardCardNameButton.Text = "クリップボードにコピー";
            this.CopyToClipboardCardNameButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardCardNameButton.Click += new System.EventHandler(this.CopyToClipboardCardNameButton_Click);
            // 
            // CardInfoTextBox
            // 
            this.CardInfoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CardInfoTextBox.Location = new System.Drawing.Point(391, 63);
            this.CardInfoTextBox.Name = "CardInfoTextBox";
            this.CardInfoTextBox.Size = new System.Drawing.Size(350, 19);
            this.CardInfoTextBox.TabIndex = 8;
            // 
            // CopyToClipboardCardInfoButton
            // 
            this.CopyToClipboardCardInfoButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CopyToClipboardCardInfoButton.Location = new System.Drawing.Point(253, 61);
            this.CopyToClipboardCardInfoButton.Name = "CopyToClipboardCardInfoButton";
            this.CopyToClipboardCardInfoButton.Size = new System.Drawing.Size(132, 23);
            this.CopyToClipboardCardInfoButton.TabIndex = 9;
            this.CopyToClipboardCardInfoButton.Text = "クリップボードにコピー";
            this.CopyToClipboardCardInfoButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardCardInfoButton.Click += new System.EventHandler(this.CopyToClipboardCardInfoButton_Click);
            // 
            // CardDetailViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 269);
            this.Controls.Add(this.SoleTableLayoutPanel);
            this.Name = "CardDetailViewer";
            this.Text = "CardDetailViewer";
            this.Load += new System.EventHandler(this.CardDetailViewer_Load);
            this.SoleTableLayoutPanel.ResumeLayout(false);
            this.SoleTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SoleTableLayoutPanel;
        private System.Windows.Forms.TextBox AttackTextBox;
        private System.Windows.Forms.TextBox ArmorTextBox;
        private System.Windows.Forms.TextBox HitPointsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CardNameTextBox;
        private System.Windows.Forms.Button CopyToClipboardCardNameButton;
        private System.Windows.Forms.TextBox CardInfoTextBox;
        private System.Windows.Forms.Button CopyToClipboardCardInfoButton;
    }
}