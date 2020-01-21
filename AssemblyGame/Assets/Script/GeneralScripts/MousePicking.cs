using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MousePicking : MonoBehaviour
{
    private Transform selected_object;
    // Update is called once per frame
    void Update()
    {
        if (selected_object != null)
        {
            var selection_render = selected_object.GetComponent<Image>();
            selection_render.material.color = Color.white;
            selected_object = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            Debug.Log(selection);

            if (selection != null)
            {
                var selection_r = selection.GetComponent<Image>();
                if (selection_r != null)
                {
                    selection_r.material.color = Color.yellow;
                }
                selected_object = selection;
            }
        }
    }
}
