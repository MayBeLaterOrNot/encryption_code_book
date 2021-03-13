﻿// lindexi
// 19:40

#region

using Windows.ApplicationModel;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using encryption_code_book.ViewModel;

#endregion

namespace encryption_code_book
{
    public partial class note_page : Page
    {
        public note_page()
        {
            _ctrl = false;
            InitializeComponent();
            Application.Current.Suspending += suspend;
        }

        private bool _ctrl;

        private note view;

        private void suspend(object sender, SuspendingEventArgs e)
        {
            view.storage();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            view = e.Parameter as note ?? new note();
            view.frame = frame;
            //viewModel view_model = e.Parameter as viewModel;
            //view.key = view_model.key;
            //view.frame = view_model.frame;
            view.deserilization();
        }

        //private void modify(object sender, TextChangedEventArgs e)
        //{

        //}

        private void hold(object sender, RoutedEventArgs e)
        {
            view.storage();
        }

        private void fastkey(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Control)
            {
                _ctrl = true;
            }
            else if (_ctrl && view.confim)
            {
                switch (e.Key)
                {
                    case VirtualKey.S:
                        view.storage();
                        break;
                    case VirtualKey.Z:
                        view.cancel();
                        break;
                }
            }

            //else if (_ctrl && view.confim)
            //{
            //    if (e.Key == Windows.System.VirtualKey.S)
            //    {
            //        view.file_key = xfile_key.Text;
            //        await view.hold();
            //    }
            //    else if (e.Key == Windows.System.VirtualKey.L)
            //    {
            //        view.file_key = xfile_key.Text;
            //        System.Threading.Tasks.Task t = view.hold();
            //        view.lock_grid();
            //    }
            //}
        }

        private void keyup(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Control)
            {
                _ctrl = false;
            }
            if (_ctrl)
            {
            }
        }

        private void motify(object sender, RoutedEventArgs e)
        {
        }
    }
}