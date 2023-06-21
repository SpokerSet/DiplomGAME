using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject itemPrefab;
    public string itemName;
    public int id;
    private Transform player;
    public int ItemPrice;
    
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector3 playerposition = new Vector3(player.position.x, player.position.y, player.position.z + 4);
        Instantiate(itemPrefab, playerposition, Quaternion.identity);
    }
}
