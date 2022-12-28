using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

 public class countdown: MonoBehaviour
 {
     float currentTime = 0f;
     float startingTime = 10f;
    int t;
    [SerializeField] Text countdownText;

    private void Start()
   {
        currentTime = startingTime;
   }
    void Update()
    {
        if (currentTime > 0)
        {
           t =(int)currentTime;
            currentTime -= 1 * Time.deltaTime;

            currentTime=Mathf.Round(currentTime*1000f)/1000f;
            countdownText.text = t.ToString();
        }
        else if(currentTime==0)
        {
            currentTime = 0;
        }
    }
  }
