using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTimeFix : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Time.timeScale = 1;
        Cursor.visible = true;
		
	}
}
