using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatUI.Models;
using WhatUI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatUI.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Chats : ContentPage
	{
        List<Message> Messages;
		public Chats ()
		{
			InitializeComponent ();
            Messages = new List<Message>()
            {
                new Message{Title="Justice",Detail="How are you doing",Created=DateTime.Now.TimeOfDay.ToString() },
                new Message{Title="Mike",Detail="Lorem Ipsum donor amet",Created=DateTime.Now.TimeOfDay.ToString()},
                new Message{Title="James",Detail="How are you doing",Created=DateTime.Now.TimeOfDay.ToString()},
                new Message{Title="Ismail",Detail=" executed when the button is clicked",Created=DateTime.Now.TimeOfDay.ToString()},
                new Message{Title="Joshua",Detail="How are you doing",Created=DateTime.Now.TimeOfDay.ToString()},
                new Message{Title="Emma",Detail="How are you doing",Created=DateTime.Now.TimeOfDay.ToString()},
                new Message{Title="Yawson",Detail="How are you doing",Created=DateTime.Now.TimeOfDay.ToString()},
                new Message{Title="New",Detail="How are you doing",Created=DateTime.Now.TimeOfDay.ToString()},
            };
            BindingContext = new ChatViewModel();
            ChatListView.ItemsSource = Messages;

        }

        private void ChatListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var message = e.SelectedItem as Message;
            //DisplayAlert("Selected", message.Detail, "Ok");
        }

        private void ChatListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var message = e.Item as Message;
            // DisplayAlert("Tapped", message.Detail, "Ok");
            Navigation.PushAsync(new ChatDetail() {
                Title = message.Title
            });

        }
    }
}