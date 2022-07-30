using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject cameraOne;
    public GameObject cameraTwo;
    public GameObject cameraThree;
    public GameObject generalCamera;
    public GameObject sideCamera;
    public GameObject otherSideCamera;
    public GameObject sunTopCamera;
    public GameObject shipCam1;
    public GameObject shipCam2;
    public GameObject shipCam3;
    public GameObject planetCam1;
    public GameObject planetCam2;
    public GameObject planetCam3;
    public GameObject planetCam4;
    public GameObject planetCam5;
    public GameObject planetCam6;
    public GameObject planetCam7;
    public GameObject planetCam8;

    // Update is called once per frame
    void Update()
    {
        //Change Camera Keyboard
        switchCamera();
    }

    //Change Camera Keyboard
    void switchCamera()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            cameraChangeCounter();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            goToGeneralCam();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            sideCameraChangeCounter();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            shipCameraChangeCounter();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            planetCameraChangeCounter();
        }

    }

    //Camera Counter
    void cameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        meteorCameraPositionChange(cameraPositionCounter);
    }
    void sideCameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        goToSideCam(cameraPositionCounter);
    }

    void shipCameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        goToShipCam(cameraPositionCounter);
    }
    void planetCameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        goToPlanetCam(cameraPositionCounter);
    }

    void goToGeneralCam()
    {
        cameraOne.SetActive(false);
        cameraTwo.SetActive(false);
        cameraThree.SetActive(false);
        generalCamera.SetActive(true);
        sideCamera.SetActive(false);
        otherSideCamera.SetActive(false);
        sunTopCamera.SetActive(false);
        shipCam1.SetActive(false);
        shipCam2.SetActive(false);
        shipCam3.SetActive(false);
        planetCam1.SetActive(false);
        planetCam2.SetActive(false);
        planetCam3.SetActive(false);
        planetCam4.SetActive(false);
        planetCam5.SetActive(false);
        planetCam6.SetActive(false);
        planetCam7.SetActive(false);
        planetCam8.SetActive(false);
    }

    void goToSideCam(int camPosition)
    {
        if (camPosition > 2)
        {
            camPosition = 0;
        }
        PlayerPrefs.SetInt("CameraPosition", camPosition);
        if (camPosition == 0)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(true);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        if (camPosition == 1)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(true);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        if (camPosition == 2)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(true);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }

    }

    void goToShipCam(int camPosition)
    {
        if (camPosition > 2)
        {
            camPosition = 0;
        }
        PlayerPrefs.SetInt("CameraPosition", camPosition);
        if (camPosition == 0)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(true);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        if (camPosition == 1)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(true);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        if (camPosition == 2)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(true);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }

    }

    //Camera change Logic
    void meteorCameraPositionChange(int camPosition)
    {
        if (camPosition > 2)
        {
            camPosition = 0;
        }

        //Set camera position database
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        //Set camera position 1
        if (camPosition == 0)
        {
            cameraOne.SetActive(true);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        //Set camera position 2
        if (camPosition == 1)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(true);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        //Set camera position 3
        if (camPosition == 2)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(true);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
    }
    void goToPlanetCam(int camPosition)
    {
        if (camPosition > 7)
        {
            camPosition = 0;
        }
        PlayerPrefs.SetInt("CameraPosition", camPosition);
        if (camPosition == 0)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(true);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        if (camPosition == 1)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(true);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        if (camPosition == 2)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(true);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        if (camPosition == 3)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(true);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        if (camPosition == 4)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(true);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        if (camPosition == 5)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(true);
            planetCam7.SetActive(false);
            planetCam8.SetActive(false);
        }
        if (camPosition == 6)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(true);
            planetCam8.SetActive(false);
        }
        if (camPosition == 7)
        {
            cameraOne.SetActive(false);
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            generalCamera.SetActive(false);
            sideCamera.SetActive(false);
            otherSideCamera.SetActive(false);
            sunTopCamera.SetActive(false);
            shipCam1.SetActive(false);
            shipCam2.SetActive(false);
            shipCam3.SetActive(false);
            planetCam1.SetActive(false);
            planetCam2.SetActive(false);
            planetCam3.SetActive(false);
            planetCam4.SetActive(false);
            planetCam5.SetActive(false);
            planetCam6.SetActive(false);
            planetCam7.SetActive(false);
            planetCam8.SetActive(true);
        }

    }
}