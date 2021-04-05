using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCSVFromUSFM.ConsoleApp
{
    public class Arguments
    {
        [Option("input", Required = true, HelpText ="Input directory")]
        public string InputDirectory { get; set; }
        [Option("output", Required = true, HelpText ="Output file name")]
        public string OutputFile { get; set; }
    }
}
