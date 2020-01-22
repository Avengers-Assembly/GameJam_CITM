using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeAction : AbstractAction
{
    public GameObject phone; 
    public override void DoMyOwnAction()
    {
        GameObject.Find("CustomEventManager").GetComponent<EventSystem>().killed = false;
        GameObject.Find("CustomEventManager").GetComponent<EventSystem>().PopNextEvent();

        GameObject.Find("SceneManager").GetComponent<SceneManager>().ChangeBetweenScenes(true);
        phone.GetComponent<AudioSource>().Play();

    }
}
   