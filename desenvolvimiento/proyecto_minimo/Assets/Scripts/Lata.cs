using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lata : MonoBehaviour
{

    public float fuerzaBase = 10f;
    public float fuerzaHorizontalMaxima = 50f;
    public AudioClip random1, random2, random3;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
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

            switch (Random.Range(0,3))
            {
                case 0: audioSource.clip = random1; break;
                case 1: audioSource.clip = random2; break;
                case 2: audioSource.clip = random3; break;
            }
            audioSource.Play();
            GetComponent<Collider2D>().enabled=false;
            Destroy(collision.gameObject);
        }
    }
}
