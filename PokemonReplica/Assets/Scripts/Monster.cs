using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Monster : MonoBehaviour
{
    [Header("Monster information")]
    public MonsterData monsterData;

    public Text levelText;
    public Text nameText;
    public Image monsterPortrait;
    public Image lifeText;

    private float currentLife;

    [Header("Button images")]
    public Image buttonFirstSkill;

    public Image buttonSecondSkill;

    void Start()
    {
        currentLife = monsterData.life;
        levelText.text = "LV. " + monsterData.level.ToString();
        nameText.text = monsterData.nameMonster;
        monsterPortrait.sprite = monsterData.image;

        if (gameObject.tag == "Player")
        {
            buttonFirstSkill.sprite = monsterData.firstSkill;
            buttonSecondSkill.sprite = monsterData.secondSkill;
        }
        
    }

    
    void Update()
    {
        lifeText.fillAmount = currentLife / monsterData.life;
    }

    public void DecrementLife(float value)
    {
        currentLife -= value;
    }

    
}
