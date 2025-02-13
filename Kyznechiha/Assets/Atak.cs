using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atak : MonoBehaviour
{
    public int valueDown;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<hp>())
        {
            col.GetComponent<hp>().Health -= valueDown;
        }
    }
}
