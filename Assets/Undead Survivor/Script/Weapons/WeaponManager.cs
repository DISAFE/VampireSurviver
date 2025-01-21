using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // 플레이어의 무기 레벨을 저장하는 Dictionary
    public Dictionary<string, int> PlayerWeaponsLevel;

    private void Awake()
    {
        _PlayerWeaponsLevel();
    }

    // WeaponsLevel을 초기화하는 인스턴스
    void _PlayerWeaponsLevel()
    {
        foreach (string weaponName in GameManager.Instance.Weapons)
        {
            PlayerWeaponsLevel.Add(weaponName, 0);
        }
    }
    
    public void LevelUp(string weaponName)
    {
        PlayerWeaponsLevel[weaponName] += PlayerWeaponsLevel[weaponName] >= 8 ? 0 : 1; // 8레벨이 한계
    }
}
