using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    public Text playerHealth;
    public Text currentHealth;
    public GUISkin guiSkin = null;
    public static int health = 0;

    private void Start()
    {
        GameObject playerHealth = GameObject.Find("Health");
        currentHealth = GetComponent<Text>();
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
        playerHealth.text = "Health: " + health.ToString();
    }

}
