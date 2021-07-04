using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject ObjectB;
    public float speed;
    void Update()
    {
        Rotation();
    }

    void Rotation()
    {
        transform.RotateAround(ObjectB.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
