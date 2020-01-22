using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FINAL_FINAL_EVENT : EventAbstract
{
    float t = 0f;

    public override void DoAction()
    {
        if(GameObject.Find("CustomEventManager").GetComponent<EventSystem>().killed)
        {    
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        
        else
        {
            actor.GetComponent<DialogTrigger>().TriggerDialogue(8);
            StartCoroutine(CallToFinalScene());
        }
    }

    IEnumerator CallToFinalScene()
    {
        while(t<=3f)
        {
            t += Time.deltaTime;
            yield return null;
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
