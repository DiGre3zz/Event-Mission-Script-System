using System.Collections.Generic;
using UnityEngine;

public class OpenChestInteraction : InteractionType
{
    [SerializeField] GameObject objectPrefab;
    [SerializeField] private Transform[] spawnPoints;


    public override void InteractWithObject()
    {
        ChestContainer chest = GetComponent<ChestContainer>();
        List<ItemSO> items = chest.items;
        for (int i = 0; i < items.Count; i++)
           {
            GameObject spawnedItem = Instantiate(objectPrefab, spawnPoints[i].position, Quaternion.identity);
            spawnedItem.GetComponent<PickUpInteraction>().SetItem(items[i]);
          }
        Destroy(gameObject);
    }
}
