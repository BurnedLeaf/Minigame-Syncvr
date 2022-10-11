using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip WaterShot;
    private AudioSource src;
    void Start()
    {
        src = GetComponent<AudioSource>();
       
    }

    void Update()
    {
        
    }

    public void PlaySound()
    {
        src.PlayOneShot(WaterShot);
    }
}


