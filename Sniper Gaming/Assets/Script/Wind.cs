using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public static float WindPower;
    public Cloth Flag;

    private void Start()
    {
        StartCoroutine(WindChange());
    }
    public float RandomTimer()
    {
        float Timer = Random.Range(5f, 10f);
        return Timer;
    }
    IEnumerator WindChange()
    {
        WindPower = Random.Range(1f, 15f);
        Flag.externalAcceleration = new Vector3(0,0, -WindPower);
        yield return new WaitForSeconds(RandomTimer());
        StartCoroutine(WindChange());
    }
}
