using TMPro;
using UnityEngine;

public class LanguageDropdown : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    private void Start()
    {
        dropdown.onValueChanged.AddListener(ChangeLanguage);
    }

    void ChangeLanguage(int index)
    {
        LanguageManager.Instance.ApplyLanguage(index);
    }
}