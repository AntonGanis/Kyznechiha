using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public Slider slider;
    public int Health;
    public Transform row;

    void Update()
    {
        slider.value = Health;
        if (Health <= 0)
        {
            Instantiate(row, gameObject.transform.position, gameObject.transform.rotation);
            gameObject.SetActive(false);
        }
    }
}
