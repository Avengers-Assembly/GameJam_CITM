using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum CurrentScene
{
    PRESENT,
    FUTURE
}

public class SceneManager : MonoBehaviour
{
    public Animator transition;
    public Camera mainCamera;
    CurrentScene currScene = CurrentScene.PRESENT;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("Hey translate");
            ChangeBetweenScenes();
        }
    }

    public void ChangeBetweenScenes()
    {
        StartCoroutine(ChangePosition());
    }

    IEnumerator ChangePosition()
    {
        transition.SetTrigger("Start_Fade");
        StartZoomingIn();

        yield return new WaitForSeconds(1f);

        SelectSceneToChange();
    }

    private void StartZoomingIn()
    {
        StartCoroutine(mainCamera.GetComponent<CameraMovement>().StartZoomingIn());
    }
    private void SelectSceneToChange()
    {
        switch (currScene)
        {
            case CurrentScene.PRESENT:
                mainCamera.transform.position = new Vector3(0f, 0f, 50f);
                mainCamera.transform.rotation = Quaternion.AngleAxis(180f, Vector3.up);
                mainCamera.GetComponent<CameraMovement>().angleToRotate = 180f;
                StartCoroutine(mainCamera.GetComponent<CameraMovement>().StartZoomingOut());
                //mainCamera.GetComponent<Camera>().orthographicSize = 5.35f;
                currScene = CurrentScene.FUTURE;
                break;

            case CurrentScene.FUTURE:
                mainCamera.transform.position = new Vector3(0f, 0f, 0f);
                mainCamera.transform.rotation = Quaternion.AngleAxis(180f, Vector3.up);
                mainCamera.GetComponent<CameraMovement>().angleToRotate = 180f;
                StartCoroutine(mainCamera.GetComponent<CameraMovement>().StartZoomingOut());
                //mainCamera.GetComponent<Camera>().orthographicSize = 5.35f;
                currScene = CurrentScene.PRESENT;
                break;
        }
    }
}
