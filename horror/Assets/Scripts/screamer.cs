using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screamer : MonoBehaviour
{
    
    [SerializeField] GameObject trigger_off;
    [SerializeField] AudioSource audio;
    [SerializeField] GameObject Screamer;

    void Start()
    {
        Screamer.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        Screamer.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {        
        Screamer.SetActive(false);
        trigger_off.SetActive(false);
    }
}
