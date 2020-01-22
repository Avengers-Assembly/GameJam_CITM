using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeAction : AbstractAction
{
    public override void DoMyOwnAction()
    {
        GameObject.Find("CustomEventManager").GetComponent<EventSystem>().killed = true;

        GameObject.Find("SceneManager").GetComponent<SceneManager>().ChangeBetweenScenes(true);
    }
}
   