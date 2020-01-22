using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Door1 : EventAbstract
{
    public GameObject phone;
    public override void DoAction()
    {
        Debug.Log("Doing Event Action");
        GameObject.Find("SceneManager").GetComponent<SceneManager>().ChangeBetweenScenes(false);
        phone.GetComponent<AudioSource>().Play();
    }
}
