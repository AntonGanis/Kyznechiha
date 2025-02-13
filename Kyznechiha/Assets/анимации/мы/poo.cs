using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poo : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<Belah>() || col.gameObject.GetComponent<Dogs>())
        {
            if (col.gameObject.GetComponent<Belah>()) { col.gameObject.GetComponent<Belah>().poo = true; }
            if (col.gameObject.GetComponent<Dogs>()) { col.gameObject.GetComponent<Dogs>().poo = true; }
        }

    }
}
