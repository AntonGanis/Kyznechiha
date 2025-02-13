using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rand : MonoBehaviour
{
    public GameObject[] ob;
    void Start()
    {
        int randomIndex = Random.Range(0, ob.Length);
        Instantiate(ob[randomIndex], transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
