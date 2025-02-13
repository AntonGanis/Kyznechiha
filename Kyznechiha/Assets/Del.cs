using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Del : MonoBehaviour
{
    float tim;
    public float pred;

    void Update()
    {
        tim += 0.1f;

        if (tim > pred) { Destroy(gameObject); }

    }
}
