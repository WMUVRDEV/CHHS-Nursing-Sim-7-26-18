using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSettings : MonoBehaviour
{
    public GameObject leftBedDest;
    public GameObject rightBedDest;
    GameObject LocalAvatObj;
    GameObject VRTKObj;

    Transform VRTKTrans;
    Transform Local;

    public bool leftBedSpawn = false;
    public bool rightBedSpawn = false;




    // Use this for initialization
    void Start()
    {
        LocalAvatObj = GameObject.Find("LocalAvatar");
        VRTKObj = GameObject.Find("VRTK");
        VRTKTrans = VRTKObj.transform;
        Local = LocalAvatObj.transform;
        CheckNull(VRTKObj);
        CheckNull(LocalAvatObj);
        spawnPoint();
    }

    private void Update()
    {
        //Debug.Log(LocalAvatObj.transform.position);
        CheckAvatarTransform();
    }

    //Select Spawn Point
    public void spawnPoint()
    {
        if (leftBedSpawn == true)
        {
            rightBedSpawn = false;
            LocalAvatObj.transform.position = leftBedDest.transform.position;
            LocalAvatObj.transform.rotation = leftBedDest.transform.rotation;
            VRTKObj.transform.position = leftBedDest.transform.position;
            VRTKObj.transform.rotation = leftBedDest.transform.rotation;
            leftBedDest.SetActive(false);
            Debug.Log("Left spawn point selected");
        }

        else if (rightBedSpawn == true)
        {
            leftBedSpawn = false;
            rightBedDest.SetActive(false);
            LocalAvatObj.transform.position = rightBedDest.transform.position;
            LocalAvatObj.transform.rotation = rightBedDest.transform.rotation;
            VRTKObj.transform.position = rightBedDest.transform.position;
            VRTKObj.transform.rotation = rightBedDest.transform.rotation;
            Debug.Log("Right spawn point selected");
        }

        else
        {
            Debug.Log("No spawn point selected");
        }
    }

    void CheckAvatarTransform()
    {
        if (rightBedDest.activeInHierarchy == false)
        {
            if (LocalAvatObj.transform.position.z > -.4f)
            {
                rightBedDest.SetActive(true);
                //LocalAvatObj.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
               // VRTKObj.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                Debug.Log("VRTK Transform" + VRTKObj.transform.rotation);
                Debug.Log("Local Avatar Transform: " + LocalAvatObj.transform.rotation);
                LocalAvatObj.GetComponent<SpawnSettings>().enabled = false;
            }
        }

        else if (leftBedDest.activeInHierarchy == false)
        {
            if (LocalAvatObj.transform.position.z < .9f)
            {
                leftBedDest.SetActive(true);
               //LocalAvatObj.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
               // VRTKObj.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                Debug.Log("VRTK Transform" + VRTKObj.transform.rotation);
                Debug.Log("Local Avatar Transform: " + LocalAvatObj.transform.rotation);
                LocalAvatObj.GetComponent<SpawnSettings>().enabled = false;
            }
        }
    }


    void CheckNull(GameObject test)
    {
        if (test == null)
        {
            Debug.Log(test.name + " Is Null");
            test.SetActive(false);
        }
    }


}