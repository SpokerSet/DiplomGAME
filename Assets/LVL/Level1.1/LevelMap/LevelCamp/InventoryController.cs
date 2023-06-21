using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public InstallCustom installPlayer;
    public bool[] isFull;
    public GameObject[] slots;

    void Start()
    {
        installPlayer.InstCustomColor();
		installPlayer.InstCustomParts();
    }
    
}
