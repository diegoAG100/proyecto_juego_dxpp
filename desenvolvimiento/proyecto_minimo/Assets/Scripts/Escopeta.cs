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
    public GameObject blackCiercle; 
    private GameObject circleInstance;
    public GameObject bullet;
    private float scaleCircle = 8;
    private float timerShoot = 8;
    private float frames=0;

    public Sprite blackColor;
    public Sprite redColor;

    public AudioSource shootSound;
    public AudioSource relodingSound;
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
            timerShoot -= Time.deltaTime;
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            circleInstance.transform.position = position;
            scaleCircle = Mathf.Lerp(scaleCircle,0.5f,0.001f);
            circleInstance.transform.localScale = new Vector2(scaleCircle,scaleCircle);
            scaleCircle = circleInstance.transform.localScale.y;
            frames += Time.deltaTime;
        }

        if (timerShoot<2&& circleInstance != null&& frames > 0.25f)
        {
            if (circleInstance.GetComponent<SpriteRenderer>().sprite == blackColor)
            {
                circleInstance.GetComponent<SpriteRenderer>().sprite = redColor;
            }
            else
            {
                circleInstance.GetComponent<SpriteRenderer>().sprite = blackColor;
            }
            frames = 0;
        }

        if (timerShoot < 0&& circleInstance != null)
        {
            RandomShootWeapon();
            dontShoot = false;
            Destroy(circleInstance);
            circleInstance = null;
            mouseDown = false;
            timer = 2f;
            shoot = true;
            timerShoot = 8;
        }

    }
    

    public void OnMouseDown(){
        if(timer<0){
            //Ponemos al circleInstance en la posicion del raton y le asignamos el sprite renderer
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            circleInstance = Instantiate(blackCiercle,position, Quaternion.identity);
            scaleCircle = 8;
            mouseDown = true;
            timerShoot = 8;
        }
        else{
            dontShoot = false;
        }
    }
    
    public void OnMouseUp(){
        if(timer<0&&dontShoot){
            ShootWeapon();
            Destroy(circleInstance);
            circleInstance = null;
            mouseDown = false;
            timer = 2f;
            shoot = true;
        }
        dontShoot = true;
    }

    public void ShootWeapon(){
        // Asegúrate de que el círculo tiene un Collider2D adjunto
        CircleCollider2D circleCollider = circleInstance.GetComponent<CircleCollider2D>();
        shootSound.Play();
        if (circleCollider != null)
        {
            float radio = circleCollider.radius;
            float minZ = 0;

            float randomAngle = Random.Range(0f, 2f * Mathf.PI);

            float randomRadius = Mathf.Sqrt(Random.Range(0f, 1f)) * radio;

            float randomX = randomRadius * Mathf.Cos(randomAngle);
            float randomY = randomRadius * Mathf.Sin(randomAngle);

            Vector3 globalPosition = circleInstance.transform.TransformPoint(new Vector3(randomX, randomY, minZ));

            GameObject instanceBullet = Instantiate(bullet, globalPosition, Quaternion.identity);
        }
        Invoke("Reloding", 0.5f);
        shoot = false;
    }

    public void RandomShootWeapon()
    {
        // Asegúrate de que el círculo tiene un Collider2D adjunto
        CircleCollider2D circleCollider = circleInstance.GetComponent<CircleCollider2D>();
        shootSound.Play();
        if (circleCollider != null)
        {
            float radio = circleCollider.radius;
            float minZ = 0;

            float randomAngle = Random.Range(0f, 2f * Mathf.PI);

            float randomRadius = Mathf.Sqrt(Random.Range(0f, 1000f)) * radio;

            float randomX = randomRadius * Mathf.Cos(randomAngle);
            float randomY = randomRadius * Mathf.Sin(randomAngle);

            Vector3 globalPosition = circleInstance.transform.TransformPoint(new Vector3(randomX, randomY, minZ));

            GameObject instanceBullet = Instantiate(bullet, globalPosition, Quaternion.identity);
        }
        Invoke("Reloding", 0.5f);
        shoot = false;
    }

    private void Reloding()
    {
        relodingSound.Play();
    }
}
