using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HartScript : MonoBehaviour
{
    public Button ButtonHealt0;
    public Button ButtonHealt1;
    public RawImage hart;
    public RawImage hart1;
    public RawImage hart2;
    public int healt = 3;


    void Start()
    {

        Button btn = ButtonHealt0.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button btn1 = ButtonHealt1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);

    }
    void TaskOnClick()
    {
        if(healt == 3)
        {
            healt--;
            hart2.enabled = false;
        }
        else if(healt == 2)
        {
            healt--;
            hart1.enabled = false;
        }
        else if (healt == 1)
        {
            healt--;
            hart.enabled = false;
        }
        
    }
    void TaskOnClick1()
    {
        if (healt == 0)
        {
            healt++;
            hart.enabled = true;
        }
        else if (healt == 1)
        {
            healt++;
            hart1.enabled = true;
        }
        else if (healt == 2)
        {
            healt++;
            hart2.enabled = true;
        }


    }
}
