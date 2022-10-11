using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 startRotation;
    public GameObject merkez;
    public int speed;

    public void Start()
    {
        transform.eulerAngles = startRotation;
    }
    void Update()
    {
        transform.RotateAround(merkez.transform.position,Vector3.forward,speed*Time.deltaTime);
    }
}
