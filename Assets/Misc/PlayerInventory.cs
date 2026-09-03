using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory Instance { get; private set; }

    private Dictionary<ItemSO, int> items = new();

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void AddItem(ItemSO item, int quantity = 1)
    {
        if (!item.stackable)
            quantity = 1;

        if (items.ContainsKey(item))
            items[item] = Mathf.Min(items[item] + quantity, item.maxStack);
        else
            items[item] = Mathf.Min(quantity, item.maxStack);
            Debug.Log($"Added {quantity} of {item.displayName} to inventory. Total: {items[item]}");
    }

    public bool RemoveItem(ItemSO item, int quantity = 1)
    {
        if (!items.TryGetValue(item, out int current) || current < quantity)
            return false;

        items[item] -= quantity;
        if (items[item] <= 0)
            items.Remove(item);

        return true;
    }

    public bool HasItem(ItemSO item, int quantity = 1) =>
        items.TryGetValue(item, out int current) && current >= quantity;

    public int GetQuantity(ItemSO item)
    {
        items.TryGetValue(item, out int quantity);
        return quantity;
    }

    public IReadOnlyDictionary<ItemSO, int> GetAll() => items;
}