using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionClick : MonoBehaviour
{

    public GameObject nPC;

    //set option
    public void SetOption()
    {
        if (this.gameObject.name == "Option1")
        {
            GameObject.Find(nPC.name).GetComponent<NPCManager>().diaNum = 4;
           Debug.Log(GameObject.Find(nPC.name).GetComponent<NPCManager>().diaNum);
            //trigger dialogue using NPC's script
            nPC.GetComponent<DialgoueTrigger>().TriggerDialogue(nPC);

            //hide buttons
        }
        else if (this.gameObject.name == "Option2")
        {
            GameObject.Find(nPC.name).GetComponent<Dialogue>().num = 8;
            //diaNum = 8;
        }
        else if (this.gameObject.name == "Option3")
        {
            GameObject.Find(nPC.name).GetComponent<Dialogue>().num = 12;
            //diaNum = 12;
        }
    }
}
