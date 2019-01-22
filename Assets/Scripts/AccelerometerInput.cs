using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelerometerInput : MonoBehaviour {
    /***** https://docs.unity3d.com/ScriptReference/Input-acceleration.html ****/


    // Move object using accelerometer
    //float speed = 10.0f;
    public Slider slider;

  
	
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


        //transform.Translate(-Input.acceleration.x, 0, 0);

        transform.Rotate( 0, Input.acceleration.x * 1.4f * slider.value, 0);

}

}
