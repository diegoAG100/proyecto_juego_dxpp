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
    void OnMouseEnter(){
        if(timer>0){
            return;
        }
        var a = GameObject.FindGameObjectsWithTag("Mark");
        if (a.Length>0)
        {
            foreach(var c in a)
            {
                c.gameObject.SetActive(false);
            }
        }
        timer = 3;
        if(returnZone.active == true){
            returnZone.active =false;
            fondoMostro.GetComponent<Collider2D>().enabled = true;
        }
        else{
            returnZone.active =true;
            fondoMostro.GetComponent<Collider2D>().enabled = false;
        }
    }
    
    void Update(){
        timer -= Time.deltaTime;
    }
}
