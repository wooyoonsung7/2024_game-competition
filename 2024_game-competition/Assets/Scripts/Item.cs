using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private bool isHeld = false; 
    private PlayerController player; 

    void Start()
    {
        player = FindObjectOfType<PlayerController>(); 
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DisplayCabinet"))
        {
            DisplayCabinet displayCabinet = other.GetComponent<DisplayCabinet>();
            if (displayCabinet != null && displayCabinet.HasItem()) // HasItem() 메서드 호출
            {
                Rigidbody2D rb = GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    rb.velocity = Vector2.zero;
                    rb.angularVelocity = 0f;

                    Vector2 pushDirection = (transform.position - other.transform.position).normalized;
                    rb.AddForce(pushDirection * 10f, ForceMode2D.Impulse);
                }
            }

    }   }


        public void PickUp()
        {
         if (!isHeld && !player.HasItem()) 
         {
            isHeld = true; 
            player.PickUpItem(this); 
            transform.SetParent(player.transform); 
            transform.localPosition = Vector3.zero; 
         }
        }


    public void Drop()
    {
        isHeld = false; 
        transform.SetParent(null); 
    }

   
}