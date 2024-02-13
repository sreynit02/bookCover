using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;
public class VRButton : MonoBehaviour
{
    // public GameObject obj;
    public VirtualButtonBehaviour vButton;
    public TMP_Text information;
    // public TMP_Text summary;
    public TMP_Text summary;


    // Start is called before the first frame update
    void Start()
    {
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        summary.enabled = true;
        information.enabled = false;
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        summary.enabled=false;
        information.enabled=true;
        Debug.Log("Button released");
    }
}
