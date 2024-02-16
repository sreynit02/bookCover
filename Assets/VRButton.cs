using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;
public class VRButton : MonoBehaviour
{
    // public GameObject obj;
    public VirtualButtonBehaviour[] vButton;
    public TMP_Text information;
    // public TMP_Text summary;
    public TMP_Text summary;


    // Start is called before the first frame update
    void Start()
    {
        vButton = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vButton.Length; ++i)
        {
            vButton[i].RegisterOnButtonPressed(OnButtonPressed);
            vButton[i].RegisterOnButtonReleased(OnButtonReleased);
        }
        information.enabled = true;
        summary.enabled = false;

    }

    public void OnButtonPressed(VirtualButtonBehaviour go)
    {
        summary.enabled = true;
        information.enabled = false;
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour go)
    {
        summary.enabled = false;
        information.enabled = true;
        Debug.Log("Button released");
    }
}
