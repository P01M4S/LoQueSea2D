using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    public ScripteableItem[] items;
    public Text[] itemNames;
    public Image[] itemImages;
    public InventorySlot[] itemSlots;

    public void AddItem(ScripteableItem item)
    {
        for(int i= 0; i < items.Length; i++)
        {
            if(items[i] == null)
            {
                items[i] = item;
                itemNames[i].text = item.itemName;
                itemImages[i].sprite = item.itemSprite;

                itemSlots[i].slotItem = item;
                itemSlots[i].slotNumber = i;

                return;
            }
        }
    }
    
}
