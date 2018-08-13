using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatUI.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatUI.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calls : ContentPage
	{
        public List<Data> Data { get; set; }
        public Calls ()
		{
			InitializeComponent ();
            Data = new List<Data>()
            {
                new Data(){Name = "Justice", Image = ""},
                new Data(){Name = "Franck", Image = ""},
                new Data(){Name = "Robben", Image = ""},
                new Data(){Name = "Mike", Image = ""}
            };
            ListData.ItemsSource = Data;

        }
	}
}