﻿// lindexi
// 10:50

#region

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using encryption_code_book.View;
using encryption_code_book.ViewModel;

//using encryption_code_book.ViewModel;

#endregion

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace encryption_code_book
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            //view = new note();
            InitializeComponent();
            //frame.Navigate(typeof(note_page));
            ViewModel = (ViewModel.ViewModel) DataContext;
            ViewModel.OnNavigatedTo(frame);
        }

        public ViewModel.ViewModel ViewModel { set; get; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //AccountGoverment.View.Frame = frame;

            //if (string.IsNullOrEmpty(AccountGoverment.View.Account?.Key?.Key))
            //{
            //    AccountGoverment.View.NavigateKey();
            //}
            //else
            //{
            //    AccountGoverment.View.NacigateCode();
            //}

            //frame.Navigate(typeof(EncryCodeStoragePage));

            //base.OnNavigatedTo(e);

        }

        //private viewModel view;

        private void button_click(object sender, RoutedEventArgs e)
        {
            //split_view.IsPaneOpen = !split_view.IsPaneOpen;
        }

        private void nagivate(object sender, SelectionChangedEventArgs e)
        {
            //ListBox list_box = sender as ListBox;
            //ListBoxItem item = list_box?.SelectedItem as ListBoxItem;

            //if (item != null && frame != null)
            //{
            //    switch (item.Name)
            //    {
            //        case "encryption_note":
            //            frame.Navigate(typeof(note_page), view);
            //            break;
            //        case "encryption_code":
            //            frame.Navigate(typeof(code_page), view);
            //            break;
            //        default:
            //            frame.Navigate(typeof(note_page), view);
            //            break;
            //    }
            //}
        }
    }
}