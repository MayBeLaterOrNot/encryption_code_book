﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using encryption_code_book.ViewModel;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace encryption_code_book.View
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    [ViewModel(ViewModel = typeof(NewCodeStorageModel))]
    public sealed partial class NewCodeStoragePage : Page
    {
        public NewCodeStoragePage()
        {
            //View = new NewCodeStorageModel();
            this.InitializeComponent();
            View = (NewCodeStorageModel)DataContext;
        }

        private ViewModel.NewCodeStorageModel View
        {
            set;
            get;
        }
    }
}
