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
    public Weapons weapons;
    public GameObject player;
    public bool playerIsDead;
    
    
    private void Awake()
    {
        playerIsDead = false;
        player = GameObject.Find("Player");
        weapons = GameObject.Find("Weapons").GetComponent<Weapons>();
        Instance = this;
        
    }
}
