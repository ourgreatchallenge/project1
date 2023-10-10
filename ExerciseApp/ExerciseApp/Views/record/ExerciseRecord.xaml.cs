using System.Windows;
using System.Windows.Controls;

namespace ExerciseApp.Views
{
    /// <summary>
    /// ExerciseRecord.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ExerciseRecord : UserControl
    {
        public ExerciseRecord()
        {
            InitializeComponent();
        }

        private void tbxRecord_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxRecord.Text == "")
            {
                tbkRecord.Visibility = Visibility.Visible;
            }
            else
            {
                tbkRecord.Visibility = Visibility.Hidden;
            }
        }

        private void tbxRecord_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            tbkRecord.Visibility = Visibility.Hidden;
        }

        private void tbxRecord_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            if (tbxRecord.Text == "")
            {
                tbkRecord.Visibility = Visibility.Visible;
            }
        }
    }
}
