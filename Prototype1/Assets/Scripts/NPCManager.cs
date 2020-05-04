using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

   
    private void OnTriggerEnter(Collider collider)
    {

        collider.GetComponent<CharacterController>().npcZone = true;
        //shove NPC's UI stuff into Dialoguemanager
        collider.GetComponent<CharacterController>().nPC = this.gameObject;

       
    }

    private void OnTriggerExit(Collider collider)
    {
        collider.GetComponent<CharacterController>().npcZone = false;
    }
}
