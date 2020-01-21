using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blur : MonoBehaviour
{
    // Start is called before the first frame update
    CameraMovement cam_m;
    private float angle;

    public GameObject darkish;
   public GameObject blurr;
    void Start()
    {
        cam_m = GetComponent<CameraMovement>();
    }

    public void BlurIn()
    {
        blurr.SetActive(true);
        darkish.SetActive(true);
    }
    public void BlurOut()
    {
        blurr.SetActive(false);
        darkish.SetActive(false);
    }


}
