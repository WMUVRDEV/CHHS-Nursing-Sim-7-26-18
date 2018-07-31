using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodAdminChecklist : MonoBehaviour {

    public Text bloodAdminTitle;

    public List<Button> bloodAdminButtons;

    public List<Text> bloodAdminButtonText;

    public int pageNumber;

    public List<string> questions;

    public bool medicalOrder;

    public bool informedConsent;

    public List<int> patientID;

    public List<string> patientName;

    public List<string> bloodgroupandtyp;

    public List<string> expiration;

    public bool inspectBlood;

    public bool checklistComplete;

    public void OnEnable()
    {
        pageNumber = 0;
         bloodAdminTitle.text = questions[pageNumber];
                bloodAdminButtonText[0].text = "yes";
                bloodAdminButtonText[1].text = "no";
                bloodAdminButtons[2].gameObject.SetActive(false);
    }

    

    public void NextPage() {

        //   void Start () {
        pageNumber++;

        switch (pageNumber)
        {
            case 0:
                Debug.Log("case " + pageNumber);

                bloodAdminTitle.text = questions[pageNumber];
                bloodAdminButtonText[0].text = "yes";
                bloodAdminButtonText[1].text = "no";
                bloodAdminButtons[2].gameObject.SetActive(false);
      

                break;
            case 1:
                //Has the patient given consent?

                bloodAdminTitle.text = questions[pageNumber];
                bloodAdminButtonText[0].text = "yes";
                bloodAdminButtonText[1].text = "no";
                bloodAdminButtons[2].gameObject.SetActive(false);

              //  pageNumber++;


                break;
            case 2:
                //What is the patient identification number?

                bloodAdminTitle.text = questions[pageNumber];
                bloodAdminButtons[2].gameObject.SetActive(true);

                for (int i = 0; i < bloodAdminButtonText.Count; i++)
                {
                    bloodAdminButtonText[i].text = patientID[i].ToString();
                }
             //   pageNumber++;
                break;
            case 3:
                //What is the patients name?

                bloodAdminTitle.text = questions[pageNumber];
                bloodAdminButtons[2].gameObject.SetActive(true);

                for (int i = 0; i < bloodAdminButtonText.Count; i++)
                {
                    bloodAdminButtonText[i].text = patientName[i];
                }
             //   pageNumber++;
                //bloodAdminButtonText[0].text = patientName[0];
                break;

            case 4:
                //What is the labeled blood group and blood type?

                bloodAdminTitle.text = questions[pageNumber];
                bloodAdminButtons[2].gameObject.SetActive(true);

                for (int i = 0; i < bloodAdminButtonText.Count; i++)
                {
                    bloodAdminButtonText[i].text = bloodgroupandtyp[i];
                }
             //   pageNumber++;
                break;
            case 5:
                //What is the labeled expiration date?

                bloodAdminTitle.text = questions[pageNumber];
                bloodAdminButtons[2].gameObject.SetActive(true);

                for (int i = 0; i < bloodAdminButtonText.Count; i++)
                {
                    bloodAdminButtonText[i].text = expiration[i];
                }
             //   pageNumber++;
                break;
            case 6:
                //Were blood clots, clumping, or gas bubbles found when inspecting?

                bloodAdminTitle.text = questions[pageNumber];

                
                bloodAdminButtonText[0].text = "yes";
                bloodAdminButtonText[1].text = "no";
                bloodAdminButtons[2].gameObject.SetActive(false);
                pageNumber++;

                
                

                break;
            default:
                BloodBag bloodBag = GameObject.Find("BloodBag").GetComponent<BloodBag>();
                bloodBag.ChecklistComplete();
                break;
        }
	}
	

}
