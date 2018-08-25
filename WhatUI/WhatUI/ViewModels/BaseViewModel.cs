using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WhatUI.Renderers;
using Xamarin.Forms;

namespace WhatUI.ViewModels
{
    class BaseViewModel
    {
        public BaseViewModel()
        {
            SearchCommand = new Command(()=> {
                Application.Current.MainPage.Navigation.PushAsync(new SearchPage {
                    SearchPlaceHolderText = "Search..."
                });
            });
        }
        public ICommand SearchCommand { get; set; }

    }
}
