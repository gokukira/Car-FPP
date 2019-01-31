using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AccSlider : MonoBehaviour
{
    public Rigidbody rb;
    public Slider slider ;
    //public Button d ;
    //public Button n ;
    //public int gear;
    float speed;
    float accelerate = 1f;
    public Transform target;

    // private GameObject cameraContainer;
    //private Quaternion rot;

    void Awake()
    {
       //cameraContainer = new GameObject("Camera Velocity");
        //cameraContainer.transform.position = transform.position;
        //transform.SetParent(cameraContainer.transform);

        rb = GetComponent<Rigidbody>();

        //d.enabled = false;
        //n.enabled = true;

    }

    void FixedUpdate()
    {
        
        //speed = Mathf.Clamp(speed + accelerate, 0.1f ,2.5f);

    }

    public void Slider_Changed()
    {
        if (rb.rotation.y <= 0.2f )
        {
            if (Input.GetMouseButton(0))
                rb.velocity = new Vector3(0, 0, -2f * slider.value);
            Debug.Log("Loop 1");
        }
        /*
        else if (rb.velocity.y >= -0.7f && rb.velocity.y <= 0)
        {
            if (Input.GetMouseButton(0))
                rb.velocity = new Vector3(0, 0, -2.5f * slider.value);
            Debug.Log("Loop 2");
        }
        */
        else
        {
            if (Input.GetMouseButton(0))
                rb.velocity = new Vector3(0, 0, 2.5f * slider.value);
        }

            
        //transform.forward = GameObject.Find("Camera").transform.forward;

        /*
        if (d.enabled)
            n.enabled = false;

        if (n.enabled)
            d.enabled = false;

        if (d.enabled )
        {
            gear = 1;
            //n.enabled = false;
            
        }

        if (n.enabled )
        {
            gear = 1;
            //d.enabled = false;
           
        }

        StartCoroutine(GearChange());
        */

    }
    /*
    IEnumerator GearChange()
    {
        yield return new WaitForSeconds(0.01f);

        if(gear == 0)
        {
            if (Input.GetMouseButton(0))
                rb.velocity = new Vector3(0, 0, -slider.value);
        }

        else if(gear == 1)
        {
            if (Input.GetMouseButton(0))
                rb.velocity = new Vector3(0, 0, slider.value * 5);
        }

        else
            if (Input.GetMouseButton(0))
            rb.velocity = new Vector3(0, 0, 5);
    }

    //rb.AddForce(0, 0, newValue * speed, ForceMode.Acceleration);
    //}
    */

}
