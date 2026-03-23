using UnityEngine;
using UnityEngine.UI;

public class InfiniteInventorySlot : MonoBehaviour
{
    public ScripteableItem slotItem;
    public int slotNumber;

    public Text itemNameText;
    public Image itemImage;

    public GameObject inspectWindow;
    public Image InspectionImage;
    public Text inspectionName;
    public Text inspectionPrice;
    public Text inspectionDescription;

    public Button thisSlotButton;
    public Button deleteButton;
    public Button closeButton;

    void Awake()
    {
        itemNameText = GetComponentInChildren<Text>();
        itemImage = GetComponentInChildren<Image>();

        GameObject canvas = GameObject.Find("Canvas");
        inspectWindow = canvas.transform.Find("Inspect").gameObject;
        InspectionImage = inspectWindow.transform.Find("ItemImage").GetComponent<Image>();
        inspectionName = inspectWindow.transform.Find("ItemName").GetComponent<Text>();
        inspectionName = inspectWindow.transform.Find("ItemPrice").GetComponent<Text>();
        inspectionName = inspectWindow.transform.Find("ItemDescription").GetComponent<Text>();

        deleteButton = inspectWindow.transform.Find("Delete Buton").GetComponent<Button>();
        closeButton = inspectWindow.transform.Find("Close Buton").GetComponent<Button>();

        thisSlotButton = GetComponentInChildren<Button>();
        thisSlotButton.onClick.AddListener(InspectItem);
    }

    void Start()
    {
        itemNameText.text = slotItem.itemName;
        itemImage.sprite = slotItem.itemSprite;
    }

    void InspectItem()
    {
        if(slotItem != null)
        {
            deleteButton.onClick.RemoveAllListeners();

            closeButton.onClick.AddListener(CloseWindow);
            
            deleteButton.onClick.AddListener(DeleteItem);

            InspectionImage.sprite = slotItem.itemSprite;
            inspectionName.text = slotItem.itemName;
            inspectionPrice.text = slotItem.itemPrice.ToString();
            inspectionDescription.text = slotItem.itemDescription;

            inspectWindow.SetActive(true);
        }
    }
    void CloseWindow()
    {
        inspectWindow.SetActive(false);
        
        closeButton.onClick.RemoveListener(CloseWindow);
        deleteButton.onClick.RemoveListener(DeleteItem);
    }
    void DeleteItem()
    {
        InfiniteInventoryManager.Instance.items.Remove(slotItem);
        CloseWindow();
        Destroy(gameObject);
    }
}
