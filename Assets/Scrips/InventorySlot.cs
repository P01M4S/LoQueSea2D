using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public ScripteableItem slotItem;
    public int slotNumber;
    public GameObject inspectWindow;
    public Image InspectionImage;
    public Text inspectionName;
    public Text inspectionPrice;
    public Text inspectionDescription;

    public Button thisSlotButton;
    public Button deleteButton;
    public Button closeButton;

    void Start()
    {
        thisSlotButton = GetComponentInChildren<Button>();
        thisSlotButton.onClick.AddListener(InspectItem);
    }

    void InspectItem()
    {
        if(slotItem != null)
        {
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

    }
    void DeleteItem()
    {

    }

}
