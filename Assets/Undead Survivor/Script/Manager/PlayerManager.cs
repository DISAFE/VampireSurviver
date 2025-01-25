using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

/*
 * 이 클래스는 플레이어 기반의 데이터를 가집니다.
 */
public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;
    public Dictionary<string, int> weaponLevel = new ()
        {
            {"Shovels", 6},
            {"Hoes", 0},
            {"Rakes", 0},
            {"Rifle", 0},
            {"Pistol", 0},
            {"Shotgun", 0},
        };
    public UnityEvent OnWeaponLevelUp = new ();
    public GameObject player;
    public bool playerIsDead = false;  
    
    private void Awake()
    {
        Instance = this;
        player = GameObject.Find("Player");
    }

    public void WeaponLevelUp(string weaponName)
    {
        if (weaponLevel[weaponName] == 8) return;
        weaponLevel[weaponName] += 1;
        OnWeaponLevelUp.Invoke();
    }

    public int GetLevel(string name) => weaponLevel[name]; 
}
