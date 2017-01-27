using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {
    public int listNumber;
    public bool pressed;
    public GameObject manager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(pressed == true)
        {
            manager.GetComponent<ButtonManager>().buttons[listNumber] = true;
        }
	}
}
