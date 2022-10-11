using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sarkit : MonoBehaviour
{

    public float upspeed;
    public float downspeed;
    public Transform up;
    public Transform down;
    bool chop;


    void Start()
    {
        // boş
    }


    void Update()
    {
        if (transform.position.y>=up.position.y)
        {
            chop = true;
        }
        if (transform.position.y<=down.position.y)
        {
            chop = false;
        }
        if (chop)
        {
            transform.position = Vector2.MoveTowards(transform.position,down.position,downspeed*Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position,up.position,upspeed*Time.deltaTime);
        }
    }
}
