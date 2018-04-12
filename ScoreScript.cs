using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public  Button Button;
    public Button Button1;
    public Text Textje;
     public int scoret;
    

    void Start()
    {
        Button btn = Button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
        

        Button btn1 = Button1.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick1);

    }

    void TaskOnClick()
    {
       
  
        
         scoret = scoret + 1;
        Textje.text = "Score: " + scoret;
       
        
    }
    void TaskOnClick1()
    {

  
        scoret = scoret - 1;
        Textje.text = "Score: " + scoret;

    }
}
