using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collector : MonoBehaviour
{
    private int kiwinum;
    [SerializeField] private Text kiwi;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("kiwi")) {
            Destroy(collision.gameObject);
            kiwinum++;
            kiwi.text = "kiwi number is : " + kiwinum;
        }

        if (collision.gameObject.CompareTag("cier"))
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                Destroy(player);
            }
        }

    }
}
