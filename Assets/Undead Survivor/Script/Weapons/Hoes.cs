using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Hoes : MonoBehaviour
{
    [SerializeField]
    private GameObject myPrefab;
    private string myName;
    private float cooltime;
    private float myLevel;
    private bool myState;

    

    private void Awake()
    {
        myName = "Hoes";
        cooltime = 5;
    }

    private void Start()
    {
        PlayerManager.Instance.weapons.OnWeaponLevelUp.AddListener(LevelUp);
        myLevel = PlayerManager.Instance.weapons.GetLevel(myName);
        StartCoroutine(Attack());
    }

    private void LevelUp() // 레벨업 리스너 함수
    {
        if (PlayerManager.Instance.weapons.GetLevel(myName) != myLevel) 
            PlayerManager.Instance.weapons.GetLevel(myName);
    }

    private IEnumerator Attack()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(cooltime - (myLevel / 2));
            GameObject hoe = Instantiate(myPrefab);
            hoe.transform.position = transform.position;
        }
    }
}
