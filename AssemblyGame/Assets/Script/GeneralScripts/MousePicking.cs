using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePicking : MonoBehaviour
{
    [SerializeField] Material light_material;

    private Transform selected_object;
    // Update is called once per frame
    void Update()
    {
        //if(selected_object != null)
        //{
        //    var selection_render = selected_object.GetComponent<Renderer>();
        //    selection_render.material = null;
        //    selected_object = null;
        //}

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        var selection = hit.transform;
        var selection_r = GetComponent<Renderer>();
        if(selection_r != null)
        {
            selection_r.material = light_material;
        }
    }
}
