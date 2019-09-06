using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mytool
{
    public partial class mytoolGUI : Form
    {
        public mytoolGUI()
        {
            InitializeComponent();
            user_init();
        }
        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            go.global_para.search_string = this.searchInput.Text;
            List<string> ToolNameList = go.GetToolNameList(go.tool_ini.tool_code_dir);
            go.UpdateRunCount(ref go.global_para.ToolRunCount, ToolNameList);
            var toolInSearch = go.GetToolInSearch(go.global_para.ToolRunCount, go.global_para.search_string);
            var toolSortedByRunCount = go.DictonarySortByValue(toolInSearch);
            PrintSortedToolName(toolSortedByRunCount);
        }

        private void SearchRst_ClickProcess()
        {
            object selectedItem = this.searchRst.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }
            int select_index = this.searchRst.SelectedIndex;
            string tool_name = selectedItem.ToString().Split(' ')[1];
            go.global_para.cur_tool_name = tool_name;
            if (Directory.Exists(go.tool_ini.tool_code_dir + "\\" + tool_name) == false)
            {
                go.RemoveToolName(ref go.global_para.ToolRunCount, tool_name);
            }
            else
            {
                go.global_para.paraList = go.GetParaList(go.tool_ini.tool_desc_dir + "\\" + tool_name + "\\" + go.global_para.default_para_file_name);
                this.PrintParaList(go.global_para.paraList, go.global_para.first_para_id);
                this.PrintToolName(tool_name);
                this.PrintToolDesc(go.tool_ini.tool_desc_dir + "\\" + tool_name + "\\" + go.global_para.tool_desc_file_name);
                
            }


            this.searchRst.Focus();
            this.searchRst.SelectedIndex = select_index;
        }
        private void searchRst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
 
        }
        private void searchRst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchRst_ClickProcess();
            }
        }
        private void searchRst_MouseClick(object sender, MouseEventArgs e)
        {
            SearchRst_ClickProcess();
        }
        private void mytoolGUI_Closed(object sender, EventArgs e)
        {
            go.SaveRunCountToFile(go.global_para.ToolRunCount, go.global_para.run_count_path);
        }
        private void addDesc_Click(object sender, EventArgs e)
        {
            string tool_desc_path = go.tool_ini.tool_desc_dir + "\\" + go.global_para.cur_tool_name + "\\" + go.global_para.tool_desc_file_name;

            if (Directory.Exists(go.tool_ini.tool_desc_dir + "\\" + go.global_para.cur_tool_name) == false)
            {
                Directory.CreateDirectory(go.tool_ini.tool_desc_dir + "\\" + go.global_para.cur_tool_name);
            }

            if (File.Exists(tool_desc_path) == false)
            {
                new StreamWriter(tool_desc_path).Close();
            }

            go.RunExe("notepad.exe", tool_desc_path, ModifyDescExited);
        }
        private void paraScroll_Scroll(object sender, ScrollEventArgs e)
        {
            go.global_para.first_para_id = this.paraScroll.Value;
            PrintParaList(go.global_para.paraList, go.global_para.first_para_id);
        }
        private void paraValue1_TextChanged(object sender, EventArgs e)
        {
            string para_value = this.paraValue1.Text;
            bool setState = go.SetParaList(ref go.global_para.paraList, go.global_para.first_para_id, para_value);
            if (setState == false)
            {
                this.paraValue1.Text = "";
            }
        }
        private void paraValue2_TextChanged(object sender, EventArgs e)
        {
            string para_value = this.paraValue2.Text;
            bool setState = go.SetParaList(ref go.global_para.paraList, go.global_para.first_para_id + 1, para_value);
            if (setState == false)
            {
                this.paraValue2.Text = "";
            }
        }
        private void paraValue3_TextChanged(object sender, EventArgs e)
        {
            string para_value = this.paraValue3.Text;
            bool setState = go.SetParaList(ref go.global_para.paraList, go.global_para.first_para_id + 2, para_value);
            if (setState == false)
            {
                this.paraValue3.Text = "";
            }
        }
        private void run_Click(object sender, EventArgs e)
        {
            string tool_dir = go.tool_ini.tool_code_dir + "\\" + go.global_para.cur_tool_name;
            string[] files = Directory.GetFiles(tool_dir, go.global_para.cur_tool_name + "*");
            GeneralOperation.GenaralOp.EXE_TYPE exe_type = GeneralOperation.GenaralOp.EXE_TYPE.NONE;
            string exe_path = "";
            string cmd = "";
            foreach (var v in files)
            {
                string path = v.Trim();
                string tool_name = Path.GetFileName(path);
                if (tool_name == go.global_para.cur_tool_name + ".bat")
                {
                    if (exe_type != GeneralOperation.GenaralOp.EXE_TYPE.NONE)
                    {
                        exe_type = GeneralOperation.GenaralOp.EXE_TYPE.BAT;
                        exe_path = Path.GetFullPath(path);
                    }
                }
                else if (tool_name == go.global_para.cur_tool_name + ".py")
                {
                    if (exe_type != GeneralOperation.GenaralOp.EXE_TYPE.EXE)
                    {
                        exe_type = GeneralOperation.GenaralOp.EXE_TYPE.PYTHON;
                        exe_path = Path.GetFullPath(path);
                        cmd += "python ";
                    }
                }
                else if (tool_name == go.global_para.cur_tool_name + ".exe")
                {
                    exe_type = GeneralOperation.GenaralOp.EXE_TYPE.EXE;
                    exe_path = Path.GetFullPath(path);
                    break;
                }
            }

            if (exe_path != "")
            {
                string args = go.GetArgs(go.global_para.paraList);
                cmd += exe_path + args;
                this.PrintCmd(cmd);
                this.rstShow.Clear();
                string para_path = go.tool_ini.tool_desc_dir + "\\" + go.global_para.cur_tool_name + "\\" + go.global_para.default_para_file_name;
                go.save_para(para_path, go.global_para.paraList);
                go.UpdateRunCount(ref go.global_para.ToolRunCount, go.global_para.cur_tool_name);
                var toolInSearch = go.GetToolInSearch(go.global_para.ToolRunCount, go.global_para.search_string);
                var sortedToolName = go.DictonarySortByValue(toolInSearch);
                this.PrintSortedToolName(sortedToolName);
                go.RunWithOutput(exe_path, args, exe_type, PrintStandardOutput, PrintErrorOutput);
            }
            else
            {
                MessageBox.Show("don't find excute file such as .py/.bat/.exe");
            }
        }
        private void open1_Click(object sender, EventArgs e)
        {
            string path = this.paraValue1.Text;
            if (File.Exists(path))
            {
                go.RunExe("notepad.exe", path, null);
            }
        }
        private void open2_Click(object sender, EventArgs e)
        {
            string path = this.paraValue2.Text;
            if (File.Exists(path))
            {
                go.RunExe("notepad.exe", path, null);
            }
        }
        private void open3_Click(object sender, EventArgs e)
        {
            string path = this.paraValue3.Text;
            if (File.Exists(path))
            {
                go.RunExe("notepad.exe", path, null);
            }
        }

        private void open_work_path_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            if (Directory.Exists(path))
            {
                go.RunExe("explorer.exe", path, null);
            }
        }

        private void searchInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.searchRst.Focus();
                this.searchRst.SelectedIndex = 0;
            }
        }

        private void searchInput_Click(object sender, EventArgs e)
        {
            this.searchInput.Focus();
            this.searchRst.SelectedItem = null;
        }

        private void searchRst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
