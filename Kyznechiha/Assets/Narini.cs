using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narini : MonoBehaviour
{
    public Transform bullet;
    public Transform spawn;
    public float time;
    public float kim;
    public bool es;
    public GameObject[] oni;

    void Update()
    {
        time += 0.1f;
        if (time > kim && es == true)
        {
            oni[0].GetComponent<Animator>().SetTrigger("удар");
            oni[1].GetComponent<Animator>().SetTrigger("удар");
            Transform BulletInstance =  Instantiate(bullet, spawn.position, spawn.rotation);
            BulletInstance.gameObject.GetComponent<run>().STAI = gameObject;
            time = 0f;
            es = false;
        }
        if(es == true)
        {
            oni[1].SetActive(true);
        }
        if (oni[1].GetComponent<gg>().fly == true)
        {
            oni[1].SetActive(false);
        }
    }
}