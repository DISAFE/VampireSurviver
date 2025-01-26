using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Events;


/*
�� Ŭ������ ������ �⺻���� ����, ���� ���ڸ� ������ Ȱ��ȭ ��������� ������ ������ �ٷ�ϴ�.

 */
public class Weapons : MonoBehaviour
{
    private Dictionary<string, int> weaponLevel = new()
        {
            {"Shovels", 5},
            {"Hoes", 6},
            {"Rakes", 1},
            {"Rifle", 0},
            {"Pistol", 0},
            {"Shotgun", 0},
        };
    public UnityEvent OnWeaponLevelUp = new();

   /* public void Start()
    {
        foreach(Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }*/
    public void WeaponLevelUp(string weaponName)
    {
        if (weaponLevel[weaponName] == 8) return;
        weaponLevel[weaponName] += 1;
        OnWeaponLevelUp.Invoke();
    }

    public int GetLevel(string name) => weaponLevel[name];

    public Vector3 GetNearestEnemyPos() => new Vector3(0, 0, 0); // �ٲ�� ��
}
