using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Door4_2 : EventAbstract
{
    public GameObject phone;
    public GameObject deadBody;
    public override void DoAction()
    {
        GameObject.Find("SceneManager").GetComponent<SceneManager>().ChangeBetweenScenes(true);
        GameObject.Find("CustomEventManager").GetComponent<EventSystem>().killed = true;
        phone.GetComponent<AudioSource>().Play();
        deadBody.SetActive(true);
    }
}
