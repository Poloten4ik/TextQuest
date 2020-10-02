﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text contentText;
    public Text currentLocation;
    public Step startStep;
    public Step currentStep;
    public Image currentSprite;
    void Start()
    {
        currentStep = startStep;
        contentText.text = startStep.content;
        currentLocation.text = currentStep.location;
        currentSprite.sprite = currentStep.imageLocation;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentStep = currentStep.nextSteps[0];
            contentText.text = currentStep.content;
            currentLocation.text = currentStep.location;
            currentSprite.sprite= currentStep.imageLocation;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentStep = currentStep.nextSteps[1];
            contentText.text = currentStep.content;
            currentLocation.text = currentStep.location;
            currentSprite.sprite = currentStep.imageLocation;
        }
      
    }
}
