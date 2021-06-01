using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cam;
    public GameObject card;
    public GameObject scanButtonPanel;
    public void onButtonDown()
    {
        //Instantiate(cam, new Vector3(0, 0, 0), Quaternion.identity);
        card.SetActive(true);
        cam.SetActive(true);
        scanButtonPanel.SetActive(false);
    }
}
