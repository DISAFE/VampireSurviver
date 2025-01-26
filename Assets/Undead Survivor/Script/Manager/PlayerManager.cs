using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
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

    public Collider2D[] EnemiesInScreen()
    {
        Vector2 leftBottom = Camera.main.ViewportToWorldPoint(Vector2.zero);
        Vector2 rightTop = Camera.main.ViewportToWorldPoint(Vector2.right + Vector2.up);
        Vector2 center = player.transform.position;
        Collider2D[] enemies = Physics2D.OverlapBoxAll(center, rightTop - leftBottom, 0, 1 << 6);
        return enemies;
    }


    
    
}
