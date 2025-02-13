using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belah : MonoBehaviour
{
    public Transform[] target;
    public Transform bullet;
    public Transform spawn;
    public Low lw;
    public float time;
    public float pred;
    int i;
    public bool poo;
    void Start()
    {
        i = Random.Range(0, 3);
        poo = false;
    }
    void Update()
    {
        if (poo == false)
        {
            time += 0.1f;
            if (target[i].gameObject.GetComponent<hp>().Health == 0)
            {
                i = Random.Range(0, 3);
            }
            if (time > pred)
            {
                Instantiate(bullet, spawn.position, spawn.rotation);
                time = 0f;
                i = Random.Range(0, 3);
                lw.target = target[i];
            }
        }
        else
        {
            poo = false;
            gameObject.GetComponent<Animator>().SetTrigger("пук");
        }
    }
}
