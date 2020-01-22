using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhoneAction : AbstractAction
{
    public Camera camera;
    public GameObject dialogueManager;
    public GameObject[] bottons;
    public int[] correctNumber;
    public bool correct_pasword = false;
    int N_insert_number = 0;
    Vector3 on_position;

    private Queue<int> inserted_number;
   
    void Start()
    {
        eventSystem = GameObject.Find("CustomEventManager").GetComponent<EventSystem>();
        correctNumber = new int[9];
        inserted_number = new Queue<int>();
    }
    public override void DoMyOwnAction()
    {
        on_position = transform.position;
        N_insert_number = 0;
        camera.GetComponent<blur>().BlurIn();
        on_position = transform.position;
        StartCoroutine(SpriteCenter(camera));
        for (int i = 0; i < 9; ++i)
        {
            bottons[i].SetActive(true);
        }
    } 
    public override void EndAction()
    {
        if (inserted_number.Count > 8)
        {
            camera.GetComponent<blur>().BlurOut();
            StartCoroutine(ReturnOriginalPos(on_position));
            StopAllCoroutines();
            for (int i = 0; i < 9; ++i)
            {
                bottons[i].SetActive(false);
            }
            for(int i = inserted_number.Count - 1; i >= 0; --i)
            {
                if(correctNumber[i] != inserted_number.Dequeue())
                {
                    continue;
                }
                correct_pasword = true;
            }

        }
    }

    public void SetNumber(int num)
    {
        inserted_number.Enqueue(num);
        Debug.Log(inserted_number);
        ++N_insert_number;
        EndAction();
    }
}
