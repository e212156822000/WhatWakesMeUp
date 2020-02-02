using UnityEngine;
using System.Linq;
using System.Collections;

public class ItemManager : MonoBehaviour
{
    public static GameObject firstClickedItem;
    public static GameObject secondClickedItem;

    public GameObject itemListInHierarchy;

    public AudioSource pop;

    // Start is called before the first frame update
    void Start()
    {
        pop = this.GetComponent<AudioSource>();
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

        // 彈開
        if (item == null)
        {
            var rb = GameObject.Find(secondItemName).GetComponent<Rigidbody2D>();
            var xSpeed = Input.GetAxis("Mouse X");
            var ySpeed = Input.GetAxis("Mouse Y");
            rb.velocity = new Vector2(xSpeed, ySpeed) * 2;
        }

        // 觸發事件
        else
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
        }
    }

    public void GenerateItem(string itemName)
    {
        GameObject obj = FindChildObjectByName(itemListInHierarchy, itemName);
        if (obj == null) return;
        WakeUpItem(obj);
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

    public float expandSpeed = 0.0001f;
    public float expandRate = 1.0005f;
    public float shiftRate = 0.0f;
    private Vector3 origin;
    public void WakeUpItem(GameObject obj)
    {
        obj.SetActive(true);
        StartCoroutine(Expand());
    }

    public IEnumerator Expand()
    {
        pop.Play();
        while (expandSpeed < 1.0f)
        {
            this.gameObject.transform.localScale = new Vector3(expandSpeed, expandSpeed, 1.0f);
            expandSpeed *= expandRate;
            expandRate += 0.0001f;
            yield return new WaitForSeconds(0.2f);
        }
        origin = this.gameObject.transform.localPosition;
        while (shiftRate < 0.5f)
        {
            this.gameObject.transform.position = new Vector3(origin.x, origin.y + shiftRate, origin.z);
            shiftRate += 0.025f;
            yield return new WaitForSeconds(0.1f);
        }
        while (shiftRate > 0.0f)
        {
            this.gameObject.transform.position = new Vector3(origin.x, origin.y + shiftRate, origin.z);
            shiftRate -= 0.05f;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
