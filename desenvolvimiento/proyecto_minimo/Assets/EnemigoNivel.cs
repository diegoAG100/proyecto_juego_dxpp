using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemigoNivel : MonoBehaviour
{
    public GameObject mostro;
    public Sprite luz,sinLuz;
    SpriteRenderer srMostro;
    public SpriteRenderer srEscenario;
    float timer = 0;
    bool mostroDesaparece;
    void Start(){
        srMostro = mostro.GetComponent<SpriteRenderer>();
    }

    void OnMouseDown(){
        if(timer >0){
            return;
        }

        if(mostro.active==true){
            srMostro.color = Color.white;
            mostroDesaparece = true;
        }
        timer=6;
        srEscenario.sprite = luz;
        StartCoroutine(Tapar());
    }

    IEnumerator Tapar(){
        yield return new WaitForSeconds(2);
        if(mostro.active==true){
            srMostro.color = Color.black;
            mostro.active=false;
        }
            srEscenario.sprite = sinLuz;
            mostroDesaparece = false;
    }

    void Update(){
        timer-=Time.deltaTime;
        if(mostroDesaparece){
            srMostro.color = new Color(srMostro.color.r,srMostro.color.g,srMostro.color.b,srMostro.color.a-0.8f*Time.deltaTime);
            //meter sonido desapricion risa
        }
    }
}
