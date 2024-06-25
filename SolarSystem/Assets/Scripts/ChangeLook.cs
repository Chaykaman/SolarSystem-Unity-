using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeLook : MonoBehaviour
{
    [SerializeField]
    public GameObject target;
    public Camera Cam;
    public Camera CamXY;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Camera.main.fieldOfView = 60;
            Cam.fieldOfView = 60;
            CamXY.fieldOfView = 60;
            Camera.main.transform.rotation = Quaternion.identity;
            Cam.transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
            CamXY.transform.rotation = Quaternion.Euler(new Vector3(30, -60, 0));
        }
    }
    void OnMouseDown()
    {
        Camera.main.fieldOfView = Mathf.Clamp(30 * target.transform.localScale.x, 1, 100);
        Cam.fieldOfView = Mathf.Clamp(30 * target.transform.localScale.x, 1, 100);
        CamXY.fieldOfView = Mathf.Clamp(30 * target.transform.localScale.x, 1, 100);
    }
}
