using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoundDownTimer : MonoBehaviour
{
    
    public float currentTime = 0;
    float startingTime = 501 / 60;

   
    
	
    [SerializeField] Text countdownText;

    private void Start()
    {
        currentTime = startingTime;
        
    }
    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
        if (currentTime == 0)
        {
            
        }
    }
}
