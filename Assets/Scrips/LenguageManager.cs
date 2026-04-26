using TMPro;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    public static LanguageManager Instance;

    [Header("Idiomas")]
    public LanguageData[] languages;

    [Header("Textos UI")]
    public TMP_Text uiText1;
    public TMP_Text uiText2;
    public TMP_Text uiText3;
    public TMP_Text uiText4;

    [Header("Botones")]
    public TMP_Text buttonText1;
    public TMP_Text buttonText2;
    public TMP_Text buttonText3;

    private int currentLanguage = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        ApplyLanguage(currentLanguage);
    }

    public void ApplyLanguage(int index)
    {
        if (index < 0 || index >= languages.Length) return;

        currentLanguage = index;

        LanguageData lang = languages[index];

        uiText1.text = lang.text1;
        uiText2.text = lang.text2;
        uiText3.text = lang.text3;
        uiText4.text = lang.text4;

        buttonText1.text = lang.button1;
        buttonText2.text = lang.button2;
        buttonText3.text = lang.button3;
    }
}