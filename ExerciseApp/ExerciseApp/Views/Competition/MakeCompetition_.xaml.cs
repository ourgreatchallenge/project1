﻿using System;
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
                tbk.Visibility = Visibility.Visible;
            }
            else
            {
                tbk.Visibility = Visibility.Hidden;
            }
        }

        private void tbxCompetitionName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbk.Visibility = Visibility.Hidden;
        }

        private void tbxCompetitionName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbxCompetitionName.Text == "")
            {
                tbk.Visibility = Visibility.Visible;
            }
        }
    }
}
