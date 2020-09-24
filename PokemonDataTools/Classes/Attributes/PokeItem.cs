using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Attributes
{
    public class PokeItem
    {
        #region Static Attributes
        public static string[] CategoryNames = new string[] {
            "None", "Objetos", "Botiquín", "Poké Balls", "MTs y MOs", "Bayas", "Correo",
            "Objetos de batalla", "Objetos clave"
        };

        public static byte None = 0;
        public static byte Objetos = 1;
        public static byte Botiquin = 2;
        public static byte PokeBalls = 3;
        public static byte MTsMOs = 4;
        public static byte Bayas = 5;
        public static byte Correo = 6;
        public static byte ObjetosBatalla = 7;
        public static byte ObjetosClave = 8;

        public static byte CanNotBeUsedInCombat = 0;
        public static byte CanBeUsedOnPokemonAndDesapear = 1;
        public static byte CanBeUsedOnCombatAndDesapear = 2;
        public static byte CanBeUsedOnPokemonAndNotDesapear = 3;
        public static byte CanBeUsedDirectlyAndNotDesapear = 4;

        public static byte IsLetter = 1;
        public static byte IsLetterWithImage = 2;
        public static byte IsCepoBall = 3;
        public static byte IsPokeBall = 4;
        public static byte IsBerry = 5;
        public static byte IsKeyObject = 6;
        #endregion


        public int Id { get; set; }
        public string InternalName { get; set; }
        public string Name { get; set; }
        public string PluralName { get; set; }
        public byte Pocket { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public byte UseOutOfCombat { get; set; }
        public byte UseInCombat { get; set; }
        public byte SpecialObject { get; set; }
        public int MTIdMove { get; set; }

    }
}
