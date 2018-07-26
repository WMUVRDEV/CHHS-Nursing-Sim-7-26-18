using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowParentObject : MonoBehaviour {

    public Transform myParent;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (myParent != null)
        {
           // transform.position = myParent.transform.position.x;
            transform.position = new Vector3(myParent.transform.position.x, myParent.transform.position.y - 0.076f, myParent.transform.position.z);

        }
    }
}
