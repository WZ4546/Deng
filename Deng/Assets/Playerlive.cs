using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerlive : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("cier"))
        {
            Die();
        }
        if (collision.gameObject.CompareTag("slug"))
        {
            Die();
        }
    }

    private void Die() {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("died");
    }
    private void ReStartLevel()
    {
        collector.kiwinum = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
