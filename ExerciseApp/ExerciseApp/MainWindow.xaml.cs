﻿using ControlzEx.Theming;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ExerciseApp.Logics;
using ExerciseApp.Views;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace ExerciseApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
      
        public MainWindow()
        {
            InitializeComponent();
            ThemeManager.Current.ThemeSyncMode = ThemeSyncMode.SyncWithAppMode;
            ThemeManager.Current.SyncTheme();
        }


        #region < 끝내기 버튼 클릭 이벤트 핸들러 >
        private void MnuExitSubscribe_Click(object sender, RoutedEventArgs e)
        {
            //Environment.Exit(0);

            // 위, 아래 둘 중 하나만 사용하면 됨
            // 작업 관리자에서 프로세스 종료와 같은 역할
            Process.GetCurrentProcess().Kill();
        }
        #endregion

       
        #region < 종료 버튼 클릭 시 메시지창 + 완전 종료 >
        private async void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            // e.Cancel을 true 하고 시작
            e.Cancel = true;

            var mySettings = new MetroDialogSettings
                                 {
                                     AffirmativeButtonText = "종료",
                                     NegativeButtonText = "취소",
                                     AnimateShow = true,
                                     AnimateHide = true
                                 };

            var result = await this.ShowMessageAsync("프로그램을 종료","프로그램을 종료하시겠습니까?",
                                                     MessageDialogStyle.AffirmativeAndNegative, mySettings);
            Process.GetCurrentProcess().Kill();

        }
        #endregion

        #region < 종료버튼 클릭 이벤트 >
        private void BtnExitProgram_Click(object sender, RoutedEventArgs e)
        {
            // 메트로윈도우 화면 닫을 때 이벤트 핸들러 호출
            MetroWindow_Closing(sender, new System.ComponentModel.CancelEventArgs());
        }
        #endregion

        #region < 무게 버튼 클릭 이벤트 >
        private void MnuWeight_Click(object sender, RoutedEventArgs e)
        {
            var weight = new Views.Weight();
            ActiveItem.Content = weight;
            StsSelScreen.Content = "Weight";
        }
        #endregion

        #region < 기록 입력하기 버튼 클릭 이벤트 >
        private void MnuExerciseRecord_Click(object sender, RoutedEventArgs e)
        {
            var record = new Views.ExerciseRecord();
            ActiveItem.Content = record;
            StsSelScreen.Content = "Record";
        }
        #endregion

        #region < 기록 조회하기 버튼 클릭 이벤트 >
        private void MnuExerciseRecordTotal_Click(object sender, RoutedEventArgs e)
        {
            var recordTotal = new Views.ExerciseRecordTotal();
            ActiveItem.Content = recordTotal;
            StsSelScreen.Content = "TotalRecord";
        }
        #endregion
    }
}