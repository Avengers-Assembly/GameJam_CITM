using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorAction : AbstractAction
{
    public Camera camera;
    public GameObject current_wall;
    Vector3 on_position;
    public override void OnAction()
    {
        GetComponent<DialogTrigger>().TriggerDialogue();
        camera.GetComponent<blur>().BlurIn();
        on_position = transform.position;
        transform.position = Vector3.zero + current_wall.transform.forward;
    }
}
