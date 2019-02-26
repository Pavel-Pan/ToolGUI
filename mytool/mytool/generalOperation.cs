using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
namespace GeneralOperation
{
    public class GenaralOp
    {
        public Config tool_ini;
        public GlobalPara global_para;

        public enum EXE_TYPE
        {
            PYTHON,
            BAT,
            EXE,
            NONE
        }
        public class Config
        {
            public string tool_code_dir;
            public Config()
            {
                StreamReader sr = new StreamReader(@".\ToolGUI.ini");
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Trim().Split(' ');
                    if (line.Length >= 2)
                    {
                        try
                        {
                            this.GetType().GetField(line[0]).SetValue(this, line[1]);
                        }
                        catch
                        {
                            MessageBox.Show("have no para : " + line[0]);
                        }
                    }        
                }
                sr.Close();
            }
        }
        public class GlobalPara
        {
            public Dictionary<string, int> ToolRunCount;
            public List<string> paraList;
            public int first_para_id;
            public string cur_tool_name;
            public string search_string ;
            public string run_count_path ;
            public string tool_desc_file_name ;
            public string default_para_file_name ;
            public GlobalPara()
            {
                cur_tool_name = "";
                search_string = "";
                run_count_path = @".\data\run_count.rc";
                tool_desc_file_name = "tool_desc.td";
                default_para_file_name = "default_para.dp";
            }
        } ;

        public delegate void ExitdInvokeCallback(object sender, EventArgs e);
        public delegate void EventInvokeCallback(object sender, DataReceivedEventArgs e);
        public GenaralOp()
        {
            tool_ini = new Config();
            global_para = new GlobalPara();
        }
        public void RunExe(string exe_name, string arg, ExitdInvokeCallback e)
        {
            try
            {
                Process pro = new Process();
                pro.StartInfo.FileName = exe_name;
                pro.StartInfo.Arguments = arg;
                pro.StartInfo.CreateNoWindow = true;
                pro.StartInfo.UseShellExecute = false;
                pro.EnableRaisingEvents = true;
                pro.Exited += new EventHandler(e);
                pro.Start();
            }
            catch
            {
                MessageBox.Show("excute " + exe_name + arg + " failed!");
            }
        }
        public void RunWithOutput(string exe_name, string arg, EXE_TYPE exe_type, 
                                  EventInvokeCallback StandardOutput, EventInvokeCallback ErrorOutput)
        {
            Process pro = new Process();
            if (exe_type == EXE_TYPE.PYTHON)
            {
                pro.StartInfo.FileName = @"python";
                pro.StartInfo.Arguments = exe_name + " " + arg;
            }
            else if(exe_type == EXE_TYPE.BAT)
            {
                pro.StartInfo.FileName = exe_name;
                pro.StartInfo.Arguments = arg;
            }
            else if (exe_type == EXE_TYPE.EXE)
            {
                pro.StartInfo.FileName = exe_name;
                pro.StartInfo.Arguments = arg;
            }
            pro.StartInfo.CreateNoWindow = false;
            pro.StartInfo.UseShellExecute = false;
            pro.StartInfo.RedirectStandardOutput = true;
            pro.StartInfo.RedirectStandardError = true;
            pro.EnableRaisingEvents = true;
            pro.OutputDataReceived += new DataReceivedEventHandler(StandardOutput);
            pro.ErrorDataReceived += new DataReceivedEventHandler(ErrorOutput);
            try
            {
                pro.Start();
                pro.BeginOutputReadLine();
                pro.BeginErrorReadLine();       
            }
            catch 
            {
                string base_name = System.IO.Path.GetFileName(exe_name);
                MessageBox.Show("excute " + base_name + " failed!");
            }
        }
        public List<string> GetToolNameList(string dir)
        {
            // only the folder have file tool_desc.td is tool file
            List<string> ToolNameList = new List<string>();

            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
            }

            string[] sub_dirs = Directory.GetDirectories(dir);

            foreach (string sub_dir in sub_dirs)
            {
                string[] dirName = sub_dir.Split('\\');
                ToolNameList.Add(dirName[dirName.Length - 1]);

                /*
                string[] files = Directory.GetFiles(sub_dir, "tool_desc.td");
                foreach (string file in files)
                {
                    if (Path.GetFileName(file) == "tool_desc.td")
                    {
                        string[] dirName = sub_dir.Split('\\');
                        ToolNameList.Add(dirName[dirName.Length -1]);
                        break;
                    }
                }
                */
            }
            return ToolNameList;
        }
        public Dictionary<string,int> GetToolRunCount(List<string> ToolNameList,string data_path)
        {
            Dictionary<string, int> RunCount = new Dictionary<string, int>();

            foreach (string toolName in ToolNameList)
            {
                RunCount[toolName] = 0;
            }

            if (File.Exists(data_path) == false)
            { 
                return RunCount;
            }          

            StreamReader sr = new StreamReader(data_path);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] info = line.Split(':'); 
                if(info.Length != 2)
                {
                    MessageBox.Show("run_count.rc have error key and value in line:"+ line);
                    sr.Close();
                    return RunCount;
                }
                int run_count = 0;
                try
                {
                    run_count = Convert.ToInt32(info[1]);
                }
                catch
                {
                    MessageBox.Show("run_count.rc have error key and value in line:"+ line);
                    sr.Close();
                    return RunCount;
                }
                if (RunCount.ContainsKey(info[0]))
                {
                    RunCount[info[0]] = run_count;
                }
            }

            sr.Close();
            return RunCount;
        }
        public void UpdateRunCount(ref Dictionary<string, int> RunCount, List<string> ToolNameList)
        {
            foreach(var v in ToolNameList)
            {
                if (RunCount.ContainsKey(v) == false)
                {
                    RunCount[v] = 0;
                }
            }
        }
        public void UpdateRunCount(ref Dictionary<string, int> RunCount,string ToolName)
        {
            if(RunCount.ContainsKey(ToolName) == false)
            {
                RunCount[ToolName] = 0;
            }

            RunCount[ToolName] += 1; 
        }
        public void SaveRunCountToFile(Dictionary<string, int> RunCount, string run_count_path)
        {
            if (Directory.Exists(Path.GetDirectoryName(run_count_path)) == false)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(run_count_path));
            }
            StreamWriter sw = new StreamWriter(run_count_path);
            foreach (var v in RunCount)
            {
                sw.WriteLine(v.Key+":"+v.Value.ToString());
            }
            sw.Close();
        }
        public void RemoveToolName(ref Dictionary<string, int> RunCount,string toolName)
        {
            if (RunCount.ContainsKey(toolName))
            {
                RunCount.Remove(toolName);
            }
        }
        public Dictionary<string, int> GetToolInSearch(Dictionary<string, int> RunCount, string search_string)
        {

            if (search_string == "")
            {
                return RunCount;
            }

            Dictionary<string, int> ToolInSearch = new Dictionary<string, int>();

            foreach (var v in RunCount)
            {
                if (v.Key.IndexOf(search_string) != -1)
                {
                    ToolInSearch[v.Key] = v.Value;
                }
            }
            return ToolInSearch;
        }
        public List<KeyValuePair<string, int>> DictonarySortByValue(Dictionary<string, int> dic)
        {
            var sortedDict = from entry in dic orderby entry.Value descending select entry;
            List<KeyValuePair<string, int>> sd = new List<KeyValuePair<string, int>>();
            foreach (var s in sortedDict)
            {
                sd.Add(s);
            }
            return sd;
        }
        public List<string> GetParaList(string descFilePath)
        {
            List<string> para_list = new List<string>();
  
            if (File.Exists(descFilePath))
            {
                StreamReader sr = new StreamReader(descFilePath);
                int para_id = 1;
                while (!sr.EndOfStream)
                {
                    string[] line_info = sr.ReadLine().Split(':');
                    if (line_info.Length>=1)
                    {
                        if (line_info[0] == "para " + para_id.ToString())
                        {
                            para_list.Add(line_info[1]);
                            para_id += 1;
                        }
                    }
                }
                sr.Close();
            }

            return para_list;

        }
        public bool SetParaList(ref List<string> para_list,int index,string value)
        {
            if (index <para_list.Count)
            {
                para_list[index] = value;
            }
            else if(index == para_list.Count)
            {
                if (value != "")
                {
                    para_list.Add(value);
                }              
            }
            else
            {
                return false;
            }
            return true;
        }
        public string GetArgs(List<string> para_list)
        {
            string args = "";
            foreach(var v in para_list)
            {
                args += " " + v;
            }
            return args;
        }

    }
}
