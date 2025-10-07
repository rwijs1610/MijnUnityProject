using UnityEngine;

public class SpellCaster : MonoBehaviour
{

    string MaakSpreukInfo(string naam, int manaKosten, string effect, bool isBeschikbaar)
    {

        return $"Spreuk: {naam}, Manakosten: {manaKosten}, Effect: {effect}, Beschikbaar: {isBeschikbaar}";
    }

    void ToonSpreuken()
    {

        string vlammenzee = MaakSpreukInfo("Vlammenzee", 50, "Omringt een doelwit met een muur van vuur.", true);
        Debug.Log(vlammenzee);


        string mistgordijn = MaakSpreukInfo("Mistgordijn", 25, "Creëert een dichte mist die het zicht belemmert.", false);
        Debug.Log(mistgordijn);
    }

    void Start()
    {
        ToonSpreuken();
    }
}
