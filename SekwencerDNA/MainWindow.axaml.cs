using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SekwencerDNA
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCalculateClicked(object sender, RoutedEventArgs e)
        {
         
            var seq = InputSequence.Text?.Trim().ToUpper() ?? "";
            if (seq.Length < 4)
            {
                ResultTextBox.Text = "WprowadŸ co najmniej 4 znaki.";
                return;
            }

            
            int count = seq.Length - 4 + 1;
            ResultTextBox.Text = count.ToString();
        }
    }
}
