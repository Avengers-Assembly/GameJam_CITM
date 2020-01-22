using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Door3_1 : EventAbstract
{
    public GameObject phone;
    public override void DoAction()
    {
        GameObject.Find("SceneManager").GetComponent<SceneManager>().ChangeBetweenScenes(true);
        phone.GetComponent<AudioSource>().Play();
    }
}