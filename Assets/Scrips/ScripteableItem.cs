using UnityEngine;

[CreateAssetMenu(fileName = "New Item" , menuName = "ScriptableObjects/Items")]
public class ScripteableItem : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public int itemPrice;
    public Sprite itemSprite;
}
