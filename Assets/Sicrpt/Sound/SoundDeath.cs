using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDeath : MonoBehaviour
{
    public static SoundDeath instace;
    public AudioSource SoundSource;
    public AudioClip DeathSound;

    private void Awake()
    {
        instace = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
