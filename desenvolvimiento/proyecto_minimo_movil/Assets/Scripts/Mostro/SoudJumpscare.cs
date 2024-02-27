using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoudJumpscare : MonoBehaviour
{
    public AudioSource aS;

    // Start is called before the first frame update

    public void ActivateSoudn()
    {
        aS.Play();
    }

    public void Cerrar()
    {
        Application.Quit();
    }
}
