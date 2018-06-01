//Attach this script to a GameObject.
//Create a Text GameObject (Create>UI>Text) and attach it to the My Text field in the Inspector of your GameObject
//Press the space bar in Play Mode to see the Text change.

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreTracker : MonoBehaviour
{
    public Text killCount;
    public Text winText;
    public int count;
    
    void Start()
    {
        GameObject zombiesKilled = GameObject.Find("ZombiesKilled");
        killCount = GetComponent<Text>();
        count = 0;
        winText.text = "";
    }

    void Update()
    {
        
        if (gameObject.tag == "Zombie")
        {
            count = count++;
            SetCountText();
        }
        else
        {
            Debug.Log("<color=red> Fatal Error:</color> This shit is still not working.");
        }
    }

    void SetCountText()
    {
        killCount.text = "Kills:" + count.ToString();
        if (count >= 7)
        {
            winText.text = "You Win!";
        }
        
    }
}