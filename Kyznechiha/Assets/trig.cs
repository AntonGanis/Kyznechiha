using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trig : MonoBehaviour
{
    public int i;
    public int i2;
    public Transform[] point;
    public Transform[] Startpoint;
    public GameObject[] en;
    public restart o;

    void Start()
    {
        en[0].SetActive(true);
        transform.position = Startpoint[Data.lvl].position;
        transform.rotation = Startpoint[Data.lvl].rotation;
        if (Data.lvl == 1)
        {
            gameObject.GetComponent<slehka>().target = point[1];
            en[0].SetActive(false);
            en[1].SetActive(true);
        }
        if (Data.lvl == 2)
        {
            gameObject.GetComponent<slehka>().target = point[3];
            en[0].SetActive(false);
            en[2].SetActive(true);
        }
        if (Data.lvl == 3)
        {
            gameObject.GetComponent<slehka>().target = point[5];
            en[0].SetActive(false);
            en[3].SetActive(true);
        }
    }
    void Update()
    {
        if (i != i2)
        {
            gameObject.GetComponent<slehka>().target = point[i];
            i2 = i;
        }
        if(i == 2)
        {
            en[0].SetActive(false); 
            en[1].SetActive(true); 
        }
        if (i == 4)
        {
            en[1].SetActive(false);
            en[2].SetActive(true);
        }
        if (i == 5)
        {
            en[2].SetActive(false);
            en[3].SetActive(true);
        }
    }
}
