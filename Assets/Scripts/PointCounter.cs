using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour {
    public Text zombiesKilled;
    public Text killCount;
    public GUISkin guiSkin = null;
    public static int points = 0;

    private void Start()
    {
        GameObject zombiesKilled = GameObject.Find("ZombiesKilled");
        killCount = GetComponent<Text>();
    }

    private void Update()
    {
        SetCountText();
    }

    /*private void OnGUI()
    {
        GUI.skin = guiSkin;
        GUI.Label(new Rect(0.0f, 0.0f, 128f, 32.0f), "Zombies Killed:" + points.ToString());
        GUI.skin = null;
    }*/

    void SetCountText()
    {
        zombiesKilled.text = "Kills: " + points.ToString();
    }

}
