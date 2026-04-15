using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Localization.Settings;

public class LocalizationScript : MonoBehaviour
{
    private bool active = false;
    public void ChangeLocale(int localeID)
    {
        if(active = true)
            return;
        
        StartCoroutine(SetLocale(localeID));
    }
    IEnumerator SetLocale(int _localeID);
    {
        active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvaiableLocales.Locales[_localeID];
        active = false;
    }
}
