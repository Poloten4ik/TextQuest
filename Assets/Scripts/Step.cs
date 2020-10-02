using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Step : MonoBehaviour
{
    [TextArea(10,50)]
    public string content;
    public string location;
    public Step[] nextSteps;
    public Sprite imageLocation;
   
}
