using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatForm : MonoBehaviour
{

    public Transform start, end;
    public float speed;
    private Vector3 nextPos;
    void Start()
    {
        nextPos = start.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == start.position)
        {
            nextPos = end.position;
        }
        if(transform.position == end.position)
        {
            nextPos = start.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
}
