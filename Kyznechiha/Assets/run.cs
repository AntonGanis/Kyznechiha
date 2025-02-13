using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    public GameObject STAI;
    float dist0;
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        dist0 = Vector3.Distance(STAI.transform.position, transform.position);
        agent.SetDestination(STAI.transform.position);
        if (dist0 < 0.5f)
        {
            STAI.GetComponent<Narini>().es = true;
            Destroy(gameObject);
        }
    }
}
