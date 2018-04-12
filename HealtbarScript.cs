
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtbarScript : MonoBehaviour
{
    public Button ButtonHealtbar0;
    public Button ButtonHealtbar1;
    public GameObject healtbar;
    public int healt = 200;


    void Start()
    {
        
        Button btn = ButtonHealtbar0.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button btn1 = ButtonHealtbar1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);

    }
    void TaskOnClick()
    {
        
        if (healt - 20 >= 0)
        {
            healt = healt - 20;
            healtbar.transform.localScale = new Vector3(healt, 25, 1);
        }
        else
        {
            print("dood");
        }

    }
    void TaskOnClick1()
    {

        if (healt + 20 <= 200)
        {
            healt = healt + 20;
            healtbar.transform.localScale = new Vector3(healt, 25, 1);
        }
        else
        {
            print("max levens");
        }

    }
}
