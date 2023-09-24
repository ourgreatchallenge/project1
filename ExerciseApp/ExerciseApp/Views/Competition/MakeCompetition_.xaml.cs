using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExerciseApp.Views
{
    /// <summary>
    /// MakeCompetition_.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MakeCompetition_ : UserControl
    {
        public MakeCompetition_()
        {
            InitializeComponent();
        }

        private void tbxCompetitionName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxCompetitionName.Text == "")
            {
                tbkCompetitionName.Visibility = Visibility.Visible;
            }
            else
            {
                tbkCompetitionName.Visibility = Visibility.Hidden;
            }
        }

        private void tbxCompetitionName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbkCompetitionName.Visibility = Visibility.Hidden;
        }

        private void tbxCompetitionName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbxCompetitionName.Text == "")
            {
                tbkCompetitionName.Visibility = Visibility.Visible;
            }
        }

        

        private void tbxPhoneNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxPhoneNum.Text == "")
            {
                tbkPhoneNum.Visibility = Visibility.Visible;
            }
            else
            {
                tbkPhoneNum.Visibility = Visibility.Hidden;
            }
        }

        private void tbxPhoneNum_GotFocus(object sender, RoutedEventArgs e)
        {
            tbkPhoneNum.Visibility = Visibility.Hidden;
        }

        private void tbxPhoneNum_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbxCompetitionName.Text == "")
            {
                tbkPhoneNum.Visibility = Visibility.Visible;
            }
        }


        private void tbxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxName.Text == "")
            {
                tbkName.Visibility = Visibility.Visible;
            }
            else
            {
                tbkName.Visibility = Visibility.Hidden;
            }
        }

        private void tbxName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbkName.Visibility = Visibility.Hidden;
        }

        private void tbxName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbxCompetitionName.Text == "")
            {
                tbkPhoneNum.Visibility = Visibility.Visible;
            }
        }
        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
