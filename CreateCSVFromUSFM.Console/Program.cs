using System;
using CommandLine;
using CreateCSVFromUSFM.Common;

namespace CreateCSVFromUSFM.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Arguments>(args).WithParsed((arguments) =>
            {
                CommonConverter.ConvertFiles(arguments.InputDirectory, arguments.OutputFile);
            });
        }
    }
}
