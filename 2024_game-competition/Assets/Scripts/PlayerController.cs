using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private Item currentItem;
    public Transform holdPoint;


    [Header("플레이어 움직임")] public float speed = 8f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");

        float xSpeed = xInput * speed;
        float ySpeed = yInput * speed;

        Vector2 newVelocity = new Vector2(xSpeed, ySpeed);

        rigidbody.velocity = newVelocity;


        if (currentItem != null && Input.GetKeyDown(KeyCode.F))
        {
            DropItem();
        }
    }


    public void PickUpItem(Item item)
    {
        if (currentItem != null)
        {
            DropItem();
        }
       
    }





    public void DropItem()
    {
        if (currentItem != null)
        {
            currentItem.Drop();
            currentItem = null;
        }
    }

    public bool HasItem()
    {
        return currentItem != null;
    }

}
