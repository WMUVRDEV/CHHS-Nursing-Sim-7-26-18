using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class TrachTube : ItemInteraction {

    public GameObject oxygenMask;
    public bool oxygenMaskRemoved;

    public GameObject trachClip;
    public bool clipHeld; //should this be used or grabbed?

    public GameObject innerCanulla;
    public VRTK_InteractableObject innerCanullaVRTK;
    public bool innerCanullaRemoved;
    public bool canullaCleaned;
    public GameObject outerCanulla;

    public bool innerCanullaSubmerged;

   

    void Start()
    {
        innerCanullaVRTK.isGrabbable = false;
    }


    public void TrachClipHeld()
    {
        // call this from trach clip 
        clipHeld = true;
        innerCanullaVRTK.isGrabbable = true;
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
