
namespace Classes.Attributes
{
    public class PokeItem
    {
        #region Static Attributes
        public static readonly string[] CategoryNames = new string[] {
            "None", "Objetos", "Botiquín", "Poké Balls", "MTs y MOs", "Bayas", "Correo",
            "Objetos de batalla", "Objetos clave"
        };

        public static readonly byte None = 0;
        public static readonly byte Objetos = 1;
        public static readonly byte Botiquin = 2;
        public static readonly byte PokeBalls = 3;
        public static readonly byte MTsMOs = 4;
        public static readonly byte Bayas = 5;
        public static readonly byte Correo = 6;
        public static readonly byte ObjetosBatalla = 7;
        public static readonly byte ObjetosClave = 8;

        public static readonly byte CanNotBeUsedInCombat = 0;
        public static readonly byte CanBeUsedOnPokemonAndDesapear = 1;
        public static readonly byte CanBeUsedOnCombatAndDesapear = 2;
        public static readonly byte CanBeUsedOnPokemonAndNotDesapear = 3;
        public static readonly byte CanBeUsedDirectlyAndNotDesapear = 4;

        public static readonly byte IsLetter = 1;
        public static readonly byte IsLetterWithImage = 2;
        public static readonly byte IsCepoBall = 3;
        public static readonly byte IsPokeBall = 4;
        public static readonly byte IsBerry = 5;
        public static readonly byte IsKeyObject = 6;
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
