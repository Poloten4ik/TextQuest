﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextQuestSO : MonoBehaviour
{
    public Text contentText;
    public Text currentLocation;
    public StepSO startStep;
    public StepSO currentStep;
    public Image currentSprite;

    private bool isTyping;
    private Coroutine currentCoroutine;

    private void Start()
    {
        Action(startStep);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Action(currentStep.nextSteps[0]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            try
            {
                Action(currentStep.nextSteps[1]);
            }
            catch
            {
            }
        }
    }

    private IEnumerator TypeSentence(string sentence)
    {
        foreach (char letter in sentence.ToCharArray())
        {
            contentText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }

        isTyping = false;
    }

    private void Action(StepSO step)
    {
        if (isTyping)
        {
            StopCoroutine(currentCoroutine);
            contentText.text = currentStep.content;
            isTyping = false;
            return;
        }

        isTyping = true;
        contentText.text = string.Empty;
        currentStep = step;
        currentLocation.text = currentStep.location;
        currentSprite.sprite = currentStep.imageLocation;
        currentCoroutine = StartCoroutine(TypeSentence(currentStep.content));
    }
}
