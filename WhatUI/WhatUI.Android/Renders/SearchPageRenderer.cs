using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WhatUI.Droid.Renders;
using Xamarin.Forms;
using WhatUI.Renderers;
using Xamarin.Forms.Platform.Android;
using SearchView = Android.Support.V7.Widget.SearchView;

[assembly: ExportRenderer(typeof(SearchPage), typeof(SearchPageRenderer))]
namespace WhatUI.Droid.Renders
{
    class SearchPageRenderer : PageRenderer
    {
        public SearchPageRenderer(Context context) : base(context)
        {
        }
    }
}