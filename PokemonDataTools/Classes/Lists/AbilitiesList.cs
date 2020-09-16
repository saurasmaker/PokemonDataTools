using System;
using System.Collections.Generic;
using System.Text;
using Classes.Attributes;

namespace Classes.Lists
{
    class AbilitiesList
    {

        public List<PokeAbility> Abilities { get; set; }


        public AbilitiesList()
        {
            Abilities = new List<PokeAbility>();
        }

        public AbilitiesList(List<PokeAbility> abilities)
        {
            Abilities = abilities;
        }

        public static List<PokeAbility> Load()
        {


            return null;
        }
    }
}
