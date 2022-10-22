using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {

        audioSource.clip = audioClip;
        
    }

    // Update is called once per frame
    public void PlaySound()
    {
        audioSource.Play();
    }
}
