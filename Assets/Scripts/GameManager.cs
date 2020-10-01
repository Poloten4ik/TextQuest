using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text contentText;
    public Step startStep;
    public int[] numbers;

    public Step currentStep;

    public string[] Mounth;
    // Start is called before the first frame update
    void Start()
    {
        currentStep = startStep;
        contentText.text = startStep.content;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentStep = currentStep.nextSteps[0];
            contentText.text = currentStep.content;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentStep = currentStep.nextSteps[1];
            contentText.text = currentStep.content;
        }
      
    }
}
