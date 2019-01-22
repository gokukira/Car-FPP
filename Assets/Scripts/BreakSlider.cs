using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakSlider : MonoBehaviour {
    public Rigidbody rb;
    float speed;
    public Slider slider;

    void Start () {
        rb = GetComponent<Rigidbody>();

    }


    public void Slider_Changed(float NewValue)
    {
        speed = Mathf.Clamp(1.4f*slider.value - NewValue, 0, 20);

        if(Input.GetMouseButton(0))
            rb.velocity = new Vector3(0, 0, speed);



        /*
        speed = 2.5f;
        rb.AddForce(0, 0, NewValue*-speed, mode: ForceMode.Acceleration);
        */


    }

}
