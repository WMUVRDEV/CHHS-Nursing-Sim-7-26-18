using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCollision : ItemInteraction {

    GameObject rHand, lHand;

    string activeHand;

    ParticleSystem waterSystem;

    bool leftHandWashed, rightHandWashed;
    

    void OnParticleCollision(GameObject other)
    {
        if(other)

        Debug.Log(other.gameObject.name);
        if (other.transform.parent.name == "RightController")
        {
            activeHand = "Right";
            Debug.Log("Right Hand in Water");
        }

        else if (other.transform.parent.name == "LeftController")
        {
            activeHand = "Left";
            Debug.Log("Left Hand in water");

        }

    }
}
