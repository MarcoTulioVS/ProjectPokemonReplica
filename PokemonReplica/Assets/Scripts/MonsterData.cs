using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(menuName = "Monster/New Monster",fileName = "New Monster")]
public class MonsterData : ScriptableObject
{
    public int level;
    public float life;
    public string nameMonster;
    public Sprite image;

    [Header("SKILLS")]
    public Sprite firstSkill;
    public Sprite secondSkill;

}
