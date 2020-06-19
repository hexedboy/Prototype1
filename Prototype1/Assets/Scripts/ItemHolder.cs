using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    public bool interacted = false;
    [SerializeField] GameObject[] friend;
    [SerializeField] int[] num;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerFriend()
    {
        if (interacted == false)
        {
            int numcount = 0;
            foreach (GameObject frend in friend)
            {
                frend.GetComponent<NPCManager>().diaNum = num[numcount];
                numcount++;
            }
            //friend.GetComponent<NPCManager>().diaNum = num;
            interacted = true;
        }
    }
}
