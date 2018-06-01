using UnityEngine;
using System.Collections;

public class CameraSwitchScript: MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera optionsCamera;

    public void ShowPlayer()
    {
        firstPersonCamera.enabled = false;
        optionsCamera.enabled = true;
    }

    public void ShowOptions()
    {
        firstPersonCamera.enabled = true;
        optionsCamera.enabled = false;
    }
}