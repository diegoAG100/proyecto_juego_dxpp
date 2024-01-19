using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Escopeta : MonoBehaviour
{
    public bool mouseDown = false;
    private bool dontShoot = true;
    private bool shoot = false;
    private float timer = 0f;
    private SpriteRenderer sr;
    public GameObject blackCiercle; 
    private GameObject circleInstance;
    public GameObject bullet;
    private float scaleCircle = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Timer para saber si paso el tiempo sufciente para volver a disparar
        timer-=Time.deltaTime;

        //Instanciar bala
        if(circleInstance!=null){
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            circleInstance.transform.position = position;
            scaleCircle = Mathf.Lerp(scaleCircle,0.5f,0.001f);
            circleInstance.transform.localScale = new Vector2(scaleCircle,scaleCircle);
            scaleCircle = circleInstance.transform.localScale.y;
        }   

        }
    

    public void OnMouseDown(){
        if(timer<0){
            //Ponemos al circleInstance en la posicion del raton y le asignamos el sprite renderer
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            circleInstance = Instantiate(blackCiercle,position, Quaternion.identity);
            scaleCircle = 8;
            mouseDown = true;
            sr = circleInstance.GetComponent<SpriteRenderer>();
        }
        else{
            dontShoot = false;
        }
    }
    
    public void OnMouseUp(){
        if(timer<0&&dontShoot){
            ShootWeapon();
            //Destroy(circleInstance);
            circleInstance = null;
            mouseDown = false;
            timer = 0f;
            shoot = true;
        }
        dontShoot = true;
    }

    public void ShootWeapon(){
            //float angulo = Random.Range(0f, 360f);
            //float radio = Mathf.Max(sr.bounds.size.x, sr.bounds.size.y) * 0.5f;
            //Vector3 posicion = new Vector3(Mathf.Cos(angulo) * radio, Mathf.Sin(angulo) * radio, 0f);
            //Vector3 bulletPosition =Camera.main.ScreenToWorldPoint(Input.mousePosition);

            float minX = sr.bounds.size.x * -0.5f;
            float minY = sr.bounds.size.y * -0.5f;
            float minZ = 0;

            Instantiate(bullet,this.transform.TransformPoint(new Vector3(Random.Range (minX, -minX),Random.Range (minY, -minY),Random.Range (minZ, -minZ))), Quaternion.identity);
            sr = null;
            shoot = false;
    }
    //https://hamy.xyz/labs/unity-how-to-find-a-random-point-within-a-collider-mesh
}
