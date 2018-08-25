using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace WhatUI.Droid
{
    [Activity(Label = "WhatUI", Icon = "@mipmap/icon", Theme = "@style/MainTheme", 
        MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static Android.Support.V7.Widget.Toolbar ToolBar { get; private set; }
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            var dbPath = Path.Combine(path, "..","Library","data");
            if (!Directory.Exists(dbPath))
            {
                Directory.CreateDirectory(dbPath);
            }
            var finalPath = Path.Combine(dbPath, "database.sqlite");
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(finalPath));
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            ToolBar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            return base.OnCreateOptionsMenu(menu);
        }
    }
}

