using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderZoomValue : MonoBehaviour
{
    public Slider slider;
    public Camera camera;
    static bool Drag = true;
    public static float FOVValue;
    public void FixedUpdate()
    {
        camera.fieldOfView = slider.value;
    }
    private void Update()
    {
        if (Input.touchCount == 1 && Drag == true)
        {
            Touch screenTouch = Input.GetTouch(0);
            if(screenTouch.phase == TouchPhase.Moved)
            {
                double CamSensitive = 0.0002 * camera.fieldOfView;

                camera.transform.Rotate(-screenTouch.deltaPosition.y * (float)CamSensitive, screenTouch.deltaPosition.x * (float)CamSensitive, 0);
            }
            
        }
        FOVValue = camera.fieldOfView;
    }
    public static void text1()
    {
        Drag = false;
    }
    public static void text2()
    {
        Drag = true;
    }

}
