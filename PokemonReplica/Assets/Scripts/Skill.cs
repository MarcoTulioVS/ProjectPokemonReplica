using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Skill : MonoBehaviour
{
    [SerializeField]
    public int condictionalValue;
    
    public void SetConditionalValue()
    {
        SkillController.instance.condictionalValue = condictionalValue;
    }

    IEnumerator DesactivateText()
    {
        
        yield return new WaitForSeconds(1);
        transform.GetComponentInChildren<Text>().enabled = false;
    }

    public void ActivateSkillText()
    {
        transform.GetComponentInChildren<Text>().enabled = true;
        StartCoroutine("DesactivateText");
       
    }
}
