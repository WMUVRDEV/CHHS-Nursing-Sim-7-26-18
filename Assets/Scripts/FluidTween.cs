using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluidTween : MonoBehaviour {
    //public Material Saline;
    public Renderer rend;
    public Material thisMat;
    public float fillSpeed;
    public bool toggle = true;
    public  float offset = 0.0f;
    int count = 0;

    public bool on = false;


    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        StartRepeating();
    }

    // Update is called once per frame
    void Update () {

        if (offset >= 0.5)
        {
            CancelInvoke("SalineAnimation");
        }
    }

    public void SalineAnimation()
    {
       // offset = Time.time * (-fillSpeed);
        offset += 0.001f;
        thisMat.mainTextureOffset = new Vector2(0, offset);
    }

    public void StartRepeating()
    {
        Debug.Log("Repeating");
        InvokeRepeating("SalineAnimation", 0.0f, .1f);
    }
}
