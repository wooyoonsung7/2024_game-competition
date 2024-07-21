using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseItem : MonoBehaviour, IInteractable
{
    public string itemName;
    public int itemPrice;

    public void Interact()
    {
        
        Debug.Log("Purchased: " + itemName + " for " + itemPrice + " coins.");    // 여기에서 구매 로직을 구현.
    }
}
