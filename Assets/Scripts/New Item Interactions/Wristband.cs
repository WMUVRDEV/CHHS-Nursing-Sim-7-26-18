using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wristband : ItemInteraction {
	
	public AudioClip nurseClip;
	public AudioClip patientClip;

	public bool wristbandBeingRead;
	public bool wristbandIsRead;

	public Transform wristReturn;

    public Canvas wristbandCanvas;
    public GameObject Checklist;


     void Start()
    {
        Checklist.SetActive(false);
    }

    public override void Grabbed()
	{
        Checklist.SetActive(true);
        //   StartCoroutine(ReadWrist()); 
    }

  public  void clickedButton()
    {
        Checklist.SetActive(false);
        Task.CheckTasks(true);
    }
	
	IEnumerator ReadWrist()
	{
        yield return new WaitForSeconds(20.0f);
        Checklist.SetActive(false);
        Task.CheckTasks(true);
	}

}
