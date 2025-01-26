using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Events;


/*
이 클래스는 무기의 기본적인 설정, 예를 들자면 무기의 활성화 유무라던지 레벨업 관리를 다룹니다.

 */
public class Weapons : MonoBehaviour
{
    private Dictionary<string, int> weaponLevel = new()
        {
            {"Shovels", 1},
            {"Hoes", 6},
            {"Rakes", 5},
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

    public Vector3 GetNearestEnemyPos()
    {
        Collider2D[] enemies = PlayerManager.Instance.EnemiesInScreen();
        if (enemies.Length == 0) return Vector3.zero; // 오류 핸들링

        Collider2D nearestEnemy = enemies[0];
        float nearestDistance = Vector2.Distance(PlayerManager.Instance.player.transform.position, nearestEnemy.transform.position);

        foreach (Collider2D enemy in enemies)
        {
            float enemyDistance = Vector2.Distance(PlayerManager.Instance.player.transform.position, enemy.transform.position);
            if (nearestDistance > enemyDistance)
            {
                nearestDistance = enemyDistance;
                nearestEnemy = enemy;
            }
        }
        return nearestEnemy.transform.position;
    }
}
