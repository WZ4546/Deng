using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collector : MonoBehaviour
{
    private int kiwinum;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("kiwi")) {
            Destroy(collision.gameObject);
            kiwinum++;
        }

    }
}
