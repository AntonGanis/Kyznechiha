using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int Speed;
    Vector3 lastPos;
    float tim;

    void Start()
    {
        lastPos = transform.position;
    }

    void Update()
    {
        tim += 0.1f;
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        RaycastHit hit;
        Debug.DrawLine(lastPos, transform.position);
        lastPos = transform.position;
        if (tim > 20) { Destroy(gameObject); }
    }
}
