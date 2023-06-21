using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private InventoryController inventory;
    public int i;
    public TextMeshProUGUI amountText;
    public TextMeshProUGUI ItemName;
    public int amount;

    void Start()
    {
        inventory = FindAnyObjectByType<InventoryController>();
    }

    void Update()
    {
        if(amount > 1)
        {
            transform.GetChild(0).GetComponent<TextMeshProUGUI>().enabled = true;
        }else{
            transform.GetChild(0).GetComponent<TextMeshProUGUI>().enabled = false;
        }

        amountText.text = amount.ToString();
        if(transform.childCount == 2)
        {
            inventory.isFull[i] = false;
        }
    }

    public void DropItem()
    {
        if(amount > 1)
        {
            amount -= 1;
            transform.GetComponentInChildren<Spawn>().SpawnDroppedItem();
        }else{
            amount -= 1;
            GameObject.Destroy(transform.GetComponentInChildren<Spawn>().gameObject);
            transform.GetComponentInChildren<Spawn>().SpawnDroppedItem();
        }
    }
}
