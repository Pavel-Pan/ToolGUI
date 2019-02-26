using GeneralOperation;
using System.Collections.Generic;
using System.IO;
using System;
using System.Diagnostics;
using System.Windows.Forms;
namespace mytool
{
    partial class mytoolGUI
    {
        GenaralOp go;
        Dictionary<string, int> ToolRunCount;
        List<string> paraList;
        int first_para_id ;
        string cur_tool_name = "";
        string search_string = "";
        string tool_code_dir = @"..\..\tool_code";
        string run_count_path = @"..\..\data\run_count.rc";
        string tool_desc_file_name = "tool_desc.td";
        string default_para_file_name = "default_para.dp";
        private void PrintInfoToRstShow(string info)
        {
            this.rstShow.Text = info;
        }
        private void PrintToolName(string name)
        {
            this.cmdName.Text = name;
        }
        private void PrintToolDesc(string file_path)
        {
            this.cmdDesc.Text = "";
            if (File.Exists(file_path) == false)
            {
                this.cmdDesc.Text = "Have not tool description now!";
            }
            else
            {
                StreamReader sr = new StreamReader(file_path);
                if (!sr.EndOfStream)
                {
                    this.cmdDesc.Text += sr.ReadLine();
                }
                while (!sr.EndOfStream)
                {
                    this.cmdDesc.Text += "\n" + sr.ReadLine();
                }
                sr.Close();
            }
        }
        private void PrintSortedToolName(List<KeyValuePair<string, int>> sortedToolName)
        {
            this.searchRst.Items.Clear();
            foreach (var v in sortedToolName)
            {
                this.searchRst.Items.Add ("> " + v.Key);
            }
        }
        private void PrintParaList(List<string> para_list,int start_para_id)
        {
            PrintParaId(start_para_id);
            PrintParaValue(para_list, start_para_id);
        }
        private void PrintParaValue(List<string> para_list,int start_para_id)
        {
            if (start_para_id < para_list.Count)
            {
                this.paraValue1.Text = para_list[start_para_id];
            }
            else
            {
                this.paraValue1.Text = "";
            }

            if (start_para_id + 1 < para_list.Count)
            {
                this.paraValue2.Text = para_list[start_para_id + 1];
            }
            else
            {
                this.paraValue2.Text = "";
            }

            if (start_para_id + 2 < para_list.Count)
            {
                this.paraValue3.Text = para_list[start_para_id + 2];
            }
            else
            {
                this.paraValue3.Text = "";
            }
        }
        private void PrintParaId(int start_para_id)
        {
            this.para_label1.Text = "para " + (start_para_id + 1).ToString();
            this.para_label2.Text = "para " + (start_para_id + 2).ToString();
            this.para_label3.Text = "para " + (start_para_id + 3).ToString();
        }
        private void PrintCmd(string cmd)
        {
            this.cmdText.Text = cmd;
        }
        private void PrintStandardOutput(object sender, DataReceivedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                GenaralOp.EventInvokeCallback eic = new GenaralOp.EventInvokeCallback(PrintStandardOutput);
                this.Invoke(eic,new object[] { sender, e });
            }
            else
            {
                this.rstShow.Text += e.Data;
            }     
        }
        private void PrintErrorOutput(object sender, DataReceivedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                GenaralOp.EventInvokeCallback eic = new GenaralOp.EventInvokeCallback(PrintStandardOutput);
                this.Invoke(eic, new object[] { sender, e });
            }
            else
            {
                this.rstShow.Text += e.Data;
            }
        }
        public void ModifyDescExited(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                GenaralOp.ExitdInvokeCallback eic = new GenaralOp.ExitdInvokeCallback(ModifyDescExited);
                this.Invoke(eic, new object[] { sender, e });
            }
            else
            {
                this.PrintToolDesc(tool_code_dir + "\\" + cur_tool_name + "\\" + tool_desc_file_name);
            }
        }
        private void user_init()
        {
            go = new GenaralOp();
            first_para_id = 0;
            List<string> ToolNameList = go.GetToolNameList(tool_code_dir);
            if (ToolNameList.Count > 0)
            {
                this.ToolRunCount = go.GetToolRunCount(ToolNameList, run_count_path);
                var sortedToolName = go.DictonarySortByValue(this.ToolRunCount);
                cur_tool_name = sortedToolName[0].Key;
                this.PrintSortedToolName(sortedToolName);
                this.PrintToolName(sortedToolName[0].Key);
                this.PrintToolDesc(tool_code_dir + "\\" + sortedToolName[0].Key + "\\" + tool_desc_file_name);
                List<string> para_list = go.GetParaList(tool_code_dir + "\\" + sortedToolName[0].Key + "\\" + default_para_file_name);
                paraList = para_list;
                this.PrintParaList(para_list, first_para_id);
            }
            else
            {
                this.ToolRunCount = new Dictionary<string, int>();
                this.paraList = new List<string>();
                this.first_para_id = 0;
                this.PrintParaList(paraList, first_para_id);
            } 
        }
    }
}


