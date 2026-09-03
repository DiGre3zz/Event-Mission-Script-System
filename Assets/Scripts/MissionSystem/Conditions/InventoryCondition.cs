using UnityEngine;

[CreateAssetMenu(fileName = "ItemInInventoryCondition", menuName = "Mission System/Conditions/Inventory Condition")]
public class InventoryCondition : MissionCondition
{
    [SerializeField] private ItemSO requiredItem;

    public override bool IsMet(MissionContext context)
    {
        return
        PlayerInventory.Instance.HasItem(requiredItem);
    }
}
