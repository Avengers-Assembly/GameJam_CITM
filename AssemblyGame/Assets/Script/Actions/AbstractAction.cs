using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractAction : MonoBehaviour
{
    float currentTranslationTime = 0f;
    protected EventSystem eventSystem;
    
    void Start()
    {
        eventSystem = GameObject.Find("CustomEventManager").GetComponent<EventSystem>();
    }

    public virtual void DoMyOwnAction()
    {
    }

    public void OnAction()
    {
        if (eventSystem.CheckNextEvent(this.gameObject))
            eventSystem.ExecuteNextEvent();

        else DoMyOwnAction();
    }

    public IEnumerator SpriteCenter(Camera cam)
    {
        Vector3 final_pos = cam.transform.position + cam.transform.forward * 5 + cam.transform.up;
        while (final_pos.magnitude > 1.2 || final_pos.magnitude < -1.2)
        {
            currentTranslationTime = 0f;
            //Debug.Log("Hello I should be fucking interpolating but im not");
            currentTranslationTime += Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, final_pos, currentTranslationTime);
            yield return new WaitForEndOfFrame();
        }
        currentTranslationTime = 0f;
    }

    public IEnumerator ReturnOriginalPos(Vector3 pos)
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

    public bool CheckEvent()
    {
        return eventSystem.CheckNextEvent(this.gameObject);
    }
}
