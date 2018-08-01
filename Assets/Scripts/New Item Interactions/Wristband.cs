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
        StartCoroutine(HideChecklist()); 
        Task.CheckTasks(true);
    }
	
	IEnumerator HideChecklist()
	{
        yield return new WaitForSeconds(0.25f);
        Checklist.SetActive(false);
       // Task.CheckTasks(true);
	}

}
