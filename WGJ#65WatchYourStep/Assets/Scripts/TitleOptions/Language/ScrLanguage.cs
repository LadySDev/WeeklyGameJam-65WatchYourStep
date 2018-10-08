using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrLanguage {

    protected Dictionary<string, string> dictio;        

    public string TranslationWord(string key)
    {
        return dictio[key];
    }

}
