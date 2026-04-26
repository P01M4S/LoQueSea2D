using UnityEngine;

public class UIButtonTranslation : MonoBehaviour
{
    public int languageIndex;

    public void ChangeLanguage()
    {
        LanguageManager.Instance.ApplyLanguage(languageIndex);
    }
}