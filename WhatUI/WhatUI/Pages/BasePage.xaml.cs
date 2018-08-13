using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatUI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatUI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasePage : TabbedPage
    {
        public BasePage ()
        {
            InitializeComponent();
            BindingContext = new BaseViewModel();
            //setting the current child
            CurrentPage = Children[1];
        }
    }
}