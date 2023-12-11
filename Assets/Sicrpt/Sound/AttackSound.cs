using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSound : MonoBehaviour
{
    public static AttackSound instace;
    public AudioSource SoundSource;
    public AudioClip AtSound;

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
