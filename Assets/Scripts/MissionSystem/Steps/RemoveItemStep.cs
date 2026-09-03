using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "RemoveItemStep", menuName = "Mission System/Steps/Remove Item Step")]
public class RemoveItemStep : MissionStep
{
    [SerializeField] private ItemSO itemToRemove;
    [SerializeField] private int quantityToRemove = 1;

    public override IEnumerator Execute(MissionContext context)
    {
        PlayerInventory.Instance.RemoveItem(itemToRemove, quantityToRemove);
        yield return null;
    }
}
