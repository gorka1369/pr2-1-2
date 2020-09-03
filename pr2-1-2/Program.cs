using System;
using System.IO;

namespace pr2_1_2
{
    class Program0
    {
        
        static void Main(string[] args)
        {
            FileSystemWatcher watcher =
      new FileSystemWatcher(Environment.SystemDirectory);
            watcher.Filter = "*.ini";

            watcher.IncludeSubdirectories = true;

            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;

            watcher.Changed +=

            new FileSystemEventHandler(watcher_Changed);
            static void watcher_Changed(object sender, FileSystemEventArgs e)

            {

                Console.WriteLine("Changed: {0}", e.FullPath);

            }
           watcher.EnableRaisingEvents = true;
        }
    }
}
