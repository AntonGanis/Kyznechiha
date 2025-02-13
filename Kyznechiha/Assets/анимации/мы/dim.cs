using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dim : MonoBehaviour
{
    private float time;
    Vector3 temp;
    int e;
    public int ee;
    public float ss = 0.1f;

    void Update()
    {
        temp = transform.localScale;
        time += 0.1f;
        if (time > 0.2f)
        {
            temp.x += ss;
            temp.y += ss;
            temp.z += ss;
            transform.localScale = temp;
            time = 0f;
            e++;
        }
        if (e > ee)
        {
            Destroy(gameObject);
        }
    }
}
