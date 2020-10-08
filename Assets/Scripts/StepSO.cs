using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Step", fileName = "New Step")]
public class StepSO : ScriptableObject
{
    [TextArea(10, 50)]
    public string content;
    public string location;
    public StepSO[] nextSteps;
    public Sprite imageLocation;

}
