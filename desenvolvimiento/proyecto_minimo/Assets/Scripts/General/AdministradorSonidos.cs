using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorSonidos : MonoBehaviour
{
    public List<AudioClip> sounds;
    public AudioSource aS;
    void Start()
    {
        StartCoroutine(Sounds());
    }

    IEnumerator Sounds()
    {
        yield return new WaitForSeconds(20);
        aS.PlayOneShot(sounds[Random.Range(0,sounds.Count)]);
        StartCoroutine(Sounds());
    }
}
