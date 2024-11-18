﻿using StyledWindow.WPF.Commands;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp3.Properties;

namespace WpfApp3
{
    public partial class App
    {
        public App()
        {
            //ThemeEx.ChangeCulture += Action<string>;
   
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            await ThemeEx.LoadThemeAsync(null);
            //var load_com = new LoadThemeCommand();
            //load_com.Execute(null);
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await ThemeEx.SaveThemeAsync(null).ConfigureAwait(true);

            //var save_com = new SaveThemeCommand();
            //save_com.Execute(null);

            base.OnExit(e);
        }

        /// <summary>Set current culture settings</summary>
        

          
    }

}
