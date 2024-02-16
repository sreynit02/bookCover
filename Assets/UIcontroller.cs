using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIcontroller : MonoBehaviour
{
    // Start is called before the first frame update    

    bool review = false;
    bool backtoInfo = false;

    public TMP_Text information;
    // public TMP_Text summary;
    public TMP_Text summary;
    // Update is called once per frame
    void Start()
    {
        summary.enabled = false;
        information.enabled = true;
    }
    void Update()
    {
        if (review == true)
            readReview();
        if (backtoInfo == true)
            backtoInform();
    }
    public void readReview()
    {
        summary.enabled = true;
        information.enabled = false;
    }
    public void backtoInform()
    {
        summary.enabled = false;
        information.enabled = true;
    }


}
