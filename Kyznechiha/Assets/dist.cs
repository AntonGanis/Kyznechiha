using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dist : MonoBehaviour
{
    public float distance;
    public float limit;
    public Transform plars;
    public GameObject W;

    void Update()
    {
        StartCoroutine(Optimiz());
    }
    IEnumerator Optimiz()
    {
        distance = Vector3.Distance(plars.position, transform.position);
        if (distance > limit) { W.SetActive(false); }
        else { W.SetActive(true); }
        yield return new WaitForSeconds(1f);
    }
}
