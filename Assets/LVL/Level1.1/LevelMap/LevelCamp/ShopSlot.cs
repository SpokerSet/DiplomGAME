using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopSlot : MonoBehaviour
{
    private Player player;
    private InventoryController inventory;
    public Image itemImage;
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemPrice;
    public TextMeshProUGUI itemAmount;

    public GameObject itemToBuy;
    public int _ItemAmount;
    public TextMeshProUGUI buyPriceText;
    public TextMeshProUGUI GoldAmountText;

    void Start()
    {
        player = FindObjectOfType<Player>();
        player.coins = PlayerPrefs.GetInt("coins"); 
        inventory = FindObjectOfType<InventoryController>();
        itemName.text = itemToBuy.GetComponent<Spawn>().itemName;
        itemImage.sprite = itemToBuy.GetComponent<Image>().sprite;
        buyPriceText.text = itemToBuy.GetComponentInChildren<Spawn>().ItemPrice + " Coins";
    }

    void Update()
    {
        GoldAmountText.text = player.coins.ToString() + " Coins";
        itemAmount.text = "Количество: " + _ItemAmount.ToString();
    }

    public void Buy()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if(inventory.isFull[i] == true && inventory.slots[i].transform.GetComponent<Slot>().amount < 20 && player.coins >= itemToBuy.GetComponentInChildren<Spawn>().ItemPrice && _ItemAmount > 0) 
            {
                if(itemName.text == inventory.slots[i].transform.GetComponentInChildren<Spawn>().itemName)
                {
                    _ItemAmount -= 1;
                    inventory.slots[i].GetComponent<Slot>().amount += 1;
                    player.coins -= itemToBuy.GetComponentInChildren<Spawn>().ItemPrice;
                    PlayerPrefs.SetInt("coins", player.coins);
                    PlayerPrefs.Save();
                    break;
                }
            }else if(inventory.isFull[i] == false && player.coins >= itemToBuy.GetComponentInChildren<Spawn>().ItemPrice && _ItemAmount > 0)
            {
                _ItemAmount -= 1;
                player.coins -= itemToBuy.GetComponentInChildren<Spawn>().ItemPrice;
                PlayerPrefs.SetInt("coins", player.coins);
                PlayerPrefs.Save();
                inventory.slots[i].GetComponent<Slot>().ItemName.text = itemName.text;
                inventory.isFull[i] = true;
                Instantiate(itemToBuy, inventory.slots[i].transform, false);
                inventory.slots[i].GetComponent<Slot>().amount += 1;
                break;
            }
        }
    }

    public void Sell()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if(inventory.slots[i].transform.GetComponent<Slot>().amount != 0)
            {
                if(itemName.text == inventory.slots[i].transform.GetComponentInChildren<Spawn>().itemName){
                    _ItemAmount += 1;
                    inventory.slots[i].GetComponent<Slot>().amount -= 1;
                    player.coins += itemToBuy.GetComponentInChildren<Spawn>().ItemPrice / 2;
                    PlayerPrefs.SetInt("coins", player.coins);
                    PlayerPrefs.Save();
                    if(inventory.slots[i].GetComponent<Slot>().amount == 0)
                    {
                        inventory.slots[i].GetComponent<Slot>().ItemName.text = string.Empty;
                        GameObject.Destroy(inventory.slots[i].transform.GetComponentInChildren<Spawn>().gameObject);
                    }
                    break;
                }
            }
        }
    }
}
