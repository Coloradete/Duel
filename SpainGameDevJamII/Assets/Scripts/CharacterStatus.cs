using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterName
{
    Hero,
    Slime
}
[CreateAssetMenu(fileName = "NewCharacter", menuName = "Character")]
public class CharacterStats : ScriptableObject
{
    [SerializeField] new CharacterName name;
    [SerializeField] int health, regularAttackDamage;
    [SerializeField] float buildup, recoil, regularAttackCooldown, runSpeed;

    public string Name => name.ToString();
    public CharacterName RawName => name;
    public int Health => health;
    public int RegularAttackDamage => regularAttackDamage;
    public float Buildup => buildup;
    public float Recoil => recoil;
    public float RegularAttackCooldown => regularAttackCooldown;
    public float RunSpeed => runSpeed;
}
