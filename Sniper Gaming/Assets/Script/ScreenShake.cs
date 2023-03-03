using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    IEnumerator Shake (float duration, float magnitude)
    {
        Vector3 originPos = transform.localPosition;

        float elapsed = 0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f,1f)* magnitude;
            float y = Random.Range(-1f,1f)* magnitude;

            transform.localPosition = new Vector3(x, y, originPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originPos;
    }
}
