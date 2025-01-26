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
