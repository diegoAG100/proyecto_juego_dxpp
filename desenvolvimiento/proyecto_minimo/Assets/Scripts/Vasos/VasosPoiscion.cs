using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class VasosPoiscion : MonoBehaviour
{
    static public VasosPoiscion instance;
    public List<Transform> positions;
    public List<Transform> adjudiquePositions;
    public List<Vaso> vasos;
    public float veces = 0;
    bool Nivel1 = true;
    bool Nivel2 = false;
    bool Nivel3 = false;

    void Awake(){
        Debug.Log("1");
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    public void Iniciar()
    {
        veces = 0;
    }
    public void CorrutinaInicio()
    {
        foreach (Vaso v in vasos)
        {
            v.GetComponent<Collider2D>().enabled = false;
        }
        Debug.Log("voi a inciiar");
        // hay que cambiar esto por boleanos dependiendo de el nivel para que se puede volver al menu para que tal
        if (AdministradorPunto.instance.pointGlass == 1)
        {
            veces = 0;
            StartCoroutine(tal(10,1.4f));
            return;
        }
        if (AdministradorPunto.instance.pointGlass == 2)
        {
            veces = 0;
            StartCoroutine(tal(20,0.8f));
            return;
        }
        veces = 0;
        StartCoroutine(tal(3,2));
    }

    // Update is called once per frame
    void Update()
    {
        if(adjudiquePositions.Count >=3){
            positions.Clear();
            foreach(Transform t in adjudiquePositions){
                positions.Add(t);
            }
            adjudiquePositions.Clear();
        }

        
    }

    public Transform GivePosition(){
        Debug.Log(positions.Count);
        Transform poitionSend= positions[Random.Range(0,positions.Count)];
        adjudiquePositions.Add(poitionSend);
        positions.Remove(poitionSend);
        return poitionSend;
    }

    public IEnumerator tal(int vecesRecpetir,float velocida)
    {
        Debug.Log("pase");
        yield return new WaitForSeconds(velocida);
        if (AdministradorPunto.instance.glass.gameObject.active == false)
        {
            yield return null;
            Debug.Log("cancele");

        }
        else
        {
            if (veces < vecesRecpetir)
            {
                foreach (Vaso v in vasos)
                {
                    v.NewPosition();
                }
                StartCoroutine(tal(vecesRecpetir, velocida));
            }
            else
            {
                Debug.Log(veces);
                foreach (Vaso v in vasos)
                {
                    v.GetComponent<Collider2D>().enabled = true;
                }
            }
            veces++;
        }

    }
}
