using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public bool IsHit = false;
    public static int NumberOfShot = 0;

    public SphereCollider SphereCollider1;
    public SphereCollider SphereCollider2;

    void Start()
    {
        rb.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider hitInfo)
    {
        rb.velocity = new Vector3(0, 0, 0);
        TargetBehavior target = hitInfo.GetComponent<TargetBehavior>();
        if (target != null)
        {
            print("Hit");
            FindObjectOfType<AudioManager>().PlaySound("TargetHit");
            Timer.TimeStop = true;
            Timer.IsHit = true;
        }
        else
        {
            print("Miss");
            if(NumberOfShot == 1)
            {
                FindObjectOfType<AudioManager>().PlaySound("TargetNotHit");
                Timer.CurrentTime = 5f;
            }
            Timer.TimeStop = false;
        }
        SphereCollider1.enabled = false;
        SphereCollider2.enabled = false;
    }
    private void Update()
    {
        rb.velocity += transform.right * Wind.WindPower * Time.deltaTime;
    }
}
