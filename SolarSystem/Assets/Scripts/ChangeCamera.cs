using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    private Camera TheCamera;
    public Camera Cam;
    public Camera CamXY;
    void Start()
    {
        TheCamera = GetComponent<Camera>();
        TheCamera = Camera.main;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            Cam.enabled = true;
            CamXY.enabled = false;

        }
        if (Input.GetKeyDown(KeyCode.R))
        {

            CamXY.enabled = true;
            Cam.enabled = false;

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Cam.enabled = false;
            CamXY.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            {
                Application.Quit();
            }
        }
    }
}
