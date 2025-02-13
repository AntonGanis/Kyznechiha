using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katscens : MonoBehaviour
{
    public bool r;
    public int lol;
    public bool nol;
    public GameObject en;
    void Start()
    {
        if (nol && Data.begin || lol <= Data.lvl && nol == false)
        {
            en.SetActive(true);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (r)
        {
            en.SetActive(true);
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<restart>())
        {
            en.SetActive(false);
            gameObject.GetComponent<Animator>().SetTrigger("го");
        }
    }
}
