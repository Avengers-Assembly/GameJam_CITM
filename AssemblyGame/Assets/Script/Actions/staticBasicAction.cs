using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticBasicAction : AbstractAction
{
    public Camera camera;
    public GameObject dialogueManager;
    Vector3 on_position;
    public override void DoMyOwnAction()
    {
        GetComponent<DialogTrigger>().TriggerDialogue();
        dialogueManager.GetComponent<DialogueManager>().SetObjectPicked(gameObject);
        camera.GetComponent<blur>().BlurIn();
  
    }

    public override void EndAction()
    {
        camera.GetComponent<blur>().BlurOut();
       
    }
}