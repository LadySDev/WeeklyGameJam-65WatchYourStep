using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrFrench : ScrLanguage
{

    public ScrFrench()
    {

        dictio = new Dictionary<string, string>()
        {
            //Title
        { "Play" , "Jouer" },
        { "Options" , "Options" },
        { "Quit" , "Quitter" },
            //Options
        { "Language" , "Langue" },
        { "Resolution" , "Résolution" },
        { "FullScreen" , "Plein Ecran" },
        { "Valid" , "Valider" },
        { "Cancel" , "Annuler" }
        };

    }

}
