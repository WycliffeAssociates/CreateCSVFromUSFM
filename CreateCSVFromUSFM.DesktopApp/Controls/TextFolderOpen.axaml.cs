using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;

namespace CreateCSVFromUSFM.DesktopApp.Controls
{
    public class TextFolderOpen : UserControl
    {
        TextBox PathText;
        public string Text { 
            get
            {
                return PathText.Text;
            } 
        }
        public TextFolderOpen()
        {
            InitializeComponent();
        }

        private async void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFolderDialog();
            var result = await dialog.ShowAsync((Window)this.GetVisualRoot());
            this.PathText.Text = result;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            this.PathText = this.FindControl<TextBox>("PathText");
        }
    }
}
