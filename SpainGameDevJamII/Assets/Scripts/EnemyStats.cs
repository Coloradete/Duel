using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyName
{
    Slime
}
[CreateAssetMenu(fileName = "NewEnemy", menuName = "Enemy")]
public class EnemyStats : ScriptableObject
{
    [SerializeField] new EnemyName name;
    [SerializeField] int health, regularAttackDamage;
    [SerializeField] float buildup, recoil, regularAttackCooldown, runSpeed;

    public string Name => name.ToString();
    public EnemyName RawName => name;
    public int Health => health;
    public int RegularAttackDamage => regularAttackDamage;
    public float Buildup => buildup;
    public float Recoil => recoil;
    public float RegularAttackCooldown => regularAttackCooldown;
    public float RunSpeed => runSpeed;
}
