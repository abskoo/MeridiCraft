using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class followPlayer : MonoBehaviour
{
    private GameObject checkplayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkplayer = GameObject.FindGameObjectWithTag("Player");
        if(checkplayer != null)
        {
            GetComponent<CinemachineVirtualCamera>().Follow = checkplayer.transform;
           
        }
        
    }
}
