using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public GameObject player;
    public Vector3 moving;
    public float moveSpeed;
    public Vector3 rotationCam;
    public Vector3 rotationPlayer;
    RaycastHit rayHit;
    public GameObject hitButton;
    public GameObject curTrigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        moving.x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        moving.z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        player.transform.Translate(moving);

        ButtonActivate();

        rotationPlayer.y = Input.GetAxis("Mouse X");
        rotationCam.x = Input.GetAxis("Mouse Y");
        

        transform.Rotate(rotationCam);
        player.transform.Rotate(rotationPlayer);

	}

    void ButtonActivate () {

        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out rayHit, 3f))
            {
                if (rayHit.collider.tag == "Button")
                {
                    print("hit");
                    hitButton = rayHit.transform.gameObject;
                    hitButton.GetComponent<ButtonScript>().pressed = true;
                }
            }
        }


    }



}
