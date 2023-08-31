using MahApps.Metro.Controls;
using ExerciseApp.Logics;
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
using System.Windows.Shapes;
using System.Data;

namespace ExerciseApp.Views
{
    /// <summary>
    /// MqttPopupWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Calculator2 : MetroWindow
    {
        private string currentInput = "";
        private double currentResult = 0.0;
        private char currentOperator = ' ';
        private bool newInput = true;

        public Calculator2()
        {
            InitializeComponent();
        }

        private void numberButton_Click(object sender, RoutedEventArgs e)
        {
            if (newInput)
            {
                TbxMemo.Text = "";
                newInput = false;
            }

            Button button = (Button)sender;
            currentInput += button.Content.ToString();
            TbxMemo.Text += button.Content.ToString();
        }

        private void operationButton_Click(object sender, RoutedEventArgs e)
        {
            if (!newInput)
            {
                Calculate();
                newInput = true;
            }

            Button button = (Button)sender;
            currentOperator = button.Content.ToString()[0];
            currentResult = double.Parse(currentInput);
            TbxMemo.Text += " " + currentOperator + " ";
            currentInput = "";
        }

        private void Btn_result_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            newInput = true;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            currentInput = "";
            currentResult = 0.0;
            currentOperator = ' ';
            newInput = true;
            TbxMemo.Text = "";
            LblResult.Content = string.Empty;
        }

        private void Calculate()
        {
            double input = double.Parse(currentInput);

            switch (currentOperator)
            {
                case '+':
                    currentResult += input;
                    break;
                case '-':
                    currentResult -= input;
                    break;
                case '*':
                    currentResult *= input;
                    break;
                case '/':
                    if (input != 0)
                    {
                        currentResult /= input;
                    }
                    else
                    {
                        TbxMemo.Text = "Error";
                        LblResult.Content = "Error";
                        currentInput = "";
                        newInput = true;
                        return;
                    }
                    break;
            }

            TbxMemo.Text = currentResult.ToString();
            LblResult.Content = currentResult.ToString();
            currentInput = currentResult.ToString();
        }

        
    }

}
