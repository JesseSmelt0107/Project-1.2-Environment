using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
    public int i;
    public List<bool> buttons = new List<bool>();
    public GameObject ruinDoors;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CheckButtons();
	}


    void CheckButtons ()
    {
        for (i = 0; i < 5; i++)
        {
            if(buttons[i] == false)
            {
                return;
            }

           
        }

        if(i == buttons.Count)
        {
            ruinDoors.transform.GetChild(0).GetComponent<DoorRightAnim>().anim.SetBool("DoorOpenRight", true);
            ruinDoors.transform.GetChild(1).GetComponent<DoorLeftAnim>().anim.SetBool("DoorOpenLeft", true);
        }

    }
}
