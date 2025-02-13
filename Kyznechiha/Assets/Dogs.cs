using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogs : MonoBehaviour
{
    public Transform plars;
    public float speed;
    public float time;
    public float limit;
    public bool nul;
    public bool narin;
    public bool poo;
    void Start()
    {
        poo = false;
    }
    void Update()
    {
        if (poo == false)
        {
            if (narin == false)
            {
                time += 0.1f;
                if (time < limit)
                {
                    Vector3 currentPosition = transform.localPosition;
                    currentPosition.x = Mathf.MoveTowards(currentPosition.x, plars.localPosition.x, speed * Time.deltaTime);
                    transform.localPosition = currentPosition;
                }
                else
                {
                    gameObject.GetComponent<Animator>().SetTrigger("атака");
                }
                if (nul)
                {
                    time = 0;
                    nul = false;
                }
            }
            else
            {
                Vector3 currentPosition = transform.localPosition;
                currentPosition.x = Mathf.MoveTowards(currentPosition.x, plars.localPosition.x, speed * Time.deltaTime);
                transform.localPosition = currentPosition;
            }
        }
        else
        {
            poo = false;
            gameObject.GetComponent<Animator>().SetTrigger("пук");
        }
    }
}
