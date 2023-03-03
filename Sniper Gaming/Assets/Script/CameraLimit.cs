using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLimit : MonoBehaviour
{
    public Transform camera;

    private void FixedUpdate()
    {
        if (camera.transform.localEulerAngles.y > 100f)
        {
            camera.transform.localEulerAngles = new Vector3(camera.transform.localEulerAngles.x, 100f, 0);
        }
        if (camera.transform.localEulerAngles.y < 80f)
        {
            camera.transform.localEulerAngles = new Vector3(camera.transform.localEulerAngles.x, 80f, 0);
        }
        if (camera.transform.localEulerAngles.x > 12f && camera.transform.localEulerAngles.x < 100)
        {
            camera.transform.localEulerAngles = new Vector3(12f, camera.transform.localEulerAngles.y,0);
        }
        if (camera.transform.localEulerAngles.x > 100)
        {
            camera.transform.localEulerAngles = new Vector3(0f, camera.transform.localEulerAngles.y, 0);
        }
    }
}
