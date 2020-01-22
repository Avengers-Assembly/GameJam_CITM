using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    Queue<string> sentences;

    GameObject interact;
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void SetObjectPicked(GameObject obj)
    {
        interact = obj;
    }
    public void StartDialogue(Dialogue dialogue)
    {
        sentences.Clear();

        nameText.text = dialogue.name;
        animator.SetBool("is_Open", true);

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSence();
    }

    public void DisplayNextSence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        animator.SetBool("is_Open", false);
        interact.GetComponent<AbstractAction>().EndAction();
        interact = null;
    }
}
