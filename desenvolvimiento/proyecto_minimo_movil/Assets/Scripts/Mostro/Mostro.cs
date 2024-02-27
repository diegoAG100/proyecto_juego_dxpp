using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mostro : MonoBehaviour
{
    public AudioClip sonido1, sonido2, sonido3,sonido4;
    public GameObject mostro1;
    public GameObject mostro2;
    public GameObject mostro3;
    public GameObject mostro4;
    AudioSource aS;
    public bool paso1 = false, paso2 = false, paso3=false;
    public bool jumpscare = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn(20));
        aS = GetComponent<AudioSource>();
    }

    public IEnumerator Spawn(int time)
    {
        yield return new WaitForSeconds(time);
        if (true)
        {

            if (paso1 == false)
            {
                aS.PlayOneShot(sonido1);
                mostro1.active = true;
                paso1 = true;
            }
            else if (paso2 == false)
            {
                aS.PlayOneShot(sonido2);
                mostro1.active = false;
                mostro2.active = true;
                paso2 = true;
            }
            else if (paso3 == false)
            {
                aS.PlayOneShot(sonido3);
                mostro2.active = false;
                mostro3.active = true;
                paso3 = true;
            }
            else if (paso3 == true)
            {
                mostro4.active = true; ;
            }
            
        }

        if (AdministradorPunto.instance.shootgunFin==false)
        {
            StartCoroutine(Spawn(20));
        }
         else if (AdministradorPunto.instance.basketFin == false)
        {
            StartCoroutine(Spawn(15));
        }
        else if (AdministradorPunto.instance.glassFin == false)
        {
            StartCoroutine(Spawn(13));
        }
        else
        {
            StartCoroutine(Spawn(13));
        }
    }

}
