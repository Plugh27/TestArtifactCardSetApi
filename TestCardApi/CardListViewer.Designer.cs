namespace TestCardApi
{
    partial class CardListViewer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GreenCheckBox = new System.Windows.Forms.CheckBox();
            this.BlackCheckBox = new System.Windows.Forms.CheckBox();
            this.RedCheckBox = new System.Windows.Forms.CheckBox();
            this.BlueCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterSpecificColorCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PassiveAbilityCheckBox = new System.Windows.Forms.CheckBox();
            this.ItemCheckBox = new System.Windows.Forms.CheckBox();
            this.AbilityCheckBox = new System.Windows.Forms.CheckBox();
            this.SpellCheckBox = new System.Windows.Forms.CheckBox();
            this.ImprovementCheckBox = new System.Windows.Forms.CheckBox();
            this.CreepCheckBox = new System.Windows.Forms.CheckBox();
            this.HeroCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterSpecificCardTypeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SoleListView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoleListView
            // 
            this.SoleListView.CellEditUseWholeCell = false;
            this.SoleListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.SoleListView.Location = new System.Drawing.Point(12, 87);
            this.SoleListView.Name = "SoleListView";
            this.SoleListView.Size = new System.Drawing.Size(776, 454);
            this.SoleListView.TabIndex = 0;
            this.SoleListView.UseCompatibleStateImageBehavior = false;
            this.SoleListView.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GreenCheckBox);
            this.groupBox1.Controls.Add(this.BlackCheckBox);
            this.groupBox1.Controls.Add(this.RedCheckBox);
            this.groupBox1.Controls.Add(this.BlueCheckBox);
            this.groupBox1.Controls.Add(this.FilterSpecificColorCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "特定の色のみ表示する";
            // 
            // GreenCheckBox
            // 
            this.GreenCheckBox.AutoSize = true;
            this.GreenCheckBox.Checked = true;
            this.GreenCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GreenCheckBox.Location = new System.Drawing.Point(48, 40);
            this.GreenCheckBox.Name = "GreenCheckBox";
            this.GreenCheckBox.Size = new System.Drawing.Size(36, 16);
            this.GreenCheckBox.TabIndex = 14;
            this.GreenCheckBox.Text = "緑";
            this.GreenCheckBox.UseVisualStyleBackColor = true;
            this.GreenCheckBox.CheckedChanged += new System.EventHandler(this.FilterSpecificColorControl_CheckedChanged);
            // 
            // BlackCheckBox
            // 
            this.BlackCheckBox.AutoSize = true;
            this.BlackCheckBox.Checked = true;
            this.BlackCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BlackCheckBox.Location = new System.Drawing.Point(132, 40);
            this.BlackCheckBox.Name = "BlackCheckBox";
            this.BlackCheckBox.Size = new System.Drawing.Size(36, 16);
            this.BlackCheckBox.TabIndex = 13;
            this.BlackCheckBox.Text = "黒";
            this.BlackCheckBox.UseVisualStyleBackColor = true;
            this.BlackCheckBox.CheckedChanged += new System.EventHandler(this.FilterSpecificColorControl_CheckedChanged);
            // 
            // RedCheckBox
            // 
            this.RedCheckBox.AutoSize = true;
            this.RedCheckBox.Checked = true;
            this.RedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RedCheckBox.Location = new System.Drawing.Point(6, 40);
            this.RedCheckBox.Name = "RedCheckBox";
            this.RedCheckBox.Size = new System.Drawing.Size(36, 16);
            this.RedCheckBox.TabIndex = 12;
            this.RedCheckBox.Text = "赤";
            this.RedCheckBox.UseVisualStyleBackColor = true;
            this.RedCheckBox.CheckedChanged += new System.EventHandler(this.FilterSpecificColorControl_CheckedChanged);
            // 
            // BlueCheckBox
            // 
            this.BlueCheckBox.AutoSize = true;
            this.BlueCheckBox.Checked = true;
            this.BlueCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BlueCheckBox.Location = new System.Drawing.Point(90, 40);
            this.BlueCheckBox.Name = "BlueCheckBox";
            this.BlueCheckBox.Size = new System.Drawing.Size(36, 16);
            this.BlueCheckBox.TabIndex = 11;
            this.BlueCheckBox.Text = "青";
            this.BlueCheckBox.UseVisualStyleBackColor = true;
            this.BlueCheckBox.CheckedChanged += new System.EventHandler(this.FilterSpecificColorControl_CheckedChanged);
            // 
            // FilterSpecificColorCheckBox
            // 
            this.FilterSpecificColorCheckBox.AutoSize = true;
            this.FilterSpecificColorCheckBox.Location = new System.Drawing.Point(6, 18);
            this.FilterSpecificColorCheckBox.Name = "FilterSpecificColorCheckBox";
            this.FilterSpecificColorCheckBox.Size = new System.Drawing.Size(48, 16);
            this.FilterSpecificColorCheckBox.TabIndex = 10;
            this.FilterSpecificColorCheckBox.Text = "有効";
            this.FilterSpecificColorCheckBox.UseVisualStyleBackColor = true;
            this.FilterSpecificColorCheckBox.CheckedChanged += new System.EventHandler(this.FilterSpecificColorControl_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PassiveAbilityCheckBox);
            this.groupBox2.Controls.Add(this.ItemCheckBox);
            this.groupBox2.Controls.Add(this.AbilityCheckBox);
            this.groupBox2.Controls.Add(this.SpellCheckBox);
            this.groupBox2.Controls.Add(this.ImprovementCheckBox);
            this.groupBox2.Controls.Add(this.CreepCheckBox);
            this.groupBox2.Controls.Add(this.HeroCheckBox);
            this.groupBox2.Controls.Add(this.FilterSpecificCardTypeCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(239, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 69);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "特定のカードタイプのみ表示する";
            // 
            // PassiveAbilityCheckBox
            // 
            this.PassiveAbilityCheckBox.AutoSize = true;
            this.PassiveAbilityCheckBox.Checked = true;
            this.PassiveAbilityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PassiveAbilityCheckBox.Location = new System.Drawing.Point(387, 40);
            this.PassiveAbilityCheckBox.Name = "PassiveAbilityCheckBox";
            this.PassiveAbilityCheckBox.Size = new System.Drawing.Size(60, 16);
            this.PassiveAbilityCheckBox.TabIndex = 14;
            this.PassiveAbilityCheckBox.Text = "パッシブ";
            this.PassiveAbilityCheckBox.UseVisualStyleBackColor = true;
            this.PassiveAbilityCheckBox.CheckedChanged += new System.EventHandler(this.FilterMultiCardTypeControl_CheckedChanged);
            // 
            // ItemCheckBox
            // 
            this.ItemCheckBox.AutoSize = true;
            this.ItemCheckBox.Checked = true;
            this.ItemCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ItemCheckBox.Location = new System.Drawing.Point(320, 40);
            this.ItemCheckBox.Name = "ItemCheckBox";
            this.ItemCheckBox.Size = new System.Drawing.Size(61, 16);
            this.ItemCheckBox.TabIndex = 13;
            this.ItemCheckBox.Text = "アイテム";
            this.ItemCheckBox.UseVisualStyleBackColor = true;
            this.ItemCheckBox.CheckedChanged += new System.EventHandler(this.FilterMultiCardTypeControl_CheckedChanged);
            // 
            // AbilityCheckBox
            // 
            this.AbilityCheckBox.AutoSize = true;
            this.AbilityCheckBox.Checked = true;
            this.AbilityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AbilityCheckBox.Location = new System.Drawing.Point(250, 40);
            this.AbilityCheckBox.Name = "AbilityCheckBox";
            this.AbilityCheckBox.Size = new System.Drawing.Size(64, 16);
            this.AbilityCheckBox.TabIndex = 12;
            this.AbilityCheckBox.Text = "アビリティ";
            this.AbilityCheckBox.UseVisualStyleBackColor = true;
            this.AbilityCheckBox.CheckedChanged += new System.EventHandler(this.FilterMultiCardTypeControl_CheckedChanged);
            // 
            // SpellCheckBox
            // 
            this.SpellCheckBox.AutoSize = true;
            this.SpellCheckBox.Checked = true;
            this.SpellCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpellCheckBox.Location = new System.Drawing.Point(191, 40);
            this.SpellCheckBox.Name = "SpellCheckBox";
            this.SpellCheckBox.Size = new System.Drawing.Size(53, 16);
            this.SpellCheckBox.TabIndex = 11;
            this.SpellCheckBox.Text = "スペル";
            this.SpellCheckBox.UseVisualStyleBackColor = true;
            this.SpellCheckBox.CheckedChanged += new System.EventHandler(this.FilterMultiCardTypeControl_CheckedChanged);
            // 
            // ImprovementCheckBox
            // 
            this.ImprovementCheckBox.AutoSize = true;
            this.ImprovementCheckBox.Checked = true;
            this.ImprovementCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ImprovementCheckBox.Location = new System.Drawing.Point(137, 40);
            this.ImprovementCheckBox.Name = "ImprovementCheckBox";
            this.ImprovementCheckBox.Size = new System.Drawing.Size(48, 16);
            this.ImprovementCheckBox.TabIndex = 10;
            this.ImprovementCheckBox.Text = "増強";
            this.ImprovementCheckBox.UseVisualStyleBackColor = true;
            this.ImprovementCheckBox.CheckedChanged += new System.EventHandler(this.FilterMultiCardTypeControl_CheckedChanged);
            // 
            // CreepCheckBox
            // 
            this.CreepCheckBox.AutoSize = true;
            this.CreepCheckBox.Checked = true;
            this.CreepCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreepCheckBox.Location = new System.Drawing.Point(73, 40);
            this.CreepCheckBox.Name = "CreepCheckBox";
            this.CreepCheckBox.Size = new System.Drawing.Size(58, 16);
            this.CreepCheckBox.TabIndex = 9;
            this.CreepCheckBox.Text = "クリープ";
            this.CreepCheckBox.UseVisualStyleBackColor = true;
            this.CreepCheckBox.CheckedChanged += new System.EventHandler(this.FilterMultiCardTypeControl_CheckedChanged);
            // 
            // HeroCheckBox
            // 
            this.HeroCheckBox.AutoSize = true;
            this.HeroCheckBox.Checked = true;
            this.HeroCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HeroCheckBox.Location = new System.Drawing.Point(6, 40);
            this.HeroCheckBox.Name = "HeroCheckBox";
            this.HeroCheckBox.Size = new System.Drawing.Size(61, 16);
            this.HeroCheckBox.TabIndex = 8;
            this.HeroCheckBox.Text = "ヒーロー";
            this.HeroCheckBox.UseVisualStyleBackColor = true;
            this.HeroCheckBox.CheckedChanged += new System.EventHandler(this.FilterMultiCardTypeControl_CheckedChanged);
            // 
            // FilterSpecificCardTypeCheckBox
            // 
            this.FilterSpecificCardTypeCheckBox.AutoSize = true;
            this.FilterSpecificCardTypeCheckBox.Location = new System.Drawing.Point(6, 18);
            this.FilterSpecificCardTypeCheckBox.Name = "FilterSpecificCardTypeCheckBox";
            this.FilterSpecificCardTypeCheckBox.Size = new System.Drawing.Size(48, 16);
            this.FilterSpecificCardTypeCheckBox.TabIndex = 0;
            this.FilterSpecificCardTypeCheckBox.Text = "有効";
            this.FilterSpecificCardTypeCheckBox.UseVisualStyleBackColor = true;
            this.FilterSpecificCardTypeCheckBox.CheckedChanged += new System.EventHandler(this.FilterSpecificCardTypeControl_CheckedChanged);
            // 
            // CardListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SoleListView);
            this.Name = "CardListViewer";
            this.Text = "CardListViewer";
            this.Load += new System.EventHandler(this.CardListViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoleListView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView SoleListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox FilterSpecificColorCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox FilterSpecificCardTypeCheckBox;
        private System.Windows.Forms.CheckBox PassiveAbilityCheckBox;
        private System.Windows.Forms.CheckBox ItemCheckBox;
        private System.Windows.Forms.CheckBox AbilityCheckBox;
        private System.Windows.Forms.CheckBox SpellCheckBox;
        private System.Windows.Forms.CheckBox ImprovementCheckBox;
        private System.Windows.Forms.CheckBox CreepCheckBox;
        private System.Windows.Forms.CheckBox HeroCheckBox;
        private System.Windows.Forms.CheckBox GreenCheckBox;
        private System.Windows.Forms.CheckBox BlackCheckBox;
        private System.Windows.Forms.CheckBox RedCheckBox;
        private System.Windows.Forms.CheckBox BlueCheckBox;
    }
}