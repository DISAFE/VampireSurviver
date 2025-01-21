using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // �÷��̾��� ���� ������ �����ϴ� Dictionary
    public Dictionary<string, int> PlayerWeaponsLevel;

    private void Awake()
    {
        _PlayerWeaponsLevel();
    }

    // WeaponsLevel�� �ʱ�ȭ�ϴ� �ν��Ͻ�
    void _PlayerWeaponsLevel()
    {
        foreach (string weaponName in GameManager.Instance.Weapons)
        {
            PlayerWeaponsLevel.Add(weaponName, 0);
        }
    }
    
    public void LevelUp(string weaponName)
    {
        PlayerWeaponsLevel[weaponName] += PlayerWeaponsLevel[weaponName] >= 8 ? 0 : 1; // 8������ �Ѱ�
    }
}
