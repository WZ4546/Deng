using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fastslug : MonoBehaviour
{
    [SerializeField] private GameObject[] points;
    private int index = 0;
    private Rigidbody2D rb;
    private Animator animator;
    [SerializeField] private bool right = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(points[index].transform.position, transform.position) < .1f)
        {
            animator.SetBool("right", false);
            index++;
            if (index >= points.Length)
            {
                index = 0;
                animator.SetBool("right", true);
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, points[index].transform.position, Time.deltaTime * 7f);
    }
}
