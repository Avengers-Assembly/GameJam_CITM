using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractAction : MonoBehaviour
{
    float currentTranslationTime = 0f;
    public virtual void OnAction()
    {
    }
    public virtual IEnumerator SpriteCenter(Camera cam)
    {
        Vector3 final_pos = cam.transform.position + cam.transform.forward * 5 + cam.transform.up;
        while (final_pos.magnitude > 1.2 || final_pos.magnitude < -1.2)
        {
            //Debug.Log("Hello I should be fucking interpolating but im not");
            currentTranslationTime += Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, final_pos, currentTranslationTime);
            yield return new WaitForEndOfFrame();
        }
        currentTranslationTime = 0f;
    }

    public virtual IEnumerator ReturnOriginalPos(Vector3 pos)
    {
        currentTranslationTime = 0f;

        while (pos.magnitude > 1.2 || pos.magnitude < -1.2)
        {
            //Debug.Log("Hello I should be fucking interpolating but im not");
            currentTranslationTime += Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, pos, currentTranslationTime);
            yield return new WaitForEndOfFrame();
        }
    }
    public virtual void EndAction()
    {
    }
}
