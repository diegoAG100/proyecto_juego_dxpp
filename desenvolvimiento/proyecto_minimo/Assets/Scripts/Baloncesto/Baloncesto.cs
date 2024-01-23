using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloncesto : MonoBehaviour
{
    public MovimientoBola bola;

    private void OnMouseDown()
    {
        bola.SwitchMovement();
    }

}
