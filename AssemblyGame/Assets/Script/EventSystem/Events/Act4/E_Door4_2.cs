using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Door4_2 : EventAbstract
{

    public override void DoAction()
    {
        GameObject.Find("SceneManager").GetComponent<SceneManager>().ChangeBetweenScenes(true); 
    }
}
