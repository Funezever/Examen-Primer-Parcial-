using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1parcial
{
    public class ContactoDatabase
    {
        private SQLiteConnection database;

        public ContactoDatabase(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            database.CreateTable<Contacto>();
        }

        public void InsertarContacto(Contacto contacto)
        {
            database.Insert(contacto);
        }

        public void EliminarContacto(Contacto contacto)
        {
            database.Delete<Contacto>(contacto.Id);
        }

        public void ActualizarContacto(Contacto contacto)
        {
            database.Update(contacto);
        }

        public List<Contacto> ObtenerContactos()
        {
            return database.Table<Contacto>().ToList();
        }
    }

}
