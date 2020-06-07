using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendManager : MonoBehaviour
{
    public int[] changeWait;
    private int count;
    public string friendName;
    [SerializeField] Text name;
    [SerializeField] DialogueManager dM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeName()
    {
        if (dM.sentCount == changeWait[count])
        {
            if (name.text == friendName)
            {
                name.text = dM.npcCharName;
            }
            else if (name.text == dM.npcCharName)
            {
                name.text = friendName;
            }
            
            count++;
            dM.sentCount = 0;
            Debug.Log(count);
            Debug.Log(dM.sentCount);
        }
    }
}
