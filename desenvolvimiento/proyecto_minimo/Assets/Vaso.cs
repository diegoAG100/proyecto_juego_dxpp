using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Vaso : MonoBehaviour
{
    public Transform nextPosition;
    float timer = 2;

    bool move = false;
    void OnEnable(){
        Invoke("NewPosition",0.1f);
    }

    public void NewPosition(){
        nextPosition = VasosPoiscion.instance.GivePosition();
        move=true;
        timer = 3;
    }

    void Update(){
        if(move){
            transform.position = new Vector2(Mathf.Lerp(transform.position.x,nextPosition.position.x,0.01f),Mathf.Lerp(transform.position.y,nextPosition.position.y,0.05f));
        }
        if(Vector2.Distance(transform.position,nextPosition.position)<0.5f&&Vector2.Distance(transform.position,nextPosition.position)>-0.5f&&timer<0){
            move =false;
        }
        timer-=Time.deltaTime;
    }
}
