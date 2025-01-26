using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rakes : MonoBehaviour
{
    [SerializeField]
    private GameObject myPrefab;
    private float cooltime;
    private float delay;
    private string myName;
    private int myLevel;
    

    private void Awake()
    {
        myName = "Rakes";
        cooltime = 5;
        delay = 0.5f;
    }
    // Start is called before the first frame update
    void Start()
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
            yield return new WaitForSecondsRealtime(cooltime);
            for(int i = 0; i < myLevel; i++)
            {
                GameObject rake = Instantiate(myPrefab);           
                yield return new WaitForSecondsRealtime(delay);
            }
        }
    }

}
