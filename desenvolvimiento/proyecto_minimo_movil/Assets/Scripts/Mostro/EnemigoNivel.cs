using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemigoNivel : MonoBehaviour
{
    public GameObject mostro;
    public GameObject mostro2;
    public GameObject mostro3;
    public Sprite luz,sinLuz;
    SpriteRenderer srMostro;
    SpriteRenderer srMostro2;
    SpriteRenderer srMostro3;
    public SpriteRenderer srEscenario;
    float timer = 0;
    bool mostroDesaparece;
    public Mostro mostroScript;
    AudioSource aS;
    void Start(){
        srMostro = mostro.GetComponent<SpriteRenderer>();
        srMostro2 = mostro2.GetComponent<SpriteRenderer>();
        srMostro3 = mostro3.GetComponent<SpriteRenderer>();
        aS = GetComponent<AudioSource>();
    }

    void OnMouseDown(){
        if(timer >0){
            return;
        }

        if(mostro.active==true){
            srMostro.color = Color.white;
            mostroDesaparece = true;
            aS.Play();
        }
        if (mostro2.active == true)
        {
            srMostro2.color = Color.white;
            mostroDesaparece = true;
            aS.Play();
        }
        if (mostro3.active == true)
        {
            srMostro3.color = Color.white;
            mostroDesaparece = true;
            aS.Play();
        }
        timer =6;
        srEscenario.sprite = luz;
        StartCoroutine(Tapar());
    }

    IEnumerator Tapar(){
        yield return new WaitForSeconds(2);
        if(mostro.active==true){
            srMostro.color = Color.black;
            mostro.active=false;
        }
        if (mostro2.active == true)
        {
            srMostro2.color = Color.black;
            mostro2.active = false;
        }
        if (mostro3.active == true)
        {
            srMostro3.color = Color.black;
            mostro3.active = false;
        }
        mostroScript.paso1 = false;
        mostroScript.paso2 = false;
        mostroScript.paso3 = false;
        srEscenario.sprite = sinLuz;
            mostroDesaparece = false;
    }

    void Update(){
        timer-=Time.deltaTime;
        if(mostroDesaparece){
            srMostro.color = new Color(srMostro.color.r,srMostro.color.g,srMostro.color.b,srMostro.color.a-0.8f*Time.deltaTime);
            srMostro2.color = new Color(srMostro2.color.r, srMostro2.color.g, srMostro2.color.b, srMostro2.color.a - 0.8f * Time.deltaTime);
            srMostro3.color = new Color(srMostro3.color.r, srMostro3.color.g, srMostro3.color.b, srMostro3.color.a - 0.8f * Time.deltaTime);
            //meter sonido desapricion risa
        }
    }
}
