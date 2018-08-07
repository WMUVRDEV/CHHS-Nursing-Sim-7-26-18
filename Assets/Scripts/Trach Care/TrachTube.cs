using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class TrachTube : ItemInteraction {

    public GameObject oxygenMask;
    public bool oxygenMaskRemoved;

    public GameObject innerCanulla;
    public VRTK_InteractableObject innerCanullaVRTK;
    public bool innerCanullaRemoved;
    public bool canullaCleaned;
    public VRTK_InteractableObject oldGauzeUnderCanullaVRTK;

    public bool innerCanullaSubmerged;

   

    void Start()
    {
        innerCanullaVRTK.isGrabbable = false;
        oldGauzeUnderCanullaVRTK.isGrabbable = false;
    }

    public void RemoveOxygenMask()
    {
        innerCanullaVRTK.isGrabbable = true;
        oldGauzeUnderCanullaVRTK.isGrabbable = true;
        oxygenMaskRemoved = true;
    }





    public void CanullaRemovedFromSaline()
    {
        //save the amount of time it been sumberged in order to restart the timer.

        if (canullaCleaned)
        {
            Debug.Log("Inner Canulla CLeaned");
        }
        else
        {
            Debug.Log("The Inner Canulla must be cleaned for 30 seconds");
        }
    }








}
