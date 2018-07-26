using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication;
using Obi;
using UnityEngine;

public class HandSanitizer : ItemInteraction
{

    public AudioClip dispenseClip;
    public AudioClip contactClip;

    public GameObject sanitizerDollop;
    public Transform dispensePoint;

    public GameObject rightHand, leftHand;
    public Collider saniCollider;

    public bool dispensing;
    public bool leftSanitized;
    public bool rightSanitized;
    private string activeHand;

    public GameObject colliderCube;
    private GameObject newCCube;
    public ParticleSystem sanitizerParticles;

    public override void Grabbed()
    {
        base.Grabbed();
    }




    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.gameObject.name);

        if (other.gameObject.name == "Sphere")
        {
            ParticleSystem.CollisionModule pCollision = sanitizerParticles.collision;
            newCCube = Instantiate(colliderCube);
            newCCube.GetComponent<FollowParentObject>().myParent = other.transform;
            pCollision.SetPlane(0, newCCube.transform);

        }

//----- Checks which hand is in collision zone -----
        if (other.transform.parent.transform.parent.name == "RightController")
        {
            activeHand = "Right";
            Dispense();
        }

        else if (other.transform.parent.transform.parent.name == "LeftController")
        {
            activeHand = "Left";
            Dispense();

        }

        
    }

    private void OnTriggerStay(Collider other)
    {
        // dispensing = true;
    }

//----- stops particles on hand exit -----
    private void OnTriggerExit(Collider other)
    {
        dispensing = false;
        sanitizerParticles.Stop();
        if (newCCube != null)
        {
            Destroy(newCCube);
        }
    }

    public void Dispense()
    {

        if (!dispensing)
        {
            dispensing = true;
         // GameObject thisDollop = Instantiate(sanitizerDollop, dispensePoint.position, Quaternion.identity);

            sanitizerParticles.Play();

//----- Dispensing if Left hand in zone -----
            if (activeHand == "Left")
            {
                leftSanitized = true;
                Debug.Log("Left Sani");
                if (leftSanitized && rightSanitized)
                {
                    Sanitized();
                }
            }

//----- Dispensing if right hand is in zone -----
            if (activeHand == "Right")
            {
                rightSanitized = true;
                Debug.Log("Right Sani");
                if (leftSanitized && rightSanitized)
                {
                    Sanitized();
                }
            }

            thisAudio.clip = dispenseClip;
            thisAudio.Play();
        }
    }
//----- Plays audio clip for sanitizing -----
    public void Sanitized()
    {
        thisAudio.clip = contactClip;
        thisAudio.Play();
        Debug.Log("both Sani");
        if (leftSanitized && rightSanitized)
        {
            Task.CheckTasks(true);
        }


    }
}
