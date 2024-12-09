using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string colorName = button.Content.ToString();
                ColorDisplay.Text = colorName;

                try
                {
                    BrushConverter converter = new BrushConverter();
                    Brush colorBrush = (Brush)converter.ConvertFromString(colorName);
                    ColorDisplay.Background = colorBrush;

                    ColorDisplay.Foreground = Brushes.White;
                }
                catch
                {
                    MessageBox.Show($"Не удалось установить цвет: {colorName}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
