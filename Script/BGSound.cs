using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSound : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip bgSound;
    void Start()
    {
        audiosource = gameObject.AddComponent<AudioSource>();
        audiosource.clip = bgSound;
        audiosource.mute = false;
        audiosource.loop = true;
        audiosource.playOnAwake = true;
        audiosource.Play();
    }
}
