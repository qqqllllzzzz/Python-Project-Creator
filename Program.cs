using System;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ProjectCreator
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Py P-Creator >> Write 'dotpl'.");
            Console.ResetColor();

            string Project = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Project.py");

            void CallPIP(string pip_lib)
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.Start();
                process.StandardInput.WriteLine(pip_lib);
            }

            for (; ; ){
                string? input = Console.ReadLine();

                string ConsoleProject = "-c";
                string UIproject = "-g";
                string BetterUI = "-ui";
                string ExitReact = "exit";
                string webview = "1";
                string flet = "2";
                string colorama = "3";
                string keyboard = "4";
                string discord_py = "5";
                string pyinstaller = "6";
                string dotpl_react = "dotpl";
                // string help_react = "--help" + "-h";
                string pip = "--p";
                string pip_installer = "-pip";

                if (input.Contains(ConsoleProject)) {
                    using (StreamWriter sw = File.CreateText(Project))
                    {
                        sw.WriteLine("print('Hello World!')");
                    }
                    Console.WriteLine("File was created.");
                }
                if (input.Contains(UIproject)) {
                    using (StreamWriter sw = File.CreateText(Project))
                    {
                        sw.WriteLine("from tkinter import Tk\n\napp = Tk()\napp.title('Title')\napp.geometry('800x600')\n\n\n\napp.mainloop()");
                    }
                    Console.WriteLine("File was created.");
                }
                if (input.Contains(BetterUI)) {
                    using (StreamWriter sw = File.CreateText(Project))
                    {
                        sw.WriteLine("import flet as ft\ndef main(page: ft.Page):\n    page.add(ft.SafeArea(ft.Text('Hello World!')))\nft.app(main)");
                    }
                    Console.WriteLine("File was created.");
                }

                if (input.Contains(dotpl_react)) {
                    Console.WriteLine("Usage: dotpl [options]\n\n   --pip / -p => ???\n   -c => Create a console project\n   -g => Create a graphic project\n   -ui => Better than regular graphics");
                }
                if (input.Contains(pip_installer)) {
                    Console.WriteLine("Choose library\n1. webview\n2. flet\n3. colorama\n4. keyboard\n5. discord.py\n6. pyinstaller");
                }
                if (input.Contains(webview)) {
                    CallPIP("pip install webview");
                }
                if (input.Contains(flet)) {
                    CallPIP("pip install flet");
                }
                if (input.Contains(colorama)) {
                    CallPIP("pip install colorama");
                }
                if (input.Contains(keyboard)) {
                    CallPIP("pip install keyboard");
                }
                if (input.Contains(discord_py)) {
                    CallPIP("pip install discord.py");
                }
                if (input.Contains(pyinstaller)) {
                    CallPIP("pip install pyinstaller");
                }
                if (input.Contains(pip)) {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Open this site, there is a list of libraries: https://www.pypi.org");
                    Console.ResetColor();
                }
                if (input.Contains(ExitReact)) {
                    Environment.Exit(0);
                }
            }
        }
    }
}