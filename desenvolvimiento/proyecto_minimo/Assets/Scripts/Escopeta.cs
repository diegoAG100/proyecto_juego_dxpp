using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Escopeta : MonoBehaviour
{
    public bool mouseDown = false;
    private bool dontShoot = true;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
    }

    public void OnMouseDown(){
        if(timer<0){
            mouseDown = true;
        }
        else{
            dontShoot = false;
        }
    }
    
    public void OnMouseUp(){
        if(timer<0&&dontShoot){
            mouseDown = false;
            timer = 2f;
        }
        dontShoot = true;
    }
}
