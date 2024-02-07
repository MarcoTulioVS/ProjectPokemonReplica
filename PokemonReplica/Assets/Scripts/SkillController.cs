using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkillController : MonoBehaviour
{
    #region VARIABLES
    public GameObject target;

    public Text missedAttackText;

    public int condictionalValue;

    public static SkillController instance;

    private bool isReady;
    #endregion

    #region METHODS
    private void Awake()
    {
        instance = this;
    }
    public void RandomizedAttack(float damage)
    {
        int randomValue = Random.Range(0, 11);
        
        if (randomValue >= condictionalValue)
        {
            target.GetComponent<Monster>().DecrementLife(damage);
            StartCoroutine("BlinkEnemy");
        }
        else
        {
            StartCoroutine("MissedAttack");
        }
    }
    #endregion

    #region COROUTINES
    IEnumerator MissedAttack()
    {
        missedAttackText.enabled = true;
        yield return new WaitForSeconds(2);
        missedAttackText.enabled = false;
    }

    IEnumerator BlinkEnemy()
    {
        if (!isReady)
        {
            isReady = true;
            target.GetComponent<Monster>().monsterPortrait.color = Color.gray;
            yield return new WaitForSeconds(0.1f);
            target.GetComponent<Monster>().monsterPortrait.color = Color.white;
            isReady = false;
        }

    }
    #endregion
}
