using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VasosPoiscion : MonoBehaviour
{
    static public VasosPoiscion instance;
    public List<Transform> positions;
    public List<Transform> adjudiquePositions;

    void Awake(){
        Debug.Log("1");
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(adjudiquePositions.Count >3){
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
}
