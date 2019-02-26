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
        object ContextMenuSourceControl;

        public mytoolGUI()
        {
            InitializeComponent();
            ContextMenuSourceControl = null;
            user_init();
        }
        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            this.search_string = this.searchInput.Text;
            var toolInSearch = go.GetToolInSearch(ToolRunCount, search_string);
            var toolSortedByRunCount = go.DictonarySortByValue(toolInSearch);
            PrintSortedToolName(toolSortedByRunCount);
        }
        private void searchRst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void searchRst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string tool_name = this.searchRst.SelectedItem.ToString().Split(' ')[1];
            cur_tool_name = tool_name;
            if (Directory.Exists(tool_code_dir + "\\" + tool_name) == false)
            {
                go.RemoveToolName(ref ToolRunCount,tool_name);
            }
            else
            {
                paraList = go.GetParaList(tool_code_dir + "\\" + tool_name + "\\" + tool_desc_file_name);
                this.PrintParaList(paraList,first_para_id);
                this.PrintToolName(tool_name);
                this.PrintToolDesc(tool_code_dir + "\\" + tool_name + "\\" + tool_desc_file_name);               
                go.UpdateRunCount(ref ToolRunCount, tool_name);
            }
            var toolInSearch = go.GetToolInSearch(ToolRunCount, search_string);
            var sortedToolName = go.DictonarySortByValue(toolInSearch);
            this.PrintSortedToolName(sortedToolName);
            
        }
        private void mytoolGUI_Closed(object sender, EventArgs e)
        {
            go.SaveRunCountToFile(ToolRunCount, run_count_path);
        }
        private void addDesc_Click(object sender, EventArgs e)
        {
            string tool_desc_path = tool_code_dir + "\\" + cur_tool_name+"\\" + tool_desc_file_name;
            if(File.Exists(tool_desc_path) == false)
            {
                new StreamWriter(tool_desc_path).Close();
            }
            
            go.RunExe("notepad.exe", tool_desc_path, ModifyDescExited);
        }
        private void save_para_Click(object sender, EventArgs e)
        {
            string para_path = tool_code_dir + "\\" + cur_tool_name + "\\" + default_para_file_name;
            StreamWriter sw = new StreamWriter(para_path);
            for (int i = 1; i <= paraList.Count; i++)
            {
                sw.WriteLine("para " + i.ToString() + ":" + paraList[i-1]);
            }
            sw.Close();
        }
        private void paraScroll_Scroll(object sender, ScrollEventArgs e)
        {
            first_para_id = this.paraScroll.Value;
            PrintParaList(paraList, first_para_id);
        }
        private void paraValue1_TextChanged(object sender, EventArgs e)
        {
            string para_value = this.paraValue1.Text;
            bool setState = go.SetParaList(ref paraList,first_para_id, para_value);
            if (setState == false)
            {
                this.paraValue1.Text = "";
            }
        }
        private void paraValue2_TextChanged(object sender, EventArgs e)
        {
            string para_value = this.paraValue2.Text;
            bool setState = go.SetParaList(ref paraList, first_para_id+1, para_value);
            if (setState == false)
            {
                this.paraValue2.Text = "";
            }
        }
        private void paraValue3_TextChanged(object sender, EventArgs e)
        {
            string para_value = this.paraValue3.Text;
            bool setState = go.SetParaList(ref paraList, first_para_id+2, para_value);
            if (setState == false)
            {
                this.paraValue3.Text = "";
            }
        }
        private void run_Click(object sender, EventArgs e)
        {
            string tool_dir = tool_code_dir + "\\" + cur_tool_name;
            string[] files = Directory.GetFiles(tool_dir, cur_tool_name +"*");
            GeneralOperation.GenaralOp.EXE_TYPE exe_type =  GeneralOperation.GenaralOp.EXE_TYPE.NONE;
            string exe_path = "";
            string cmd = "";
            foreach (var v in files)
            {
                string path = v.Trim();
                string tool_name = Path.GetFileName(path);
                if (tool_name == cur_tool_name + ".bat")
                {
                    if (exe_type != GeneralOperation.GenaralOp.EXE_TYPE.NONE)
                    {
                        exe_type = GeneralOperation.GenaralOp.EXE_TYPE.BAT;
                        exe_path = Path.GetFullPath(path);
                    }
                }
                else if(tool_name == cur_tool_name + ".py")
                {        
                    if (exe_type != GeneralOperation.GenaralOp.EXE_TYPE.EXE)
                    {
                        exe_type = GeneralOperation.GenaralOp.EXE_TYPE.PYTHON;
                        exe_path = Path.GetFullPath(path);
                        cmd += "python ";
                    }                                   
                }
                else if (tool_name == cur_tool_name + ".exe")
                {
                    exe_type = GeneralOperation.GenaralOp.EXE_TYPE.EXE;
                    exe_path = Path.GetFullPath(path);
                    break;
                }
            }

            if (exe_path != "")
            {
                string args = go.GetArgs(paraList);
                cmd += exe_path + args;
                this.PrintCmd(cmd);
                this.rstShow.Clear();
                go.RunWithOutput(exe_path, args, exe_type,PrintStandardOutput,PrintErrorOutput);
            }
            else
            {
                MessageBox.Show("don't find excute file such as .py/.bat/.exe");
            }
        }

        private void EditText_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuSourceControl = (sender as ContextMenuStrip).SourceControl;
        }


        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ContextMenuSourceControl != null)
            {
                (ContextMenuSourceControl as TextBoxBase).Copy();
            }    
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ContextMenuSourceControl != null)
            {
                (ContextMenuSourceControl as TextBoxBase).Paste();
            }
        }
    }
}
