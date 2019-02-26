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
            this.components = new System.ComponentModel.Container();
            this.cmdDesc = new System.Windows.Forms.RichTextBox();
            this.EditText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.save_para = new System.Windows.Forms.Button();
            this.paraScroll = new System.Windows.Forms.VScrollBar();
            this.EditMenuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditText.SuspendLayout();
            this.EditMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdDesc
            // 
            this.cmdDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdDesc.ContextMenuStrip = this.EditText;
            this.cmdDesc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDesc.Location = new System.Drawing.Point(500, 74);
            this.cmdDesc.Name = "cmdDesc";
            this.cmdDesc.ReadOnly = true;
            this.cmdDesc.Size = new System.Drawing.Size(870, 128);
            this.cmdDesc.TabIndex = 0;
            this.cmdDesc.Text = "";
            // 
            // EditText
            // 
            this.EditText.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1});
            this.EditText.Name = "EditContextMenuStrip";
            this.EditText.Size = new System.Drawing.Size(119, 52);
            this.EditText.Opening += new System.ComponentModel.CancelEventHandler(this.EditText_Opening);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(118, 24);
            this.copyToolStripMenuItem1.Text = "copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(118, 24);
            this.pasteToolStripMenuItem1.Text = "paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // rstShow
            // 
            this.rstShow.ContextMenuStrip = this.EditText;
            this.rstShow.Location = new System.Drawing.Point(500, 460);
            this.rstShow.Name = "rstShow";
            this.rstShow.ReadOnly = true;
            this.rstShow.Size = new System.Drawing.Size(870, 383);
            this.rstShow.TabIndex = 1;
            this.rstShow.Text = "";
            // 
            // searchInput
            // 
            this.searchInput.ContextMenuStrip = this.EditText;
            this.searchInput.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(12, 31);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(482, 37);
            this.searchInput.TabIndex = 2;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // tool_name_label
            // 
            this.tool_name_label.AutoSize = true;
            this.tool_name_label.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tool_name_label.Location = new System.Drawing.Point(13, 74);
            this.tool_name_label.Name = "tool_name_label";
            this.tool_name_label.Size = new System.Drawing.Size(119, 30);
            this.tool_name_label.TabIndex = 6;
            this.tool_name_label.Text = "tool name";
            // 
            // cmdName
            // 
            this.cmdName.BackColor = System.Drawing.SystemColors.Menu;
            this.cmdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdName.ContextMenuStrip = this.EditText;
            this.cmdName.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdName.Location = new System.Drawing.Point(500, 31);
            this.cmdName.Name = "cmdName";
            this.cmdName.Size = new System.Drawing.Size(870, 37);
            this.cmdName.TabIndex = 7;
            this.cmdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchRst
            // 
            this.searchRst.BackColor = System.Drawing.SystemColors.Menu;
            this.searchRst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchRst.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRst.FormattingEnabled = true;
            this.searchRst.ItemHeight = 23;
            this.searchRst.Location = new System.Drawing.Point(12, 105);
            this.searchRst.Name = "searchRst";
            this.searchRst.Size = new System.Drawing.Size(482, 738);
            this.searchRst.TabIndex = 8;
            this.searchRst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.searchRst_MouseDoubleClick);
            // 
            // cmdText
            // 
            this.cmdText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdText.ContextMenuStrip = this.EditText;
            this.cmdText.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdText.Location = new System.Drawing.Point(500, 382);
            this.cmdText.Name = "cmdText";
            this.cmdText.ReadOnly = true;
            this.cmdText.Size = new System.Drawing.Size(870, 72);
            this.cmdText.TabIndex = 11;
            this.cmdText.Text = "";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(1149, 208);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(221, 36);
            this.run.TabIndex = 12;
            this.run.Text = "RUN";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // addDesc
            // 
            this.addDesc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDesc.Location = new System.Drawing.Point(500, 208);
            this.addDesc.Name = "addDesc";
            this.addDesc.Size = new System.Drawing.Size(258, 36);
            this.addDesc.TabIndex = 15;
            this.addDesc.Text = "modify tool description";
            this.addDesc.UseVisualStyleBackColor = true;
            this.addDesc.Click += new System.EventHandler(this.addDesc_Click);
            // 
            // para_label1
            // 
            this.para_label1.AutoSize = true;
            this.para_label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.para_label1.Location = new System.Drawing.Point(500, 261);
            this.para_label1.Name = "para_label1";
            this.para_label1.Size = new System.Drawing.Size(62, 23);
            this.para_label1.TabIndex = 18;
            this.para_label1.Text = "label1";
            // 
            // paraValue1
            // 
            this.paraValue1.BackColor = System.Drawing.SystemColors.Menu;
            this.paraValue1.ContextMenuStrip = this.EditText;
            this.paraValue1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraValue1.Location = new System.Drawing.Point(581, 254);
            this.paraValue1.Name = "paraValue1";
            this.paraValue1.Size = new System.Drawing.Size(755, 31);
            this.paraValue1.TabIndex = 19;
            this.paraValue1.TextChanged += new System.EventHandler(this.paraValue1_TextChanged);
            // 
            // paraValue2
            // 
            this.paraValue2.BackColor = System.Drawing.SystemColors.Menu;
            this.paraValue2.ContextMenuStrip = this.EditText;
            this.paraValue2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraValue2.Location = new System.Drawing.Point(581, 301);
            this.paraValue2.Name = "paraValue2";
            this.paraValue2.Size = new System.Drawing.Size(755, 31);
            this.paraValue2.TabIndex = 20;
            this.paraValue2.TextChanged += new System.EventHandler(this.paraValue2_TextChanged);
            // 
            // paraValue3
            // 
            this.paraValue3.BackColor = System.Drawing.SystemColors.Menu;
            this.paraValue3.ContextMenuStrip = this.EditText;
            this.paraValue3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraValue3.Location = new System.Drawing.Point(581, 342);
            this.paraValue3.Name = "paraValue3";
            this.paraValue3.Size = new System.Drawing.Size(755, 31);
            this.paraValue3.TabIndex = 21;
            this.paraValue3.TextChanged += new System.EventHandler(this.paraValue3_TextChanged);
            // 
            // para_label2
            // 
            this.para_label2.AutoSize = true;
            this.para_label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.para_label2.Location = new System.Drawing.Point(500, 306);
            this.para_label2.Name = "para_label2";
            this.para_label2.Size = new System.Drawing.Size(62, 23);
            this.para_label2.TabIndex = 22;
            this.para_label2.Text = "label2";
            // 
            // para_label3
            // 
            this.para_label3.AutoSize = true;
            this.para_label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.para_label3.Location = new System.Drawing.Point(500, 349);
            this.para_label3.Name = "para_label3";
            this.para_label3.Size = new System.Drawing.Size(62, 23);
            this.para_label3.TabIndex = 23;
            this.para_label3.Text = "label3";
            // 
            // save_para
            // 
            this.save_para.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_para.Location = new System.Drawing.Point(800, 208);
            this.save_para.Name = "save_para";
            this.save_para.Size = new System.Drawing.Size(307, 36);
            this.save_para.TabIndex = 24;
            this.save_para.Text = "save para";
            this.save_para.UseVisualStyleBackColor = true;
            this.save_para.Click += new System.EventHandler(this.save_para_Click);
            // 
            // paraScroll
            // 
            this.paraScroll.LargeChange = 1;
            this.paraScroll.Location = new System.Drawing.Point(1339, 251);
            this.paraScroll.Maximum = 6;
            this.paraScroll.Name = "paraScroll";
            this.paraScroll.Size = new System.Drawing.Size(31, 121);
            this.paraScroll.TabIndex = 25;
            this.paraScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.paraScroll_Scroll);
            // 
            // EditMenuStrip
            // 
            this.EditMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.EditMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.EditMenuStrip.Name = "EditMenuStrip";
            this.EditMenuStrip.Size = new System.Drawing.Size(1382, 28);
            this.EditMenuStrip.TabIndex = 26;
            this.EditMenuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.helpToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.copyToolStripMenuItem.Text = "copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.pasteToolStripMenuItem.Text = "paste";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(56, 24);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // mytoolGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.paraScroll);
            this.Controls.Add(this.save_para);
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
            this.MainMenuStrip = this.EditMenuStrip;
            this.MaximumSize = new System.Drawing.Size(1400, 900);
            this.Name = "mytoolGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tools";
            this.Closed += new System.EventHandler(this.mytoolGUI_Closed);
            this.EditText.ResumeLayout(false);
            this.EditMenuStrip.ResumeLayout(false);
            this.EditMenuStrip.PerformLayout();
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
        private System.Windows.Forms.Button save_para;
        internal System.Windows.Forms.VScrollBar paraScroll;
        private System.Windows.Forms.MenuStrip EditMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip EditText;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
    }
}

