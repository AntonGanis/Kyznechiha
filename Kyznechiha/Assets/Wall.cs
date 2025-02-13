using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public bool ooop;
    public Transform bullet;

    void Update()
    {
        if (ooop)
        {
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "враг")
        {
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }

}
