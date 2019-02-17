using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraView : MonoBehaviour
{
    public GameObject firstPersonCamera;
    public GameObject overheadCamera;
    public GameObject reverseCamera;
    public Button button;
    public int CamMode;

    public void OnClick()
    {
        if (button.enabled)
        {
            if (CamMode == 0)           //0 is first person
                CamMode = 1;

            else
                CamMode = 0;

            StartCoroutine(CamChange());
        }

        reverseCamera.SetActive(false);
    }

    IEnumerator CamChange()
    {

        yield return new WaitForSeconds(0.01f);

        if (CamMode == 0)
        {
            firstPersonCamera.SetActive(true);
            overheadCamera.SetActive(false);

        }

        if (CamMode == 1)
        {
            overheadCamera.SetActive(true);
            firstPersonCamera.SetActive(false);
        }

    }

}