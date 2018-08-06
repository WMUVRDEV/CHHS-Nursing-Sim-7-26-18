using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class TrachCareKit : ItemInteraction {

    public VRTK_InteractableObject trayCoverVRTK, cottonSwap, drape, sterileGloves, underTrachGauze;

    public GameObject salineFilledLiquid;


    // Use this for initialization
    void Start () {
        trayCoverVRTK.isGrabbable = false;
        cottonSwap.isGrabbable = false;
        drape.isGrabbable = false;
        sterileGloves.isGrabbable = false;
        underTrachGauze.isGrabbable = false;
    }

public void TrayGrabbed()
    {
        trayCoverVRTK.isGrabbable = true;
    }

    public void TrayCoverRemoved()
    {

        sterileGloves.isGrabbable = true;
    }

    public void GlovesGrabbed()
    {
        drape.isGrabbable = true;
        cottonSwap.isGrabbable = true;
        cottonSwap.isGrabbable = true;
    }


}
