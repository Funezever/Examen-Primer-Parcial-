using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Examen1parcial
{
    public class AgregarContactoPage : ContentPage
    {
        private Entry nombresEntry;
        private Entry apellidosEntry;
        private Entry edadEntry;
        private Entry paísEntry;
        private Entry notaEntry;
        private Button agregarButton;

        public AgregarContactoPage()
        {
            nombresEntry = new Entry { Placeholder = "Nombres" };
            apellidosEntry = new Entry { Placeholder = "Apellidos" };
            edadEntry = new Entry { Placeholder = "Edad", Keyboard = Keyboard.Numeric };
            paísEntry = new Entry { Placeholder = "País" };
            notaEntry = new Entry { Placeholder = "Nota" };

            agregarButton = new Button { Text = "Agregar" };
            agregarButton.Clicked += AgregarButton_Clicked;

            Content = new StackLayout
            {
                Children = {
                nombresEntry,
                apellidosEntry,
                edadEntry,
                paísEntry,
                notaEntry,
                agregarButton
            }
            };
        }

        private void AgregarButton_Clicked(object sender, EventArgs e)
        {
            var contacto = new Contacto
            {
                Nombres = nombresEntry.Text,
                Apellidos = apellidosEntry.Text,
                Edad = Convert.ToInt32(edadEntry.Text),
                País = paísEntry.Text,
                Nota = notaEntry.Text
            };

            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            
        }
    }

}
