using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;

namespace CreateCSVFromUSFM.DesktopApp.Controls
{
    public class TextFileSave : UserControl
    {
        TextBox PathText;
        public string Text 
        { 
            get
            {
                return PathText.Text;
            } 
        }
        public TextFileSave()
        {
            InitializeComponent();
        }

        private async void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog()
            {
                Filters = new List<FileDialogFilter>() { new FileDialogFilter() { Name = "CSV Files", Extensions = new List<string>() { "csv" } } },
                InitialFileName = "output.csv",
            };
            var path = await dialog.ShowAsync(new Window());
            this.PathText.Text = path;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            this.PathText = this.FindControl<TextBox>("PathText");
        }
    }
}
