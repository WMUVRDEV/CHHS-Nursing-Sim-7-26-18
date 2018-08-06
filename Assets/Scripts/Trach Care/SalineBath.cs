using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalineBath : MonoBehaviour {

    public TrachTube trachTube;

    float currCountdownValue;
    public float countdownValue = 30;

    // Use this for initialization
    void Start () {
        trachTube = GameObject.Find("TrachTube").GetComponent<TrachTube>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag("innerCanulla"))
        {
            trachTube.innerCanullaSubmerged = true;
            StartCoroutine(innerCanullaTimer());
        }
	
     }


    public IEnumerator innerCanullaTimer()
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }
        if (trachTube.innerCanullaSubmerged)
        {
            trachTube.canullaCleaned = true;
        }
    }



}
