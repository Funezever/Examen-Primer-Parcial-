using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;



public class ListaContactosPage : ContentPage
{
    private ListView listView;

    public ListaContactosPage()
    {
        listView = new ListView();
        listView.ItemTemplate = new DataTemplate(typeof(ContactoCell));

        Content = new StackLayout
        {
            Children = { listView }
        };
    }
}
        
