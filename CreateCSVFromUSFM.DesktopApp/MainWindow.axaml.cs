using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using CreateCSVFromUSFM.Common;
using CreateCSVFromUSFM.DesktopApp.Controls;
using System.IO;
using System.Threading.Tasks;

namespace CreateCSVFromUSFM.DesktopApp
{
    public class MainWindow : Window
    {
        TextFolderOpen InputDirectoryControl;
        TextFileSave OutputFileControl;
        TextBlock Output;
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        public async void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            string sourceDirectory = this.InputDirectoryControl.Text;
            string outputFile = this.OutputFileControl.Text;
            if (string.IsNullOrWhiteSpace(sourceDirectory))
            {
                UpdateStatus("Please specify a source directory");
                return;
            }
            if (!Directory.Exists(sourceDirectory))
            {
                UpdateStatus("Source directory doesn't exist");
                return;
            }
            if (string.IsNullOrWhiteSpace(outputFile))
            {
                UpdateStatus("Please specify an output file");
                return;
            }
            UpdateStatus("Converting");
            await Task.Run(() =>
            {
                CommonConverter.ConvertFiles(this.InputDirectoryControl.Text, this.OutputFileControl.Text);
            });
            UpdateStatus("Conversion Successful");
        }

        private void UpdateStatus(string Text)
        {
            this.Output.Text = Text;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            this.InputDirectoryControl = this.FindControl<TextFolderOpen>("InputDirectory");
            this.OutputFileControl = this.FindControl<TextFileSave>("OutputFile");
            this.Output = this.FindControl<TextBlock>("Output");
        }
    }
}
