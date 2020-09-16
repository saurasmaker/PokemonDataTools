using System;
using System.Collections.Generic;
using System.Text;
using Classes.Attributes;

namespace Classes.Lists
{
    class ItemsList
    {

        public List<PokeItem> Items { get; set; }

        public ItemsList() { }

        public ItemsList(List<PokeItem> items) 
        {

            Items = items;
        }


        public static List<PokeItem> Load()
        {

            return null;
        }

    }
}
