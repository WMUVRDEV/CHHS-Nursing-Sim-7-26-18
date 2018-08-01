using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCorrection : MonoBehaviour {

    GameObject leftTeleport;
    public GameObject VRTKObj;
    public GameObject LocalAv;
    Collider col;

	// Use this for initialization
	void Start () {
        Debug.Log("Local Init Rotaion" + LocalAv.transform.rotation);
        Debug.Log("VRTK Init Position" + VRTKObj.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
      
	}

}
