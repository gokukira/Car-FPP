using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccSliderReset : MonoBehaviour {
    public Slider aslider;

    void LateUpdate()
    {
        if (!Input.GetMouseButton(0))
            aslider.value = Mathf.MoveTowards(aslider.value, -50.0f, 0.035f * aslider.value);
    }
}
