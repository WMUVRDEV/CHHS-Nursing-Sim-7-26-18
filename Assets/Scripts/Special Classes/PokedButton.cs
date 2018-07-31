using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokedButton : MonoBehaviour {

    public HapticsTest haptics = new HapticsTest();

    public Button thisButton;
    public Color pressedColor;
    public Color baseColor;
    private ColorBlock cb;

    private void OnEnable()
    {
        thisButton = GetComponent<Button>();
        cb = thisButton.colors;
        cb.normalColor = baseColor;
        thisButton.colors = cb;
        haptics.hapticsClip = Resources.Load<AudioClip>("Select2");
    }

    void Start()
    {
        thisButton = GetComponent<Button>();
        cb = thisButton.colors;
        cb.normalColor = baseColor;
        thisButton.colors = cb;
    }


    public void pokedButton()
    {

        //Debug.Log("Poke");
        cb.normalColor = pressedColor;
        thisButton.colors = cb;
       
        haptics.PlayHaptics();
       // thisButton.onClick.Invoke();
    }

    public void unPokedButton()
    {
       // Debug.Log("unPoke");
        cb.normalColor = baseColor;
        thisButton.colors = cb;
    }
    
}
