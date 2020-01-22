using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAction : AbstractAction
{
    public SceneManager sceneManager;
    public bool changesScene = false;
    public override void DoMyOwnAction()
    {
        Debug.Log("Doing My Own Action");
        sceneManager.ChangeBetweenScenes(changesScene);
    }
}
