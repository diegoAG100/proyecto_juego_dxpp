using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Vaso : MonoBehaviour
{
    public Transform nextPosition;
    private Vector3 origin;
    float timer = 2;
    bool firts = true;

    bool move = false;
    public bool elegido = false;

    private void Awake()
    {
        origin = transform.position;
    }
    void OnEnable(){
        if (firts)
        {
            firts = false;
            return;
        }
    }

    public void NewPosition(){
        nextPosition = VasosPoiscion.instance.GivePosition();
        move=true;
        timer = 3;
    }

    void Update(){

        if (move){
            transform.position = new Vector2(Mathf.Lerp(transform.position.x,nextPosition.position.x,0.01f),Mathf.Lerp(transform.position.y,nextPosition.position.y,0.05f));
            if (Vector2.Distance(transform.position, nextPosition.position) < 0.5f && Vector2.Distance(transform.position, nextPosition.position) > -0.5f && timer < 0)
            {
                move = false;
            }
        }

        timer-=Time.deltaTime;
    }

    private void OnDisable()
    {
        if (AdministradorPunto.instance.glass.gameObject.active == false)
        {
            move = false;
            transform.position = origin;
        }
    }

    private void OnMouseDown()
    {
        if (elegido == true)
        {
            GetComponent<Animator>().SetTrigger("Subir");
            AdministradorPunto.instance.AddPointsDards();

        }
        else
        {
            AdministradorPunto.instance.glass.gameObject.active = false;
            AdministradorPunto.instance.glass.gameObject.active = true;
        }
        VasosPoiscion.instance.DisabelGlass();
    }
}
