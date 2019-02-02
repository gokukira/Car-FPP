using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelerometerInput : MonoBehaviour {
    /***** https://docs.unity3d.com/ScriptReference/Input-acceleration.html ****/


    // Move object using accelerometer

    float bspeed;
    float speed;
    GameObject a;
    public Slider slider;
    public Rigidbody rb;

    void Start()
    {

 
    }

	void Update () {

        bspeed = BreakSlider.binstance.t;

        //Debug.Log("Acc" + slider.value);
        /*
        Vector3 dir = Vector3.zero;

        // we assume that device is held parallel to the ground
        // and Home button is in the right hand

        // remap device acceleration axis to game coordinates:
        //  1) XY plane of the device is mapped onto XZ plane
        //  2) rotated 90 degrees around Y axis
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        // clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        // Make it move 10 meters per second instead of 10 meters per frame...
        dir *= Time.deltaTime;

        // Move object
        transform.Translate(dir * speed);
    */


        /********** https://www.youtube.com/watch?v=XZWNXsjIvrE&feature=youtu.be ************/
        
        if (rb.rotation.y <= 0.2f && rb.rotation.y >=0f )
        {
            transform.Rotate(0, Input.acceleration.x * 0.4f * slider.value, 0);
            Debug.Log("Reverse" + rb.rotation.y);
            transform.Translate(-Input.acceleration.x * 0.1f * slider.value, 0, 0.2f * slider.value);

        }

        /*
        else if(rb.rotation.y < 0.9f && rb.rotation.y >= 0.5f)
        {
            transform.Rotate(0, Input.acceleration.x * 0.9f * slider.value, 0);
            transform.Translate(-Input.acceleration.x * 2f * slider.value, 0, -0.01f * slider.value);
        }
        */

        else if(rb.rotation.y < 0)
        {
            transform.Rotate(0, -Input.acceleration.x * 0.4f * slider.value, 0);
            Debug.Log("Negative" + rb.rotation.y);
            transform.Translate(-Input.acceleration.x * 0.1f * slider.value, 0, 0.02f * slider.value);

        }

        else
        {
            transform.Rotate(0, Input.acceleration.x * 0.6f * slider.value, 0);
            //Debug.Log("Up" + rb.rotation.y);
            transform.Translate(-Input.acceleration.x * 0.1f * slider.value, 0, -0.02f * slider.value);

        }



      
        if (slider.value >= 20f)
        {
           
            //Debug.Log(speed);
            StartCoroutine(FullAcc());
        }
        


        if (bspeed >= 0)
        {
            if (Input.GetMouseButton(0))
            {
                transform.Translate(Input.acceleration.x * 0.01f * bspeed, 0, 0.02f * bspeed);
                transform.Rotate(0,Input.acceleration.x - Input.acceleration.x,0);
            }

            /*
            if (rb.rotation.y < 0)
            {
                transform.Rotate(0, 0, 0);
                Debug.Log("BREAKNegative" + rb.rotation.y);
                transform.Translate(-Input.acceleration.x * 0.1f * slider.value, -0, 0.01f * slider.value);

            }
            */
        }

    }

    IEnumerator FullAcc()
    {
        yield return new WaitForSeconds(0.1f);
        speed = Mathf.Clamp(20f + 5f + slider.value, 0, 100);
        //Debug.Log(speed);
        rb.velocity = new Vector3(-Input.acceleration.x * 0.01f * speed, 0, -0.02f * speed);

    }

}
