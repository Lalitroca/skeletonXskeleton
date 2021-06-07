using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName="newCharacter")]
public class CharacterData : ScriptableObject
{
    public CharacterOptions characterTag;
    public int baseHealth;
    public SpawnPolls.Spawnables weapon;
    public float baseSpeed;
    public float runningSpeed;
    public float jumpForce;
    public int pointWorth;
    public enum CharacterOptions {player, warrior, mage}
}
