using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputSystem : MonoBehaviour
{
    public Camera camera;
    private PlayerInput input;
    private void FixedUpdate()
    {
        input = GetComponent<PlayerInput>();
        Vector2 V2input = input.actions["Look"].ReadValue<Vector2>();

        double Sensitive = 0.002 * camera.fieldOfView;
        camera.transform.Rotate(V2input.y * -(float)Sensitive, V2input.x * (float)Sensitive, 0);
    }
}
