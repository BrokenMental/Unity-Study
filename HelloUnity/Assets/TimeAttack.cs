using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAttack : MonoBehaviour {

    private float done = 10.0f;
    public GUIText gui_text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (done > 0f)
        {
            done -= Time.deltaTime;
            gui_text = "Time: " + done + "sec";
        }
        else
        {
            print("Time is Over");
        }
	}
}
