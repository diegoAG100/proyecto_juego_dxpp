using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : MonoBehaviour
{
    public float scale = 1, scaleFin;
    Collider2D col;
    public GameObject b;
    Rigidbody2D rb;
    public List<Collider2D> colliderList;
    Vector2 sP;
    bool movimiento = false; 
    void Start()
    {
        col = GetComponent<Collider2D>();
        scale = transform.localScale.x;
        scaleFin = scale / 2;
        sP = transform.localPosition;
    }

    public void a()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1;
        rb.AddForce((b.transform.position - transform.position) * 100);
        Invoke("ReturnSP", 5);
        movimiento = true;
    }
    void Update()
    {
        if (movimiento)
        {
            scale = Mathf.Lerp(scale, scaleFin, 0.05f);
            transform.localScale = new Vector3(scale, scale, scale);
            if (rb.velocity.y < 0)
            {
                col.enabled = true;
                foreach (var collider in colliderList)
                {
                    collider.enabled = true;
                }
            }
        }

        }

        void ReturnSP()
        {
        movimiento = false;
        foreach (var collider in colliderList)
        {
            collider.enabled = false;
        }
        transform.localPosition = sP;
         gameObject.transform.localScale = new Vector2(scale, scale);
        }
    }

