﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinApp
{
	public partial class App : Application
	{
        public static string DatabaseConnection = string.Empty;

		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new LoginPage());
        }

        public App(string dbConnection)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

            DatabaseConnection = dbConnection;
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
