using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Door4_1 : EventAbstract
{

    public override void DoAction()
    {
        // Change Scene
        GameObject.Find("SceneManager").GetComponent<SceneManager>().ChangeBetweenScenes(true);

        // Show the rope
        //GameObject.Find("Rope").SetActive(true);


        // Not let go back to other scene
        actor.GetComponent<DoorAction>().changesScene = false;
    }
}
