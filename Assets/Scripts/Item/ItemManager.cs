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
            CheckItemName(firstClickedItem.name, secondClickedItem.name);
            firstClickedItem = null;
            secondClickedItem = null;
        }
    }

    private void CheckItemName(string firstItemName, string secondItemName)
    {
        if (string.IsNullOrWhiteSpace(firstItemName) || string.IsNullOrWhiteSpace(secondItemName)) return;

        SyntheticItem item = SyntheticTable.syntheticItems.SingleOrDefault(obj => obj.firstItemName.Equals(firstItemName) && obj.secondItemName.Equals(secondItemName));
        if (item != null && item.generateItemNames != null)
        {
            item.itemEvents.Invoke();
            foreach (string generateItemName in item.generateItemNames)
            {
                GenerateItem(generateItemName);
            }
            foreach (var disappearItemName in item.disappearItemNames)
            {
                DisableItem(disappearItemName);
            }
        }
    }

    public void GenerateItem(string itemName)
    {
        GameObject obj = FindChildObjectByName(itemListInHierarchy, itemName);
        Debug.Log(itemName);
        Debug.Log(obj.name);
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
