using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarcodeScanner : MonoBehaviour {
    bool onOff = false;

    GameObject line;
    GameObject light;
    string scannedInfo;

    private void Start()
    {
        line = GameObject.Find("Cube");
        light = GameObject.Find("Spotlight");
        line.SetActive(false);
        light.SetActive(false);
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (onOff)
        {
            if (Physics.Raycast(transform.position, fwd, out hit, 10))
            {
               //ebug.Log("Raycast Hit: " + hit.collider.gameObject.name);
                if(hit.collider.gameObject.tag =="Barcode")
                {
                    scannedInfo = GameObject.Find("barcode").GetComponent<Barcode_Information>().scannedInfo;
                    Debug.Log("Hit Barcode");
                    Debug.Log(scannedInfo);
                }
            }
        }
    }

    public void TriggerRayCast()
    {
        onOff = true;
        line.SetActive(true);
        light.SetActive(true);

    }

    public void OnUnuse()
    {
        onOff = false;
        line.SetActive(false);
        light.SetActive(false);
    }
}
