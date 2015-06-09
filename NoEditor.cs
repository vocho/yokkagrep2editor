
// for http://wayback.archive.org/web/20060118044437/http://download.forest.impress.co.jp/pub/win/n/noeditor/NEditSet_1-24-2-0.lzh

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq; // Any() => Count > 0

class dummyexe
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Environment.Exit(0);
        }
        //System.Windows.Forms.MessageBox.Show(args[0]);

        Queue<string> param = new Queue<string> (args[0].Trim('"').Split(new [] {"->\\<-"}, StringSplitOptions.None));
        //param.ToList().ForEach(s => System.Windows.Forms.MessageBox.Show(s.ToString()));
        string text_path        = param.Any() ? param.Dequeue().Replace("/G=", "") : "";
        string keyword          = param.Any() ? param.Dequeue() : "";
        string dummy1           = param.Any() ? param.Dequeue() : "";
        string dummy2           = param.Any() ? param.Dequeue() : "";
        string line_number      = param.Any() ? param.Dequeue() : "";
        string dummy3           = param.Any() ? param.Dequeue() : "";
        string column_number    = param.Any() ? param.Dequeue() : "";

        Process process = new Process();
        process.StartInfo.FileName = "\"C:\\Program Files (x86)\\sakura\\sakura.exe\"";
        process.StartInfo.Arguments = "\"" + text_path + "\" -Y=" + line_number + " -X=" + column_number;
        process.Start();
    }
}
