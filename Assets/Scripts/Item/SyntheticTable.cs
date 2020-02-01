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
            itemEvents = Face.GetFaceEvent(Face.ChangeWakeUpFace),
            generateItemNames = GetListItems(ItemNameDictionary.Door, ItemNameDictionary.Wardrobe, ItemNameDictionary.Table, ItemNameDictionary.Bed)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Table,
            secondItemName = ItemNameDictionary.Eyes,
            generateItemNames = GetListItems(ItemNameDictionary.Document, ItemNameDictionary.Wallet, ItemNameDictionary.Phone)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Hand,
            secondItemName = ItemNameDictionary.Wardrobe,
            generateItemNames = GetListItems(ItemNameDictionary.Clothes)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Clothes,
            secondItemName = ItemNameDictionary.Face,
            itemEvents = Face.GetFaceEvent(Face.ChangeNormalFace),
            disappearItemNames = GetListItems(ItemNameDictionary.Clothes)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Foot,
            secondItemName = ItemNameDictionary.Door,
            itemEvents = Face.GetFaceEvent(Face.ChangeNormalFace),
            generateItemNames = GetListItems(ItemNameDictionary.Home),
            disappearItemNames = GetListItems(ItemNameDictionary.Door, ItemNameDictionary.Wardrobe, ItemNameDictionary.Table)
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
