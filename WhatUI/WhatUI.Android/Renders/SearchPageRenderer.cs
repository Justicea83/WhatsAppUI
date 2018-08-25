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
using Android.Views.InputMethods;
using Android.Text;

[assembly: ExportRenderer(typeof(SearchPage), typeof(SearchPageRenderer))]
namespace WhatUI.Droid.Renders
{
    class SearchPageRenderer : PageRenderer
    {
        private SearchView _searchView;
        public SearchPageRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            if(e.NewElement == null && e.OldElement == null)
            {
                return;
            }
            AddSearchToToolBar();
        }
        protected override void Dispose(bool disposing)
        {
            if (_searchView != null)
            {
                _searchView.QueryTextChange += searchView_QueryTextChange;
                _searchView.QueryTextSubmit += searchView_QueryTextSubmit;
            }
            MainActivity.ToolBar?.Menu?.RemoveItem(Resource.Menu.mainmenu);
            base.Dispose(disposing);
        }

        private void AddSearchToToolBar()
        {
            MainActivity.ToolBar.Title = Element.Title;

            MainActivity.ToolBar.InflateMenu(Resource.Menu.mainmenu);

            _searchView = MainActivity.ToolBar.Menu?.FindItem(Resource.Id.action_search)?.ActionView?.JavaCast<SearchView>();

            _searchView.QueryTextChange += searchView_QueryTextChange;
            _searchView.QueryTextSubmit += searchView_QueryTextSubmit;
            _searchView.QueryHint = (Element as SearchPage)?.SearchPlaceHolderText;
            _searchView.ImeOptions = (int)ImeAction.Search;
            _searchView.InputType = (int)InputTypes.TextVariationNormal;
            _searchView.MaxWidth = int.MaxValue;
            //_searchView
           // _searchView.SetBackgroundColor(Android.Graphics.Color.White);
        }

        private void searchView_QueryTextSubmit(object sender, SearchView.QueryTextSubmitEventArgs e)
        {
            var searchPage = Element as SearchPage;
            searchPage.SearchText = e.Query;
            searchPage.SearchCommand?.Execute(e.Query);
            e.Handled = true;
        }

        private void searchView_QueryTextChange(object sender, SearchView.QueryTextChangeEventArgs e)
        {
            var searchPage = Element as SearchPage;
            searchPage.SearchText = e?.NewText;
        }
    }
}