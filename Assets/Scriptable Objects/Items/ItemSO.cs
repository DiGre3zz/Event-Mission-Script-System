using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/Item")]
public class ItemSO : ScriptableObject
{
    public string displayName;
    public Sprite icon;
    [TextArea] public string description;
    public bool stackable = true;
    public int maxStack = 99;
}