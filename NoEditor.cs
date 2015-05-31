
// for http://wayback.archive.org/web/20060118044437/http://download.forest.impress.co.jp/pub/win/n/noeditor/NEditSet_1-24-2-0.lzh

using System;
using System.Diagnostics;
using System.Collections.Generic;

class dummyexe
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Environment.Exit(0);
        }

        Queue<string> param = new Queue<string> (args[0].Trim('"').Split(new [] {"->\\<-"}, StringSplitOptions.None));
        string text_path = param.Dequeue().Replace("/G=", "");
        string keyword = param.Dequeue();
        param.Dequeue();
        param.Dequeue();
        string line_number = param.Dequeue();
        param.Dequeue();
        string column_number = param.Dequeue();

        Process process = new Process();
        process.StartInfo.FileName = "\"C:\\Program Files (x86)\\sakura\\sakura.exe\"";
        process.StartInfo.Arguments = "\"" + text_path + "\" -Y=" + line_number + " -X=" + column_number;
        process.Start();
    }
}
