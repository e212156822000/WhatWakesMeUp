using UnityEngine;
using System.Linq;

public class ItemManager : MonoBehaviour
{
    public static GameObject firstClickedItem;
    public static GameObject secondClickedItem;

    public GameObject itemListInHierarchy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckItemState();
    }

    public void CheckItemState()
    {
        if (firstClickedItem != null && secondClickedItem != null)
        {
            string firstName = firstClickedItem.name;
            string secondName = secondClickedItem.name;

            firstClickedItem = null;
            secondClickedItem = null;
            CheckItemName(firstName, secondName);
        }
    }

    private void CheckItemName(string firstItemName, string secondItemName)
    {
        if (string.IsNullOrWhiteSpace(firstItemName) || string.IsNullOrWhiteSpace(secondItemName)) return;

        SyntheticItem item = SyntheticTable.syntheticItems.SingleOrDefault(obj => obj.firstItemName.Equals(firstItemName) && obj.secondItemName.Equals(secondItemName));
        if (item != null && item.generateItemNames != null)
        {
            if (item.itemEvents != null)
            {
                item.itemEvents.Invoke();
            }
            if (item.generateItemNames != null)
            {
                foreach (string generateItemName in item.generateItemNames)
                {
                    GenerateItem(generateItemName);
                }
            }
            if (item.disappearItemNames != null)
            {
                foreach (var disappearItemName in item.disappearItemNames)
                {
                    DisableItem(disappearItemName);
                }
            }
            SyntheticTable.syntheticItems.Remove(item);
        }
    }

    public void GenerateItem(string itemName)
    {
        GameObject obj = FindChildObjectByName(itemListInHierarchy, itemName);
        if (obj == null) return;
        obj.SetActive(true);
    }

    public void DisableItem(string itemName)
    {
        GameObject obj = FindChildObjectByName(itemListInHierarchy, itemName);
        obj.SetActive(false);
    }

    public GameObject FindChildObjectByName(GameObject parent, string itemName)
    {
        Transform childTrans = parent.transform.Find(itemName);
        if (childTrans != null)
            return childTrans.gameObject;
        return null;
    }
}
