using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Final_1 : EventAbstract
{
    public GameObject phone;
    public override void DoAction()
    {
        // Change Scene

        GameObject.Find("SceneManager").GetComponent<SceneManager>().ChangeBetweenScenes(true);
        phone.GetComponent<AudioSource>().Play();

        if (GameObject.Find("CustomEventManager").GetComponent<EventSystem>().killed)
        {
            GameObject.Find("DeadBody").SetActive(true);
        }

        else
        {
            // Do nothing
        }


    }
}
