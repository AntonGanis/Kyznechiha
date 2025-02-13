using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigI : MonoBehaviour
{
    public trig I;
    public int II;
    public int III;
    public bool rr;
    public bool idiot;

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.GetComponent<trig>())
        {
            I.i = II;
            if(rr == true)
            {
                I.o.etap = III;
            }
        }
    }
    void Update()
    {
        if(idiot == true)
        {
            I.i = II;
            if (rr == true)
            {
                I.o.etap = III;
            }
        }
    }
}
