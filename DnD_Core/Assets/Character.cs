using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterAbility { 
    Strength,
    Dexterity,
    Constitution,
    Intelligence,
    Wisdom,
    Charisma

}
[Serializable]
public class Ability
{
    public int abilityScore;
    public CharacterAbility ability;

    public Ability(CharacterAbility ability, int abilityScore)
    {
        this.ability = ability;
        this.abilityScore = abilityScore;
    }
}

[CreateAssetMenu]
public class Character : ScriptableObject
{
    public List<Ability> abilities;

    private void Reset()
    {
        abilities = new List<Ability>();
        abilities.Add(new Ability(CharacterAbility.Strength, 10));
        abilities.Add(new Ability(CharacterAbility.Dexterity, 10));
        abilities.Add(new Ability(CharacterAbility.Constitution, 10));
        abilities.Add(new Ability(CharacterAbility.Intelligence, 10));
        abilities.Add(new Ability(CharacterAbility.Wisdom, 10));
        abilities.Add(new Ability(CharacterAbility.Charisma, 10));
    }
}
