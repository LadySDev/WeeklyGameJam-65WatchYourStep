using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrEnglish : ScrLanguage {

	public ScrEnglish()
    {

        dictio = new Dictionary<string, string>()
        {
            //Title
        { "Play" , "Play" },
        { "Options" , "Options" },
        { "Quit" , "Quit" },
            //Options
        { "Language" , "Language" },
        { "Resolution" , "Resolution" },
        { "FullScreen" , "FullScreen" },
        { "Valid" , "Valid" },
        { "Cancel" , "Cancel" }
        };

    }

}
