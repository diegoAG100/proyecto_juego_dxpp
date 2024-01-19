using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lata : MonoBehaviour
{

    public float fuerzaBase = 10f;
    public float fuerzaHorizontalMaxima = 50f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="bullet")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            rb.isKinematic = false;

            Vector2 fuerza = Vector2.up * fuerzaBase;

            fuerza.x += Random.Range(-fuerzaHorizontalMaxima, fuerzaHorizontalMaxima);

            rb.AddForce(fuerza, ForceMode2D.Impulse);
            rb.AddTorque(Random.Range(-150f,150f));

            GetComponent<Collider2D>().enabled=false;
        }
    }
}
