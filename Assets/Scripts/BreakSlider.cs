using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakSlider : MonoBehaviour {
    public Rigidbody rb;
    float aspeed;
    public float t;
    public float temp;
    public static BreakSlider binstance; 

    void Awake () {
        rb = GetComponent<Rigidbody>();
        binstance = this;
    }


    public void Slider_Changed(float NewValue)
    {
        aspeed = AccSlider.instance.speed;

        if (NewValue<=aspeed)
            t = NewValue;

        temp = Mathf.Clamp(aspeed - NewValue, 0, 22);
        Debug.Log("Break" + temp);
      

        if (rb.rotation.y <= 0.3f )
        {
            if (Input.GetMouseButton(0))
                rb.velocity = new Vector3(0, 0, -temp);
       
        }
        /*
        else if (rb.rotation.y <= 0.7f)
        {
            if (Input.GetMouseButton(0))
                rb.velocity = new Vector3(0, 0, -speed);
        }
        */

        else
        {
            if (Input.GetMouseButton(0))
                rb.velocity = new Vector3(0, 0, -temp);
        }

        

        /*
        speed = 2.5f;
        rb.AddForce(0, 0, NewValue*-speed, mode: ForceMode.Acceleration);
        */


    }

}
