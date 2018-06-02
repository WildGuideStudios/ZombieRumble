using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour {
    public Transform canvas;
    public Transform hudCanvas;
    public Transform Player;
    public Transform MenuCamera;


	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }

    }
    public void Pause()
    {
            if (canvas.gameObject.activeInHierarchy == false && hudCanvas.gameObject.activeInHierarchy == true)
        {

            canvas.gameObject.SetActive(true);
            hudCanvas.gameObject.SetActive(false);
            Time.timeScale = 0;
            Player.GetComponent<FirstPersonController>().enabled = false;
        }

        else if (MenuCamera.gameObject.activeInHierarchy == true)
        {
            Menu();
        }

        else
        {
            canvas.gameObject.SetActive(false);
            hudCanvas.gameObject.SetActive(true);
            Time.timeScale = 1;
            Player.GetComponent<FirstPersonController>().enabled = true;
        } 
            
    }

    public void Menu()
    {
        Time.timeScale = 1;
    }
    
}
