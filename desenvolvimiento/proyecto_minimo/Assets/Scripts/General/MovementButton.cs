using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementButton : MonoBehaviour
{
    public GameObject mostroZone;
    public GameObject fondoMostro;
    public GameObject returnZone; 
    float timer = 0;
    public MovimientoBola movimientoBola;
    public Collider2D colliderBasket;
    AudioSource aS;
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        aS = GetComponent<AudioSource>();
    }
    void OnMouseEnter(){
        if(timer>0){
            return;
        }
        aS.Play();
        var a = GameObject.FindGameObjectsWithTag("Mark");
        if (a.Length>0)
        {
            foreach(var c in a)
            {
                c.gameObject.SetActive(false);
            }
        }
        var list = GameObject.FindGameObjectsWithTag("bullet");
        if (list.Length > 0)
        {
            foreach (GameObject go in list)
            {
                if (go.GetComponent<SpriteRenderer>().enabled==false)
                {
                    go.GetComponent<SpriteRenderer>().enabled = true;
                }
                else
                {
                    go.GetComponent<SpriteRenderer>().enabled = false;
                }
            }
        }
        if (movimientoBola.stop==true){
            movimientoBola.RestartFuera();
            colliderBasket.enabled = true;
        }
        timer = 3;
        if(returnZone.active == true){
            returnZone.active =false;
            fondoMostro.GetComponent<Collider2D>().enabled = true;
            Invoke("VisiblePanel",3);
        }
        else{
            returnZone.active =true;
            fondoMostro.GetComponent<Collider2D>().enabled = false;
            Invoke("VisiblePanel", 3);
        }
        spriteRenderer.enabled = false;
    }
    
    void Update(){
        timer -= Time.deltaTime;

    }

    void VisiblePanel()
    {
        spriteRenderer.enabled = true;
    }
    
}
