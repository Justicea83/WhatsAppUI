﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WhatUI.Droid.Renders;
using WhatUI.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ChatEntry),typeof(EditEntry))]
namespace WhatUI.Droid.Renders
{
    public class EditEntry : EditorRenderer
    {
        public EditEntry(Context con):base(con)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);


            if (e.NewElement != null)
            {
                var element = e.NewElement as ChatEntry;
                var gd = new GradientDrawable();
                gd.SetColor(Android.Graphics.Color.White);
                Control.SetBackground(gd);
                Control.SetPadding(50, 30, 50, 30);
                Control.Hint = element.Placeholder;
                Control.SetHintTextColor(Android.Graphics.Color.LightGray);
            }
        }

    }
}