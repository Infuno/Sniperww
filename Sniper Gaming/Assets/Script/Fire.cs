using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform BulletPoint;
    public GameObject Prefab;
    public Transform Camera;
    public Material Blur;

    public GameObject StartVoice;
    public GameObject Variable;
    public GameObject Flag;
    public GameObject DiologVoice;

    public GameObject Fail;


    private void Start()
    {
        StartCoroutine(Diolog());
        BulletBehavior.NumberOfShot = 0;
    }
    public void Shoot()
    {
        BulletBehavior.NumberOfShot += 1;
        DiologVoice.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Shoot");
        Instantiate(Prefab, BulletPoint.position, BulletPoint.rotation);
        StartCoroutine(ScreenShake(1f, 0.2f));

        if(BulletBehavior.NumberOfShot == 1)
        {
            Timer.TimeStop = true;
        }
        
    }
    IEnumerator ScreenShake(float duration, float magnitude)
    {
        Vector3 originRos = Camera.localEulerAngles;

        float elapsed = 0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f + elapsed, 1f - elapsed) * magnitude * SliderZoomValue.FOVValue;
            float y = Random.Range(-1f + elapsed, 1f - elapsed) * magnitude * SliderZoomValue.FOVValue;

            Camera.localEulerAngles = new Vector3(originRos.x + x, originRos.y + y, originRos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        Camera.localEulerAngles = originRos;
    }

    IEnumerator Diolog()
    {
        yield return new WaitForSeconds(2f);
        StartVoice.SetActive(true);
        yield return new WaitForSeconds(8f);
        Variable.SetActive(true);
        yield return new WaitForSeconds(10f);
        Flag.SetActive(true);
    }
}
