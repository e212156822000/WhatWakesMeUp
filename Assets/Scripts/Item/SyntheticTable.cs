using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SyntheticTable : MonoBehaviour
{
    public static List<SyntheticItem> syntheticItems = new List<SyntheticItem>
    {
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Hand,
            secondItemName = ItemNameDictionary.Alarm,
            itemEvents = GameObject.Find(ItemNameDictionary.Alarm).GetComponent<ItemEventBasic>().itemEvent,
            generateItemNames = GetListItems(ItemNameDictionary.Eyes),
            disappearItemNames = GetListItems(ItemNameDictionary.Alarm)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Eyes,
            secondItemName = ItemNameDictionary.Face,
            generateItemNames = GetListItems(ItemNameDictionary.Door, ItemNameDictionary.wardrobe, ItemNameDictionary.Table, ItemNameDictionary.Bed)
        }
    };

    public static List<string> GetListItems(params string[] itemNames)
    {
        List<string> generateItems = new List<string>();
        generateItems.AddRange(itemNames);
        return generateItems;
    }
}

public class SyntheticItem
{
    public string firstItemName;
    public string secondItemName;
    public UnityEvent itemEvents;
    public List<string> generateItemNames;
    public List<string> disappearItemNames;
}
