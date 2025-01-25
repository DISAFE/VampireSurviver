using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoes : MonoBehaviour
{
    [SerializeField]
    private GameObject myPrefab;
    private string myName;
    private float myLevel;
    

    private void Awake()
    {
        myName = "Hoes";
    }

    private void Start()
    {
        myLevel = PlayerManager.Instance.playerWeapons.GetLevel(myName);

    }

    private void Attack()
    {

    }
}
