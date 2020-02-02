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
            itemEvents = FaceManager.GetFaceEvent(FaceManager.Instance.ChangeWakeUpFace),
            generateItemNames = GetListItems(ItemNameDictionary.Door, ItemNameDictionary.Wardrobe, ItemNameDictionary.Table, ItemNameDictionary.Bed)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Eyes,
            secondItemName = ItemNameDictionary.Table,
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
            itemEvents = FaceManager.GetFaceEvent(FaceManager.Instance.ChangeNormalFace),
            disappearItemNames = GetListItems(ItemNameDictionary.Clothes)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Foot,
            secondItemName = ItemNameDictionary.Door,
            generateItemNames = GetListItems(ItemNameDictionary.Home, ItemNameDictionary.MRT),
            disappearItemNames = GetListItems(ItemNameDictionary.Door, ItemNameDictionary.Wardrobe, ItemNameDictionary.Table)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Foot,
            secondItemName = ItemNameDictionary.MRT,
            generateItemNames = GetListItems(ItemNameDictionary.Office,ItemNameDictionary.Playground,ItemNameDictionary.Shop)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Foot,
            secondItemName = ItemNameDictionary.Home,
            itemEvents = FaceManager.GetFaceEvent(FaceManager.Instance.ChangeNormalFace2),
            generateItemNames = GetListItems(ItemNameDictionary.Door, ItemNameDictionary.Wardrobe, ItemNameDictionary.Table),
            disappearItemNames = GetListItems(ItemNameDictionary.MRT, ItemNameDictionary.Home)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Foot,
            secondItemName = ItemNameDictionary.Shop,
            generateItemNames = GetListItems(ItemNameDictionary.Food)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.MRT,
            secondItemName = ItemNameDictionary.Shop,
            generateItemNames = GetListItems(ItemNameDictionary.Food)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.MRT,
            secondItemName = ItemNameDictionary.Office,
            generateItemNames = GetListItems(ItemNameDictionary.CoWorker,ItemNameDictionary.Computer),
            disappearItemNames = GetListItems(ItemNameDictionary.MRT,ItemNameDictionary.Shop,ItemNameDictionary.Playground,ItemNameDictionary.Home)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Mouth,
            secondItemName = ItemNameDictionary.CoWorker,
            generateItemNames = GetListItems(ItemNameDictionary.Project)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Eyes,
            secondItemName = ItemNameDictionary.Computer,
            generateItemNames = GetListItems(ItemNameDictionary.Keyboard)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Hand,
            secondItemName = ItemNameDictionary.Keyboard,
            generateItemNames = GetListItems(ItemNameDictionary.Email,ItemNameDictionary.Web,ItemNameDictionary.Unity)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Keyboard,
            secondItemName = ItemNameDictionary.Email,
            generateItemNames = GetListItems(ItemNameDictionary.AD),
            disappearItemNames = GetListItems(ItemNameDictionary.Email)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Keyboard,
            secondItemName = ItemNameDictionary.Web,
            generateItemNames = GetListItems(ItemNameDictionary.Twitch,ItemNameDictionary.Steam,ItemNameDictionary.MicrosoftDocs)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Keyboard,
            secondItemName = ItemNameDictionary.Steam,
            generateItemNames = GetListItems(ItemNameDictionary.Game),
            disappearItemNames = GetListItems(ItemNameDictionary.Steam)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Unity,
            secondItemName = ItemNameDictionary.Project,
            generateItemNames = GetListItems(ItemNameDictionary.Bug),
            disappearItemNames = GetListItems(ItemNameDictionary.Project)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Project,
            secondItemName = ItemNameDictionary.Unity,
            generateItemNames = GetListItems(ItemNameDictionary.Bug),
            disappearItemNames = GetListItems(ItemNameDictionary.Project)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Eyes,
            secondItemName = ItemNameDictionary.Bug,
            generateItemNames = GetListItems(ItemNameDictionary.Error)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.MicrosoftDocs,
            secondItemName = ItemNameDictionary.Error,
            generateItemNames = GetListItems(ItemNameDictionary.Solution),
            disappearItemNames = GetListItems(ItemNameDictionary.Error)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Error,
            secondItemName = ItemNameDictionary.MicrosoftDocs,
            generateItemNames = GetListItems(ItemNameDictionary.Solution),
            disappearItemNames = GetListItems(ItemNameDictionary.Error)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Solution,
            secondItemName = ItemNameDictionary.Bug,
            generateItemNames = GetListItems(ItemNameDictionary.DoneWork),
            disappearItemNames = GetListItems(ItemNameDictionary.Bug)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Bug,
            secondItemName = ItemNameDictionary.Solution,
            generateItemNames = GetListItems(ItemNameDictionary.DoneWork),
            disappearItemNames = GetListItems(ItemNameDictionary.Bug)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Eyes,
            secondItemName = ItemNameDictionary.AD,
            generateItemNames = GetListItems(ItemNameDictionary.GlobalGameJamActivityInformation)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Eyes,
            secondItemName = ItemNameDictionary.Twitch,
            generateItemNames = GetListItems(ItemNameDictionary.GlobalGameJamLive)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.Keyboard,
            secondItemName = ItemNameDictionary.Game,
            generateItemNames = GetListItems(ItemNameDictionary.Dream)
        },
        new SyntheticItem
        {
            firstItemName = ItemNameDictionary.DoneWork,
            secondItemName = ItemNameDictionary.CoWorker,
            generateItemNames = GetListItems(ItemNameDictionary.Home)
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
