using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WhatUI.Pages;
using Xamarin.Forms;

namespace WhatUI.ViewModels
{
    public class ChatViewModel
    {
        public ChatViewModel()
        {
            ContactCommand = new Command( async ()=> {
                await Application.Current.MainPage.Navigation.PushAsync(new ContactPage());
            });
        }
        public ICommand ContactCommand { get; set; }

    }
}
