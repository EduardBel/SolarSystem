using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawOrbit : MonoBehaviour
{
    public bool trailIsOn = false;
    public GameObject trail;
    public float time=0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            TrailOnOff();
        }
    }


    public void TrailOnOff()
    {
        trailIsOn = !trailIsOn;
        if (trailIsOn == true)
        {
            trail.GetComponent<TrailRenderer>().time = time;
        }
        else
        {
            trail.GetComponent<TrailRenderer>().time = 0f;
        }
    }



}