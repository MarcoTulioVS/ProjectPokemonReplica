using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    #region VARIABLES
    [Header("Attack button")]
    
    [SerializeField]
    private float attackButtonPosX;

    [SerializeField]
    private float attackButtonPosY;

    [SerializeField]
    private Transform attackButton;

    private bool attackButtonIsActive = true;

    Vector2 initialButtonPos;


    public GameObject panelRunAway;
    #endregion

    #region METHODS
    void Start()
    {
        initialButtonPos = attackButton.localPosition;
    }

    public void DownButton(GameObject image)
    {
        attackButtonIsActive = !attackButtonIsActive;

        if (!attackButtonIsActive)
        {
            image.transform.localPosition = new Vector2(attackButtonPosX, attackButtonPosY);
        }
        else
        {
            image.transform.localPosition = initialButtonPos;
        }
        
    }

    public void Runaway()
    {
        StartCoroutine("StartRunaway");
    }
    #endregion

    #region COROUTINES
    IEnumerator StartRunaway()
    {
        panelRunAway.SetActive(true);
        yield return new WaitForSeconds(2.3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    #endregion
}
