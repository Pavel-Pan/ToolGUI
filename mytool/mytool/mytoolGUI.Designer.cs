namespace mytool
{
    partial class mytoolGUI
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
            this.cmdDesc = new System.Windows.Forms.RichTextBox();
            this.rstShow = new System.Windows.Forms.RichTextBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.tool_name_label = new System.Windows.Forms.Label();
            this.cmdName = new System.Windows.Forms.TextBox();
            this.searchRst = new System.Windows.Forms.ListBox();
            this.cmdText = new System.Windows.Forms.RichTextBox();
            this.run = new System.Windows.Forms.Button();
            this.addDesc = new System.Windows.Forms.Button();
            this.para_label1 = new System.Windows.Forms.Label();
            this.paraValue1 = new System.Windows.Forms.TextBox();
            this.paraValue2 = new System.Windows.Forms.TextBox();
            this.paraValue3 = new System.Windows.Forms.TextBox();
            this.para_label2 = new System.Windows.Forms.Label();
            this.para_label3 = new System.Windows.Forms.Label();
            this.paraScroll = new System.Windows.Forms.VScrollBar();
            this.EditMenuStrip = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // cmdDesc
            // 
            this.cmdDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdDesc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDesc.Location = new System.Drawing.Point(375, 64);
            this.cmdDesc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdDesc.Name = "cmdDesc";
            this.cmdDesc.ReadOnly = true;
            this.cmdDesc.Size = new System.Drawing.Size(654, 111);
            this.cmdDesc.TabIndex = 0;
            this.cmdDesc.Text = "";
            // 
            // rstShow
            // 
            this.rstShow.Location = new System.Drawing.Point(375, 399);
            this.rstShow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rstShow.Name = "rstShow";
            this.rstShow.ReadOnly = true;
            this.rstShow.Size = new System.Drawing.Size(654, 332);
            this.rstShow.TabIndex = 1;
            this.rstShow.Text = "";
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(9, 27);
            this.searchInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(362, 31);
            this.searchInput.TabIndex = 2;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // tool_name_label
            // 
            this.tool_name_label.AutoSize = true;
            this.tool_name_label.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tool_name_label.Location = new System.Drawing.Point(10, 64);
            this.tool_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tool_name_label.Name = "tool_name_label";
            this.tool_name_label.Size = new System.Drawing.Size(96, 23);
            this.tool_name_label.TabIndex = 6;
            this.tool_name_label.Text = "tool name";
            // 
            // cmdName
            // 
            this.cmdName.BackColor = System.Drawing.SystemColors.Menu;
            this.cmdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdName.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdName.Location = new System.Drawing.Point(375, 27);
            this.cmdName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdName.Name = "cmdName";
            this.cmdName.Size = new System.Drawing.Size(653, 31);
            this.cmdName.TabIndex = 7;
            this.cmdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchRst
            // 
            this.searchRst.BackColor = System.Drawing.SystemColors.Menu;
            this.searchRst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchRst.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRst.FormattingEnabled = true;
            this.searchRst.ItemHeight = 19;
            this.searchRst.Location = new System.Drawing.Point(9, 91);
            this.searchRst.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchRst.Name = "searchRst";
            this.searchRst.Size = new System.Drawing.Size(362, 629);
            this.searchRst.TabIndex = 8;
            this.searchRst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.searchRst_MouseDoubleClick);
            // 
            // cmdText
            // 
            this.cmdText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdText.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdText.Location = new System.Drawing.Point(375, 331);
            this.cmdText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdText.Name = "cmdText";
            this.cmdText.ReadOnly = true;
            this.cmdText.Size = new System.Drawing.Size(654, 63);
            this.cmdText.TabIndex = 11;
            this.cmdText.Text = "";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(718, 180);
            this.run.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(310, 31);
            this.run.TabIndex = 12;
            this.run.Text = "RUN";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // addDesc
            // 
            this.addDesc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDesc.Location = new System.Drawing.Point(375, 180);
            this.addDesc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addDesc.Name = "addDesc";
            this.addDesc.Size = new System.Drawing.Size(322, 31);
            this.addDesc.TabIndex = 15;
            this.addDesc.Text = "modify tool description";
            this.addDesc.UseVisualStyleBackColor = true;
            this.addDesc.Click += new System.EventHandler(this.addDesc_Click);
            // 
            // para_label1
            // 
            this.para_label1.AutoSize = true;
            this.para_label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.para_label1.Location = new System.Drawing.Point(375, 226);
            this.para_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.para_label1.Name = "para_label1";
            this.para_label1.Size = new System.Drawing.Size(51, 19);
            this.para_label1.TabIndex = 18;
            this.para_label1.Text = "label1";
            // 
            // paraValue1
            // 
            this.paraValue1.BackColor = System.Drawing.SystemColors.Menu;
            this.paraValue1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraValue1.Location = new System.Drawing.Point(436, 220);
            this.paraValue1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.paraValue1.Name = "paraValue1";
            this.paraValue1.Size = new System.Drawing.Size(567, 26);
            this.paraValue1.TabIndex = 19;
            this.paraValue1.TextChanged += new System.EventHandler(this.paraValue1_TextChanged);
            // 
            // paraValue2
            // 
            this.paraValue2.BackColor = System.Drawing.SystemColors.Menu;
            this.paraValue2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraValue2.Location = new System.Drawing.Point(436, 261);
            this.paraValue2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.paraValue2.Name = "paraValue2";
            this.paraValue2.Size = new System.Drawing.Size(567, 26);
            this.paraValue2.TabIndex = 20;
            this.paraValue2.TextChanged += new System.EventHandler(this.paraValue2_TextChanged);
            // 
            // paraValue3
            // 
            this.paraValue3.BackColor = System.Drawing.SystemColors.Menu;
            this.paraValue3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraValue3.Location = new System.Drawing.Point(436, 296);
            this.paraValue3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.paraValue3.Name = "paraValue3";
            this.paraValue3.Size = new System.Drawing.Size(567, 26);
            this.paraValue3.TabIndex = 21;
            this.paraValue3.TextChanged += new System.EventHandler(this.paraValue3_TextChanged);
            // 
            // para_label2
            // 
            this.para_label2.AutoSize = true;
            this.para_label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.para_label2.Location = new System.Drawing.Point(375, 265);
            this.para_label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.para_label2.Name = "para_label2";
            this.para_label2.Size = new System.Drawing.Size(51, 19);
            this.para_label2.TabIndex = 22;
            this.para_label2.Text = "label2";
            // 
            // para_label3
            // 
            this.para_label3.AutoSize = true;
            this.para_label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.para_label3.Location = new System.Drawing.Point(375, 302);
            this.para_label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.para_label3.Name = "para_label3";
            this.para_label3.Size = new System.Drawing.Size(51, 19);
            this.para_label3.TabIndex = 23;
            this.para_label3.Text = "label3";
            // 
            // paraScroll
            // 
            this.paraScroll.LargeChange = 1;
            this.paraScroll.Location = new System.Drawing.Point(1004, 218);
            this.paraScroll.Maximum = 6;
            this.paraScroll.Name = "paraScroll";
            this.paraScroll.Size = new System.Drawing.Size(31, 105);
            this.paraScroll.TabIndex = 25;
            this.paraScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.paraScroll_Scroll);
            // 
            // EditMenuStrip
            // 
            this.EditMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.EditMenuStrip.Name = "EditMenuStrip";
            this.EditMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.EditMenuStrip.Size = new System.Drawing.Size(1036, 24);
            this.EditMenuStrip.TabIndex = 26;
            this.EditMenuStrip.Text = "menuStrip1";
            // 
            // mytoolGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 739);
            this.Controls.Add(this.paraScroll);
            this.Controls.Add(this.para_label3);
            this.Controls.Add(this.para_label2);
            this.Controls.Add(this.paraValue3);
            this.Controls.Add(this.paraValue2);
            this.Controls.Add(this.paraValue1);
            this.Controls.Add(this.para_label1);
            this.Controls.Add(this.addDesc);
            this.Controls.Add(this.run);
            this.Controls.Add(this.cmdText);
            this.Controls.Add(this.searchRst);
            this.Controls.Add(this.cmdName);
            this.Controls.Add(this.tool_name_label);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.rstShow);
            this.Controls.Add(this.cmdDesc);
            this.Controls.Add(this.EditMenuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.EditMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1054, 785);
            this.Name = "mytoolGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tools";
            this.Closed += new System.EventHandler(this.mytoolGUI_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox cmdDesc;
        private System.Windows.Forms.RichTextBox rstShow;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label tool_name_label;
        private System.Windows.Forms.TextBox cmdName;
        private System.Windows.Forms.ListBox searchRst;
        private System.Windows.Forms.RichTextBox cmdText;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button addDesc;
        private System.Windows.Forms.Label para_label1;
        private System.Windows.Forms.TextBox paraValue1;
        private System.Windows.Forms.TextBox paraValue2;
        private System.Windows.Forms.TextBox paraValue3;
        private System.Windows.Forms.Label para_label2;
        private System.Windows.Forms.Label para_label3;
        internal System.Windows.Forms.VScrollBar paraScroll;
        private System.Windows.Forms.MenuStrip EditMenuStrip;
    }
}

