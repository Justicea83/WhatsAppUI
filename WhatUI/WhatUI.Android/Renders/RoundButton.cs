using System;
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

[assembly:ExportRenderer(typeof(CustomButton),typeof(RoundButton))]
namespace WhatUI.Droid.Renders
{
    public class RoundButton : ButtonRenderer
    {
        public RoundButton(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                var gd = new GradientDrawable();
                gd.SetCornerRadius(20);
                Control.SetBackground(gd);
            }
        }

    }
}