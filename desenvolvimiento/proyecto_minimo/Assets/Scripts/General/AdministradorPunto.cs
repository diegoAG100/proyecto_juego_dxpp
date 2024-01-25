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
    int pointGlass = 0;

    public Canvas shootgun,basket,dards,glass;

    void Awake(){
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPointsShootgun(){
        pointShootgun +=1;
        if(pointShootgun >=10){
            var list = GameObject.FindGameObjectsWithTag("bullet");
            foreach(GameObject go in list){
                Destroy(go);
            }
            shootgun.gameObject.active=false;
            basket.gameObject.active=true;
            mb.returnZone = basket.gameObject;
        }
    }
    public void AddPointsBasket(){
        pointBasket +=1;
        if(pointBasket >=10){
            basket.gameObject.active=false;
            dards.gameObject.active = true;
            mb.returnZone = dards.gameObject;
        }
    }
    public void AddPointsDards(){
        pointDards +=1;
        if(pointDards >=10){
            dards.gameObject.active=false;
            glass.gameObject.active=true;
        }
    }
    public void AddPointsGlass(){
        pointGlass +=1;
        if(pointGlass >=3){
            glass.gameObject.active=false;
        }
    }
}
