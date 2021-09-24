namespace Symbolic_Link_Creator
{
    partial class Form1
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
            this.toBeSelect_TB = new System.Windows.Forms.TextBox();
            this.newFol_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toBeSelect_BT = new System.Windows.Forms.Button();
            this.newFol_BT = new System.Windows.Forms.Button();
            this.create_BT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceName_TB = new System.Windows.Forms.TextBox();
            this.source_CB = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.junction_RB = new System.Windows.Forms.RadioButton();
            this.hard_RB = new System.Windows.Forms.RadioButton();
            this.dir_RB = new System.Windows.Forms.RadioButton();
            this.info_Lab = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toBeSelect_TB
            // 
            this.toBeSelect_TB.Location = new System.Drawing.Point(119, 12);
            this.toBeSelect_TB.Name = "toBeSelect_TB";
            this.toBeSelect_TB.Size = new System.Drawing.Size(784, 20);
            this.toBeSelect_TB.TabIndex = 0;
            this.toBeSelect_TB.TextChanged += new System.EventHandler(this.toBeSelect_TB_TextChanged);
            // 
            // newFol_TB
            // 
            this.newFol_TB.Location = new System.Drawing.Point(119, 39);
            this.newFol_TB.Name = "newFol_TB";
            this.newFol_TB.Size = new System.Drawing.Size(444, 20);
            this.newFol_TB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder to be linked:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New folder location:";
            // 
            // toBeSelect_BT
            // 
            this.toBeSelect_BT.Location = new System.Drawing.Point(909, 10);
            this.toBeSelect_BT.Name = "toBeSelect_BT";
            this.toBeSelect_BT.Size = new System.Drawing.Size(75, 23);
            this.toBeSelect_BT.TabIndex = 4;
            this.toBeSelect_BT.Text = "Select";
            this.toBeSelect_BT.UseVisualStyleBackColor = true;
            this.toBeSelect_BT.Click += new System.EventHandler(this.toBeSelect_BT_Click);
            // 
            // newFol_BT
            // 
            this.newFol_BT.Location = new System.Drawing.Point(909, 37);
            this.newFol_BT.Name = "newFol_BT";
            this.newFol_BT.Size = new System.Drawing.Size(75, 23);
            this.newFol_BT.TabIndex = 5;
            this.newFol_BT.Text = "Select";
            this.newFol_BT.UseVisualStyleBackColor = true;
            this.newFol_BT.Click += new System.EventHandler(this.newFol_BT_Click);
            // 
            // create_BT
            // 
            this.create_BT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.create_BT.Location = new System.Drawing.Point(909, 67);
            this.create_BT.Name = "create_BT";
            this.create_BT.Size = new System.Drawing.Size(75, 23);
            this.create_BT.TabIndex = 6;
            this.create_BT.Text = "Create";
            this.create_BT.UseVisualStyleBackColor = true;
            this.create_BT.Click += new System.EventHandler(this.create_BT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "New folder name:";
            // 
            // sourceName_TB
            // 
            this.sourceName_TB.Location = new System.Drawing.Point(665, 39);
            this.sourceName_TB.Name = "sourceName_TB";
            this.sourceName_TB.Size = new System.Drawing.Size(238, 20);
            this.sourceName_TB.TabIndex = 8;
            // 
            // source_CB
            // 
            this.source_CB.AutoSize = true;
            this.source_CB.Checked = true;
            this.source_CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.source_CB.Location = new System.Drawing.Point(665, 72);
            this.source_CB.Name = "source_CB";
            this.source_CB.Size = new System.Drawing.Size(136, 17);
            this.source_CB.TabIndex = 9;
            this.source_CB.Text = "Get source folder name";
            this.source_CB.UseVisualStyleBackColor = true;
            this.source_CB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.junction_RB);
            this.panel1.Controls.Add(this.hard_RB);
            this.panel1.Controls.Add(this.dir_RB);
            this.panel1.Location = new System.Drawing.Point(442, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 24);
            this.panel1.TabIndex = 10;
            // 
            // junction_RB
            // 
            this.junction_RB.AutoSize = true;
            this.junction_RB.Checked = true;
            this.junction_RB.Location = new System.Drawing.Point(149, 3);
            this.junction_RB.Name = "junction_RB";
            this.junction_RB.Size = new System.Drawing.Size(65, 17);
            this.junction_RB.TabIndex = 2;
            this.junction_RB.TabStop = true;
            this.junction_RB.Text = "Junction";
            this.junction_RB.UseVisualStyleBackColor = true;
            // 
            // hard_RB
            // 
            this.hard_RB.AutoSize = true;
            this.hard_RB.Location = new System.Drawing.Point(76, 3);
            this.hard_RB.Name = "hard_RB";
            this.hard_RB.Size = new System.Drawing.Size(67, 17);
            this.hard_RB.TabIndex = 1;
            this.hard_RB.Text = "Hard link";
            this.hard_RB.UseVisualStyleBackColor = true;
            // 
            // dir_RB
            // 
            this.dir_RB.AutoSize = true;
            this.dir_RB.Location = new System.Drawing.Point(3, 3);
            this.dir_RB.Name = "dir_RB";
            this.dir_RB.Size = new System.Drawing.Size(67, 17);
            this.dir_RB.TabIndex = 0;
            this.dir_RB.Text = "Directory";
            this.dir_RB.UseVisualStyleBackColor = true;
            // 
            // info_Lab
            // 
            this.info_Lab.AutoSize = true;
            this.info_Lab.Location = new System.Drawing.Point(116, 73);
            this.info_Lab.Name = "info_Lab";
            this.info_Lab.Size = new System.Drawing.Size(35, 13);
            this.info_Lab.TabIndex = 12;
            this.info_Lab.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(996, 102);
            this.Controls.Add(this.info_Lab);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.source_CB);
            this.Controls.Add(this.sourceName_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.create_BT);
            this.Controls.Add(this.newFol_BT);
            this.Controls.Add(this.toBeSelect_BT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newFol_TB);
            this.Controls.Add(this.toBeSelect_TB);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symbolic Link Portable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toBeSelect_TB;
        private System.Windows.Forms.TextBox newFol_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toBeSelect_BT;
        private System.Windows.Forms.Button newFol_BT;
        private System.Windows.Forms.Button create_BT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sourceName_TB;
        private System.Windows.Forms.CheckBox source_CB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton junction_RB;
        private System.Windows.Forms.RadioButton hard_RB;
        private System.Windows.Forms.RadioButton dir_RB;
        private System.Windows.Forms.Label info_Lab;
    }
}

