using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

/*
 * �� Ŭ������ �÷��̾� ����� �����͸� �����ϴ�.
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
