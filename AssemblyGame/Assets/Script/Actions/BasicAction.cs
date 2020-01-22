using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAction : AbstractAction
{
    public Camera camera;
    public GameObject dialogueManager;
    Vector3 on_position;
    public override void OnAction()
    {
        GetComponent<DialogTrigger>().TriggerDialogue();
        dialogueManager.GetComponent<DialogueManager>().SetObjectPicked(gameObject);
        camera.GetComponent<blur>().BlurIn();
        on_position = transform.position;
        StartCoroutine(SpriteCenter(camera));
    }

    public override void EndAction()
    {
        camera.GetComponent<blur>().BlurOut();
        StopAllCoroutines();
        StartCoroutine(ReturnOriginalPos(on_position));
    }
}