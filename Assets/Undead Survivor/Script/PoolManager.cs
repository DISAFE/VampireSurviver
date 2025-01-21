using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;


/*

PoolManager Ŭ����

�� Ŭ������ ���� ������ ���� ��� ���� �Ѱ��ϴ� Ŭ�����Դϴ�. 

���
    -
���
    - ���� ����. SpawnMonster()
 */

public class PoolManager : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject[] pools;

    private void Start()
    {
        SpawnMonster1();
        SpawnMonster2();
        SpawnMonster3();
        SpawnMonster4();
    }

    IEnumerable SpawnMonster1()
    {
        while (!GameManager.Instance.playerIsDead)
        {
            yield return new WaitForSecondsRealtime(1);
            if (GameManager.Instance.gameLevel >= 1)
            {
                int poolIndex = Random.Range(0, pools.Length);
                Instantiate(prefabs[0], pools[poolIndex].transform.position, Quaternion.identity);
            }
        }
    }

    IEnumerable SpawnMonster2()
    {
        while (!GameManager.Instance.playerIsDead)
        {
            yield return new WaitForSecondsRealtime(2);
            if (GameManager.Instance.gameLevel >= 2)
            {
                int poolIndex = Random.Range(0, pools.Length);
                Instantiate(prefabs[0], pools[poolIndex].transform.position, Quaternion.identity);
            }
        }
    }

    IEnumerable SpawnMonster3()
    {
        while (!GameManager.Instance.playerIsDead)
        {
            yield return new WaitForSecondsRealtime(5);
            if (GameManager.Instance.gameLevel >= 3)
            {
                int poolIndex = Random.Range(0, pools.Length);
                // Instantiate(prefabs[1], pools[poolIndex].transform.position, Quaternion.identity);
            }
        }
    }

    IEnumerable SpawnMonster4()
    {
        while (!GameManager.Instance.playerIsDead)
        {
            yield return new WaitForSecondsRealtime(5);
            if (GameManager.Instance.gameLevel >= 4)
            {
                int poolIndex = Random.Range(0, pools.Length);
                // Instantiate(prefabs[1], pools[poolIndex].transform.position, Quaternion.identity);
            }
        }
    }
}
