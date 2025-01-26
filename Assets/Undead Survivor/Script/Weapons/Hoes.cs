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
        cooltime = 9;
    }

    private void Start()
    {
        myLevel = PlayerManager.Instance.weapons.GetLevel(myName);
        myState = true;
        StartCoroutine(Attack());
    }

    private void GetState() // ������ ���� �ٲ� �� ���¸� �������� �Լ� 
    {

    }

    private IEnumerator Attack()
    {
        while (myState)
        {
            yield return new WaitForSecondsRealtime(cooltime - myLevel);
            GameObject hoe = Instantiate(myPrefab);
            hoe.transform.localScale = new Vector3(myLevel, myLevel, 0);
            hoe.transform.position = transform.position;
        }
    }
}
