using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podik : MonoBehaviour
{
    public Transform spawn;
    public Transform bullet;
    public float time;
    public float predel;
    public float BulletForce;
    public bool poo;
    void Update()
    {
        time += 0.1f;
        if (time > predel)
        {
            if (poo == false)
            {
                Transform BulletInstance = (Transform)Instantiate(bullet, spawn.position, spawn.rotation);
                BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * BulletForce);
                bullet.rotation = spawn.rotation;
            }
            else
            {
                Instantiate(bullet, spawn.position, spawn.rotation);
            }
            time = 0f;
        }

    }
}
