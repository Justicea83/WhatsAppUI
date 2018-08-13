using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace WhatUI.ViewModels
{
    class BaseViewModel
    {
        public BaseViewModel()
        {
            SearchCommand = new Command(()=> {
                Application.Current.MainPage.DisplayAlert("Search","Clicked","Ok");
            });
        }
        public ICommand SearchCommand { get; set; }

    }
}
