﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace atomic.rss.sl4.navigable
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(Home_Loaded);
        }

        void Home_Loaded(object sender, RoutedEventArgs e)
        {
            if (!WebContext.Current.Authentication.User.Identity.IsAuthenticated)
            {
                try
                {
                    ((atomic.rss.sl4.navigable.ViewModel.MainViewModel)DataContext).CurrentPage = "/LoginAndRegister";
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.StackTrace);
                }
            }
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}