namespace something
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OKBt = new System.Windows.Forms.Button();
            this.xoaBt = new System.Windows.Forms.Button();
            this.SoChanBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.findMax = new System.Windows.Forms.Button();
            this.timSoNgTo = new System.Windows.Forms.Button();
            this.findMin = new System.Windows.Forms.Button();
            this.SortBt = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.maxRemove = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 1;
            // 
            // OKBt
            // 
            this.OKBt.Location = new System.Drawing.Point(142, 3);
            this.OKBt.Name = "OKBt";
            this.OKBt.Size = new System.Drawing.Size(64, 23);
            this.OKBt.TabIndex = 2;
            this.OKBt.Text = "OK";
            this.OKBt.UseVisualStyleBackColor = true;
            this.OKBt.Click += new System.EventHandler(this.OKBt_Click);
            // 
            // xoaBt
            // 
            this.xoaBt.Location = new System.Drawing.Point(212, 3);
            this.xoaBt.Name = "xoaBt";
            this.xoaBt.Size = new System.Drawing.Size(60, 23);
            this.xoaBt.TabIndex = 4;
            this.xoaBt.Text = "xóa";
            this.xoaBt.UseVisualStyleBackColor = true;
            this.xoaBt.Click += new System.EventHandler(this.xoaBt_Click);
            // 
            // SoChanBt
            // 
            this.SoChanBt.Location = new System.Drawing.Point(3, 3);
            this.SoChanBt.Name = "SoChanBt";
            this.SoChanBt.Size = new System.Drawing.Size(75, 23);
            this.SoChanBt.TabIndex = 5;
            this.SoChanBt.Text = "tìm số chẵn";
            this.SoChanBt.UseVisualStyleBackColor = true;
            this.SoChanBt.Click += new System.EventHandler(this.SoChanBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập số phần tử";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Location = new System.Drawing.Point(15, 32);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(391, 100);
            this.MainPanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.SoChanBt);
            this.flowLayoutPanel1.Controls.Add(this.findMax);
            this.flowLayoutPanel1.Controls.Add(this.timSoNgTo);
            this.flowLayoutPanel1.Controls.Add(this.findMin);
            this.flowLayoutPanel1.Controls.Add(this.SortBt);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(391, 58);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // findMax
            // 
            this.findMax.Location = new System.Drawing.Point(84, 3);
            this.findMax.Name = "findMax";
            this.findMax.Size = new System.Drawing.Size(75, 23);
            this.findMax.TabIndex = 6;
            this.findMax.Text = "tìm max";
            this.findMax.UseVisualStyleBackColor = true;
            this.findMax.Click += new System.EventHandler(this.findMax_Click);
            // 
            // timSoNgTo
            // 
            this.timSoNgTo.Location = new System.Drawing.Point(165, 3);
            this.timSoNgTo.Name = "timSoNgTo";
            this.timSoNgTo.Size = new System.Drawing.Size(108, 23);
            this.timSoNgTo.TabIndex = 8;
            this.timSoNgTo.Text = "tìm số nguyên tố";
            this.timSoNgTo.UseVisualStyleBackColor = true;
            this.timSoNgTo.Click += new System.EventHandler(this.timSoNgTo_Click);
            // 
            // findMin
            // 
            this.findMin.Location = new System.Drawing.Point(279, 3);
            this.findMin.Name = "findMin";
            this.findMin.Size = new System.Drawing.Size(75, 23);
            this.findMin.TabIndex = 7;
            this.findMin.Text = "tìm min";
            this.findMin.UseVisualStyleBackColor = true;
            this.findMin.Click += new System.EventHandler(this.findMin_Click);
            // 
            // SortBt
            // 
            this.SortBt.Location = new System.Drawing.Point(3, 32);
            this.SortBt.Name = "SortBt";
            this.SortBt.Size = new System.Drawing.Size(75, 23);
            this.SortBt.TabIndex = 9;
            this.SortBt.Text = "sắp xếp";
            this.SortBt.UseVisualStyleBackColor = true;
            this.SortBt.Click += new System.EventHandler(this.SortBt_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.maxRemove);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 231);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(393, 106);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // maxRemove
            // 
            this.maxRemove.AutoSize = true;
            this.maxRemove.Location = new System.Drawing.Point(3, 3);
            this.maxRemove.Name = "maxRemove";
            this.maxRemove.Size = new System.Drawing.Size(84, 17);
            this.maxRemove.TabIndex = 2;
            this.maxRemove.Text = "phần tử max";
            this.maxRemove.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(278, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "ẩn bội số của 3 và 5";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.xoaBt);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.OKBt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OKBt;
        private System.Windows.Forms.Button xoaBt;
        private System.Windows.Forms.Button SoChanBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button findMax;
        private System.Windows.Forms.Button findMin;
        private System.Windows.Forms.CheckBox maxRemove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button timSoNgTo;
        private System.Windows.Forms.Button SortBt;
    }
}

