using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookies : MonoBehaviour
{
    public Rigidbody2D rb;
    private int targetPoints = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = Random.Range(0.09f, 0.15f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.Instance.AddPoints(targetPoints);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Floor"))
        {
            LivesManager.Instance.LossingLive(1);
            Destroy(gameObject);
        }
    }

}
