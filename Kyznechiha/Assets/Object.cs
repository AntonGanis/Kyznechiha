using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public bool coins;
    public bool HQD;
    public bool boxer;
    public bool goroh;
    public bool dron;
    restart plars;
    Transform point;
    public float speed;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<restart>())
        {
            restart rt = col.gameObject.GetComponent<restart>();
            if (coins)
            {
                Data.moni += 1;
            }
            if (HQD)
            {
                rt.ed = true;
                Data.i2 += 3;
            }
            if (boxer)
            {
                col.GetComponent<restart>().boxer = true;
                col.GetComponent<restart>().bx[0].SetActive(true);
                col.GetComponent<restart>().bx[1].SetActive(true);
                Data.i3 += 1;
            }
            if (goroh)
            {
                col.GetComponent<restart>().goroh = true;
                Data.i4 += 1;
            }
            if (dron)
            {
                col.GetComponent<restart>().dron = true;
                Data.i5 += 1;
            }
            Destroy(gameObject);
        }
    }
    void Start()
    {
        plars = FindObjectOfType<restart>();
        if (plars != null)
        {
            point = plars.point;
        }
    }
    void Update()
    {
        if (plars != null && coins == true)
        {
            if (plars.dron == true )
            {
                float dist = Vector3.Distance(point.transform.position, transform.position);
                if (dist < 10)
                {
                    transform.position = Vector3.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
                }
            }
        }
    }
}
