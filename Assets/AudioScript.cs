using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip music;
    
    void Start()
    {
        musicSource.clip = music;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
