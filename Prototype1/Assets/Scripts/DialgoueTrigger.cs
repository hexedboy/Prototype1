using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialgoueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public string nPC;

    public void TriggerDialogue(GameObject npc)
    {
        //nPC = this.gameObject.name;
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, npc);
    }
}
