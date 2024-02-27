using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Baloncesto : MonoBehaviour
{
    public MovimientoBola bola;
    int veces = 0;
    Collider2D collider;

    private void Start()
    {
        collider = GetComponent<Collider2D>();
    }
    private void OnMouseDown()
    {
        bola.SwitchMovement();
        veces += 1;
        if (veces >=2)
        {
            StartCoroutine(StopCollider());
        }
    }

    IEnumerator StopCollider()
    {
        collider.enabled = false;
        veces = 0;
        yield return new WaitForSeconds(5);
        collider.enabled = true;
    }

}
