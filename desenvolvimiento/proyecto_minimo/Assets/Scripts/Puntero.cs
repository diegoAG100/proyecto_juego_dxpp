using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntero : MonoBehaviour
{
    public Texture2D punteroEscopeta;
    public Vector2 tamañoPunteroEscopeta;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(punteroEscopeta,tamañoPunteroEscopeta,CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.SetCursor(punteroEscopeta,tamañoPunteroEscopeta,CursorMode.Auto);
    }
}
