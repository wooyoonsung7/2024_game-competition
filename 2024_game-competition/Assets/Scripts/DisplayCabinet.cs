using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCabinet : MonoBehaviour
{
    private bool hasItem = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            if (hasItem) // 물건이 이미 있는 경우
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
                hasItem = true; // 물건이 없으면 물건을 추가
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            hasItem = false; // 물건이 진열장에서 나가면 물건이 없다고 설정
        }
    }

    public bool HasItem()
    {
        return hasItem; // 물건이 있는지 여부를 반환
    }
}
