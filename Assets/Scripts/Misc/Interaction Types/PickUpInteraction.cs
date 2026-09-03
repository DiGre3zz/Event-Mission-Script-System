using UnityEngine;

public class PickUpInteraction : InteractionType
{
    [SerializeField] private ItemSO itemSO;
    public override void InteractWithObject()
    {
        PlayerInventory.Instance.AddItem(itemSO, 1);
        Destroy(gameObject);
    }

    public void SetItem(ItemSO item)
    {
      itemSO = item;
      GetComponent<SpriteRenderer>().sprite = item.icon;
    }
}
