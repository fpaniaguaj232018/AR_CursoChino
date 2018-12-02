using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsacionScript : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip acOK;
    public AudioClip acKO;

    void Start () {
		
	}

    void Update()
    {
        //TACTIL
        bool touchAction = (Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began);
        RaycastHit rch;
        if (touchAction)
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(raycast, out rch))
            {
                if (rch.transform.gameObject.name == "lemon")
                {
                    audioSource.PlayOneShot(acOK);
                }
                else
                {
                    audioSource.PlayOneShot(acKO);
                }
            }
        }
        //MOUSE
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out rch))
            {
                if (rch.transform.gameObject.name == "lemon")
                {
                    audioSource.PlayOneShot(acOK);
                }
                else
                {
                    audioSource.PlayOneShot(acKO);
                }

            }
        }
    }
}
