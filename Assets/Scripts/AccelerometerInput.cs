using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelerometerInput : MonoBehaviour {
    /***** https://docs.unity3d.com/ScriptReference/Input-acceleration.html ****/


    // Move object using accelerometer

    public Slider slider;
    public Rigidbody rb;  
	
	// Update is called once per frame
	void Update () {
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
        
        if (rb.rotation.y <= 0.2f )
        {
            transform.Rotate(0, Input.acceleration.x * 0.4f * slider.value, 0);
            Debug.Log("Reverse" + rb.rotation.y);
            transform.Translate(-Input.acceleration.x * 0.1f * slider.value, 0, 0.02f * slider.value);

        }


        else
        {
            transform.Rotate(0, Input.acceleration.x * 0.9f * slider.value, 0);
            Debug.Log("Up" + rb.rotation.y);
            transform.Translate(-Input.acceleration.x * 0.1f * slider.value, 0, -0.02f * slider.value);

        }

    }

}
