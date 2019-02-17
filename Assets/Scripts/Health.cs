using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider health;
    float decrement;
    public Toggle r;

    void Start()
    {
        decrement = 1 / 90f;
    }

    void Update()
    {

        if (r.isOn)
        {
            health.value = Mathf.MoveTowards(health.value, -150.0f, 2*decrement);

        }

        else
        {
            health.value = Mathf.MoveTowards(health.value, -150.0f, decrement);
        }
    }
}
