using UnityEngine;
using System.Collections;


public class Cambiar_Camara : MonoBehaviour
{
    GameObject x;
    GameObject y;
    Camera[] x1;
    Camera[] y1;

    // Use this for initialization
    void Start()
    {
        x = GameObject.Find("camara1");
        y = GameObject.Find("camara2");
        x1 = x.GetComponentsInChildren<Camera>();
        y1 = y.GetComponentsInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            foreach (Camera i in x1)
            {
                i.enabled = false;
            }
            foreach (Camera i in y1)
            {
                i.enabled=true;
            }
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            foreach (Camera i in y1)
            {
                i.enabled = false;
            }
            foreach (Camera i in x1)
            {
                i.enabled = true;
            }
        }
    }
}


