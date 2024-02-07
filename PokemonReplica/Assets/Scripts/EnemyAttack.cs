using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    private float condictionalValue;

    public GameObject target;

    private bool isReady;

    public void RandomizedAttack(float damage)
    {
        int randomValue = Random.Range(0, 11);

        if (randomValue >= condictionalValue)
        {
            target.GetComponent<Monster>().DecrementLife(damage);
           
            StartCoroutine("BlinkPlayer");
            
        }
        else
        {
            return;
        }
    }

    IEnumerator BlinkPlayer()
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

    
}
