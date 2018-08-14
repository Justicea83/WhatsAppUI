using System;
using WhatUI.Models;
using WhatUI.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace WhatUI
{
	public partial class App : Application
	{
        public static Repository Repository;
		public App (string dbPath)
		{
            #if DEBUG
            LiveReload.Init();
            #endif
            InitializeComponent();

            MainPage = new NavigationPage(new BasePage())
            {
                BarBackgroundColor = Color.FromHex("#0a877a"),
                
            };
            Repository = new Repository(dbPath);
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
