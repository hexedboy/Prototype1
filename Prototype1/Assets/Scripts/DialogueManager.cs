using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Queue<string> sentences;
    [SerializeField] GameObject speechbubble;
    [SerializeField] Text dialogueText;
    [SerializeField] Text name;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("starting convo with" + dialogue.name);

        speechbubble.SetActive(true);
        name.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        //dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        Debug.Log(sentence);
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    private void EndDialogue()
    {
        Debug.Log("End of convo");
        player.GetComponent<CharacterController>().talking = false;
        //player.GetComponent<CharacterController>().timePressed = 0;
        speechbubble.SetActive(false);
    }
    
}
