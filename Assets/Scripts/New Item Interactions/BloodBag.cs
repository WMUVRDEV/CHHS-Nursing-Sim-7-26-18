using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodBag : ItemInteraction {

    public Canvas bloodAdminCanvas;
    public GameObject checklist;

    void Start()
    {
        checklist.SetActive(false);
    }

    public override void Grabbed()
    {
      //  base.Grabbed();
        checklist.SetActive(true);

       // checklist.GetComponent<BloodAdminChecklist>().SetStart();
        // StartCoroutine(BloodBagWait());
    }

     public void ChecklistComplete()
    {
        checklist.SetActive(false);
    }


    IEnumerator BloodBagWait()
    {
        yield return new WaitForSeconds(5.0f);
        checklist.SetActive(false);
        Task.CheckTasks(true);
    }

}
