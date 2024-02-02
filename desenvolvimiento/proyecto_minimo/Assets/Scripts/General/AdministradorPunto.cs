using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorPunto : MonoBehaviour
{
    static public AdministradorPunto instance;
    public MovementButton mb;
    int pointShootgun = 0;
    int pointBasket = 0;
    int pointDards = 0;
    public int pointGlass = 0;
    public bool shootgunFin =false, basketFin = false, glassFin = false;
    public SpriteRenderer transicion;
    public Canvas shootgun,basket,dards,glass;
    public bool subir=false;
    public bool bajar=false;
    public AudioSource aS;

    void Awake(){
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (subir)
        {
            transicion.color = new Color(transicion.color.r, transicion.color.g, transicion.color.b, transicion.color.a+1*Time.deltaTime);
        }
        if (bajar)
        {
            transicion.color = new Color(transicion.color.r, transicion.color.g, transicion.color.b, transicion.color.a - 1 * Time.deltaTime);
        }
    }

    public void AddPointsShootgun(){
        pointShootgun +=1;
        if(pointShootgun >=10){
            var list = GameObject.FindGameObjectsWithTag("bullet");
            foreach(GameObject go in list){
                Destroy(go);
            }
            StartCoroutine(Transicion(shootgun, basket,0));
            mb.returnZone = basket.gameObject;
            shootgunFin = true;
        }
    }
    public void AddPointsBasket(){
        pointBasket +=1;
        if(pointBasket >=10){
            StartCoroutine(Transicion(basket, glass,1));
            mb.returnZone = glass.gameObject;
            GetComponent<VasosPoiscion>().Iniciar();
            basketFin = true;
        }
    }
    public void AddPointsDards(){
        pointGlass += 1;
        if(pointGlass >= 3){
            Application.Quit();
            //dards.gameObject.active = true;
            glass.gameObject.active = false;
            glassFin = true;
        }
    }
    public void AddPointsGlass(){
        pointDards += 1;
        if(pointDards >= 10){
            glass.gameObject.active=false;
        }
    }

    IEnumerator Transicion(Canvas desactivar, Canvas activar,int a)
    {
        aS.Play();
        subir = true;
        yield return new WaitForSeconds(2);
        bajar = true;
        subir = false;
        desactivar.gameObject.active = false;
        activar.gameObject.active = true;
        yield return new WaitForSeconds(2);
        bajar = false;
        if (a==1)
        {
            GetComponent<VasosPoiscion>().Iniciar();
        }
    }
}
