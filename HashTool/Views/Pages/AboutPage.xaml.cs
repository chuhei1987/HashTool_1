﻿// Copyright (c) Kiyan Yang. All rights reserved.
// Licensed under the GNU General Public License v3.0.
// See LICENSE file in the project root for full license information.

using System.Windows.Controls;

using HashTool.ViewModels;

namespace HashTool.Views.Pages
{
    /// <summary>
    /// AboutPage.xaml 的交互逻辑
    /// </summary>
    public partial class AboutPage : Page
    {
        public AboutPage()
        {
            InitializeComponent();

            AboutPageViewModel aboutViewModel = new();

            DataContext = aboutViewModel;
        }
    }
}
