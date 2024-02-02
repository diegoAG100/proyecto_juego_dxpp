using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class Balon : MonoBehaviour
{
    public float scale = 1, scaleFin,scaleInicial;
    Collider2D col;
    public GameObject b;
    Rigidbody2D rb;
    public List<Collider2D> colliderList;
    Vector2 sP;
    bool movimiento = false; 
    SpriteRenderer sr;
    Animator anim;
    public AudioSource aS;

    bool basketUp = false;
    bool basketDown = false;
    void Start()
    {
        col = GetComponent<Collider2D>();
        scale = transform.localScale.x;
        scaleInicial = scale;
        scaleFin = scale / 3;
        sP = transform.localPosition;
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void a()
    {
        rb.gravityScale = 1;
        rb.AddForce((b.transform.position - transform.position) * 100);
        Invoke("ReturnSP", 5);
        movimiento = true;
    }
    void Update()
    {
        if (movimiento)
        {
            anim.SetTrigger("Lanzamiento");
            scale = Mathf.Lerp(scale, scaleFin, 0.003f);
            transform.localScale = new Vector3(scale, scale, scale);
            if (rb.velocity.y < 0)
            {
                sr.sortingOrder = 2;
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
        anim.ResetTrigger("Lanzamiento");
        anim.SetTrigger("Vuelta");
        movimiento = false;
        foreach (var collider in colliderList)
        {
            collider.enabled = false;
        }
        transform.localPosition = sP;
        gameObject.transform.localScale = new Vector2(scaleInicial, scaleInicial);
        scale = scaleInicial;
        rb.gravityScale = 0;
        rb.velocity = Vector3.zero;
        sr.sortingOrder = 4;
        }

        void OnTriggerEnter2D(Collider2D col){
            if(col.tag == "preCanasta"){
                basketUp = true;
            }
            if(basketUp&& col.tag == "canasta"){
                basketUp =false;
                AdministradorPunto.instance.AddPointsBasket();
                aS.Play(); 
            }
        }
    }

