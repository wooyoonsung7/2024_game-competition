using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCabinet : MonoBehaviour
{
    private bool hasItem = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Item item = other.GetComponent<Item>();
        if (item != null && item.IsHeld())
        {
            
            PlaceItemInCabinet(item);
        }

        if (other.CompareTag("Item"))
        {
            if (hasItem)
            {
               
                Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.velocity = Vector2.zero;
                    rb.angularVelocity = 0f;   

                    
                    Vector2 pushDirection = (other.transform.position - transform.position).normalized;
                    rb.AddForce(pushDirection * 10f, ForceMode2D.Impulse);
                }
            }
            else
            {
               
                 hasItem = true;
            }
        }
    }

    private void PlaceItemInCabinet(Item item)
    {
        item.Drop();
        item.transform.position = transform.position; 
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            
            hasItem = false;
        }
    }

    public bool IsHeld()
    {
        return isHeld;
    }
}
