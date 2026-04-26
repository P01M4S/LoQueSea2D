using UnityEngine;

[CreateAssetMenu(fileName = "New Language", menuName = "Localization/Language")]
public class LanguageData : ScriptableObject
{
    public string languageName;

    [Header("Textos UI")]
    public string text1;
    public string text2;
    public string text3;
    public string text4;

    [Header("Botones")]
    public string button1;
    public string button2;
    public string button3;
}
