using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


/*
�� Ŭ������ ������ �⺻���� ����, ���� ���ڸ� ������ Ȱ��ȭ ��������� ������ ������ �ٷ�ϴ�.

 */
public class Weapons : MonoBehaviour
{
    public Dictionary<string, int> weaponLevel = new()
        {
            {"Shovels", 5},
            {"Hoes", 0},
            {"Rakes", 0},
            {"Rifle", 0},
            {"Pistol", 0},
            {"Shotgun", 0},
        };
    public UnityEvent OnWeaponLevelUp = new();
    private string chosenGun;    private string chosenKnife;


    public void WeaponLevelUp(string weaponName)
    {
        if (weaponLevel[weaponName] == 8) return;
        weaponLevel[weaponName] += 1;
        OnWeaponLevelUp.Invoke();
    }

    public int GetLevel(string name) => weaponLevel[name];
}
