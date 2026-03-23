using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    public ScripteableItem item;
    public SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        spriteRenderer.sprite = item.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        InfiniteInventoryManager.Instance.AddItem(item);
        Destroy(gameObject);
    }
}
