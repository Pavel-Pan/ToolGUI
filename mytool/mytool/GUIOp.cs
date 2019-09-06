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
                this.rstShow.Text += e.Data + "\n";
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
                this.PrintToolDesc(go.tool_ini.tool_desc_dir + "\\" + go.global_para.cur_tool_name + "\\" + go.global_para.tool_desc_file_name);
            }
        }
        private void user_init()
        {
            go = new GenaralOp();
            go.global_para.first_para_id = 0;
            List<string> ToolNameList = go.GetToolNameList(go.tool_ini.tool_code_dir);
            if (ToolNameList.Count > 0)
            {
                go.global_para.ToolRunCount = go.GetToolRunCount(ToolNameList, go.global_para.run_count_path);
                var sortedToolName = go.DictonarySortByValue(go.global_para.ToolRunCount);
                go.global_para.cur_tool_name = sortedToolName[0].Key;
                this.PrintSortedToolName(sortedToolName);
                this.PrintToolName(sortedToolName[0].Key);
                this.PrintToolDesc(go.tool_ini.tool_desc_dir + "\\" + sortedToolName[0].Key + "\\" + go.global_para.tool_desc_file_name);
                List<string> para_list = go.GetParaList(go.tool_ini.tool_desc_dir + "\\" + sortedToolName[0].Key + "\\" + go.global_para.default_para_file_name);
                go.global_para.paraList = para_list;
                this.PrintParaList(para_list, go.global_para.first_para_id);
            }
            else
            {
                go.global_para.ToolRunCount = new Dictionary<string, int>();
                go.global_para.paraList = new List<string>();
                go.global_para.first_para_id = 0;
                this.PrintParaList(go.global_para.paraList, go.global_para.first_para_id);
   
            } 
        }
    }
}


