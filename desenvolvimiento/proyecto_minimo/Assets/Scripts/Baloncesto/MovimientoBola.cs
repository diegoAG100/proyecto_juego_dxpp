using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Balon;

public class MovimientoBola : MonoBehaviour
{
    Vector2 spawnPoint;
    public bool horizontal = true;
    public bool vertical = true;
    public Balon balon;

    public float timeHorizontalMovement = 2f;
    private float timePast = 0f;

    private bool switchMovement = false;
    public bool stop = false;

    void Start()
    {
        spawnPoint = transform.position;
        switchMovement = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop)
        {
            return;
        }

        timePast += Time.deltaTime;
        if (switchMovement == false)
        {
            if (horizontal)
            {
                transform.Translate(Vector2.right * 8 * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.left * 8 * Time.deltaTime);
            }

            if (timePast >= timeHorizontalMovement)
            {
                horizontal = false;
            }
            if (timePast >= timeHorizontalMovement + 2)
            {
                timeHorizontalMovement += 4;
                horizontal = true;
            }
        }
        else
        {
            if (vertical)
            {
                transform.Translate(Vector2.up * 8 * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.down * 8 * Time.deltaTime);
            }

            if (transform.localPosition.y >150)
            {
                vertical = false;
            }
            if (transform.localPosition.y < -155)
            {
                timeHorizontalMovement += 2;
                vertical = true;
            }
        }

    }

    public void SwitchMovement()
    {
        if (switchMovement == true)
        {
            stop = true;
            StartCoroutine(Restart());
        }
        else
        {
            timeHorizontalMovement = 1;
            timePast = 0;
            switchMovement = true;
        }
    }

    private IEnumerator Restart()
    {
        balon.a();
        yield return new WaitForSeconds(5);
        switchMovement = false;
        stop = false;
        transform.position = spawnPoint;
        timeHorizontalMovement = 2;
        horizontal = true;
        vertical = false;
        timePast = 0;
        StopAllCoroutines();
    }
    public void RestartFuera(){
        switchMovement = false;
        stop = false;
        transform.position = spawnPoint;
        timeHorizontalMovement = 2;
        horizontal = true;
        vertical = false;
        timePast = 0;
        StopAllCoroutines();
    }
}
