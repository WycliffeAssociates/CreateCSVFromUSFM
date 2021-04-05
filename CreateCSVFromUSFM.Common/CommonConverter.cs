using System;
using System.Collections.Generic;
using System.IO;
using USFMToolsSharp;
using USFMToolsSharp.Models.Markers;
using USFMToolsSharp.Renderers.Csv;

namespace CreateCSVFromUSFM.Common
{
    public static class CommonConverter
    {
        public static void ConvertFiles(string inputDirectory, string outputFileName)
        {
            USFMParser parser = new USFMParser(new List<string> { "s5" });
            CsvRenderer renderer = new CsvRenderer();
            List<USFMDocument> content = new List<USFMDocument>();
            foreach (var f in Directory.EnumerateFiles(inputDirectory, "*.usfm", SearchOption.AllDirectories))
            {
                content.Add(parser.ParseFromString(File.ReadAllText(f)));
            }
            var file = File.OpenWrite(outputFileName);
            renderer.Render(content, file);
        }
    }
}
