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
    public GameObject player;
    public bool playerIsDead;
    public Weapons playerWeapons;
    
    private void Awake()
    {
        playerIsDead = false;
        player = GameObject.Find("Player");
        playerWeapons = GameObject.Find("Weapons").GetComponent<Weapons>();
        Instance = this;
        
    }
}
