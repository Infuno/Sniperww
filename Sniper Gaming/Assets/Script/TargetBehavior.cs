using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider hitInfo)
    {
        BulletBehavior bulletBehavior = hitInfo.GetComponent<BulletBehavior>();
        if (bulletBehavior != null)
        {
            print("Hit");
            FindObjectOfType<AudioManager>().PlaySound("TargetHit");
            Timer.TimeStop = true;
            Timer.IsHit = true;
        }
    }
}
