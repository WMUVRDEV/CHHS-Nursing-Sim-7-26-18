using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodBag : ItemInteraction {

    public Canvas bloodAdminCanvas;
    public GameObject checklist;
    public BloodAdminChecklist checklistScript;

    void Start()
    {

        checklistScript = checklist.GetComponent<BloodAdminChecklist>();
        checklist.SetActive(false);
    }

    public override void Grabbed()
    {
        //  base.Grabbed();

        if (!checklistScript.checklistComplete)
        {
            checklist.SetActive(true);
        }

       // checklist.GetComponent<BloodAdminChecklist>().SetStart();
        // StartCoroutine(BloodBagWait());
    }

     public void ChecklistComplete()
    {
        checklist.SetActive(false);
        checklistConplete = true;
    }


    IEnumerator BloodBagWait()
    {
        yield return new WaitForSeconds(5.0f);
        checklist.SetActive(false);
        Task.CheckTasks(true);
    }

}
