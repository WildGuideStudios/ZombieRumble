using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour {
    public Transform canvas;
    public Transform hudCanvas;
    public Transform Player;
    public Transform MenuCamera;
    public Transform ZombieSpawn;
    public Transform ObjectSpawn;


	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && Player.gameObject.activeInHierarchy == true) {
            Pause();
        }
    }

    public void Pause()
    {
        string sname = "PauseGame.cs - ";
        if (canvas.gameObject.activeInHierarchy == false && hudCanvas.gameObject.activeInHierarchy == true) {
            Debug.Log(sname + "Paus function if");
            canvas.gameObject.SetActive(true);
            hudCanvas.gameObject.SetActive(false);
            Time.timeScale = 0;
            Player.GetComponent<FirstPersonController>().enabled = false;
        } else if (Player.gameObject.activeInHierarchy == false) {
            Debug.Log(sname + "Paus function else if");
            Menu();
        } else {
            Debug.Log(sname + "Paus function else");
            canvas.gameObject.SetActive(false);
            hudCanvas.gameObject.SetActive(true);
            Time.timeScale = 1;
            Player.GetComponent<FirstPersonController>().enabled = true;
        } 
    }

    public void Menu() {
        Time.timeScale = 1;
        MenuCamera.gameObject.SetActive(true);
        ZombieSpawn.gameObject.SetActive(false);
        ObjectSpawn.gameObject.SetActive(false);
    }
}
