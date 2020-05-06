using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    [SerializeField] GameObject talkUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void Talk()
    {
        this.GetComponent<DialgoueTrigger>().TriggerDialogue();
        talkUI.SetActive(false);
    }

   
    private void OnTriggerEnter(Collider collider)
    {
        talkUI.SetActive(true);
        collider.GetComponent<CharacterController>().npcZone = true;
        //shove NPC's UI stuff into Dialoguemanager
        collider.GetComponent<CharacterController>().nPC = this.gameObject;

       
    }

    private void OnTriggerExit(Collider collider)
    {
        talkUI.SetActive(false);
        collider.GetComponent<CharacterController>().npcZone = false;
        collider.GetComponent<CharacterController>().timePressed = 0;
    }
}
