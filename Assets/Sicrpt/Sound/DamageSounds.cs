using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSounds : MonoBehaviour
{
    public static DamageSounds instace;
    public AudioSource SoundSource;
    public AudioClip DamageSound;

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
