using System.Collections;
using System.Collections.Generic;
using Obi;
using UnityEngine;
using VRTK;
using UnityEngine.Events;

public class Poke : MonoBehaviour
{
	//public VRTK_InteractableObject_UnityEvents vrtkObject;
	
	
	public UnityEvent PokeEvent;
	public UnityEvent UnpokeEvent;
	public VRTK_InteractTouch touch;
	public GameObject me;
    public bool inTrigger;

    private void OnTriggerEnter(Collider other)
    {

        //Debug.Log(other.gameObject.name);
        if (other.tag == "poke" && !inTrigger)
        {
            inTrigger = true;
            PokeEvent.Invoke();
            Debug.Log("Poke " + gameObject.name);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //inTrigger = true;
    }

    private void OnTriggerExit(Collider other)
	{
		UnpokeEvent.Invoke();
        inTrigger = false;
	}
}
