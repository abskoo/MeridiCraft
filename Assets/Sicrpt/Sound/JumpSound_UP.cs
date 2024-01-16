using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound_UP : MonoBehaviour
{
    public static JumpSound_UP instance;
    public AudioSource SoundSorce;
    public AudioClip Jump_UP;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
