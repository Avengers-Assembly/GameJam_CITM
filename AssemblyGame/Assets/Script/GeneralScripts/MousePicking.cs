using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePicking : MonoBehaviour
{
    private Transform selected_object;
    public Color selectable_color;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if (selected_object != null)
        {
            var selection_render = selected_object.GetComponent<SpriteRenderer>();
            if (selection_render != null)
            {
                selection_render.color = Color.white;
                selected_object = null;
            }
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool is_open = animator.GetBool("is_Open");

        if (Physics.Raycast(ray, out hit) && !is_open)
        {
               Transform selection = hit.transform;

            if (selection != null)
            {
                SpriteRenderer selection_r = selection.GetComponent<SpriteRenderer>();
               
                if (selection_r != null)
                {
                    selection_r.color = selectable_color;
                }
                selected_object = selection;
            }

            if (Input.GetMouseButtonDown(0) )
            {
                var dialogue = selection.GetComponent<AbstractAction>();
                
                if(dialogue != null)
                    dialogue.OnAction();   
            }
        }

        
    }
}
