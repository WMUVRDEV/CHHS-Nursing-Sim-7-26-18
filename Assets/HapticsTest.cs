using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HapticsTest : System.Object {

    public AudioClip hapticsClip;
    public OVRHapticsClip _Clip;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayHaptics()
    {
        _Clip = new OVRHapticsClip(hapticsClip);
        OVRHaptics.Channels[1].Queue(_Clip);

    }
}
