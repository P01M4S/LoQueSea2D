using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InfiniteInventoryManager : MonoBehaviour
{
    public static InfiniteInventoryManager Instance;
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

        inventoryCanvasTransform = GameObject.Find("Inventory").transform;
    }
    public List<ScripteableItem> items;
    public List<InventorySlot> itemSlots;

    public GameObject slotPrefab;

    public Transform inventoryCanvasTransform;

    public void AddItem(ScripteableItem item)
    {
        GameObject prefab =  Instantiate(slotPrefab);
        prefab.transform.SetParent(inventoryCanvasTransform);

        InfiniteInventorySlot prefabScript = prefab.GetComponent<InfiniteInventorySlot>();
        prefabScript.slotItem = item;
        items.Add(item);
    }
    
}
