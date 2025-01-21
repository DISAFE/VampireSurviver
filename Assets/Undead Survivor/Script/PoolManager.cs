using System.Collections;
using UnityEngine;


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

    void Start()
    {
        StartCoroutine("SpawnMonster1");
        StartCoroutine("SpawnMonster2");
        StartCoroutine("SpawnMonster3");
        StartCoroutine("SpawnMonster4");
    }

    IEnumerator SpawnMonster1()
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

    IEnumerator SpawnMonster2()
    {
        while (!GameManager.Instance.playerIsDead)
        {
            yield return new WaitForSecondsRealtime(2);
            if (GameManager.Instance.gameLevel >= 2)
            {
                int poolIndex = Random.Range(0, pools.Length);
                Instantiate(prefabs[1], pools[poolIndex].transform.position, Quaternion.identity);
            }
        }
    }

    IEnumerator SpawnMonster3()
    {
        while (!GameManager.Instance.playerIsDead)
        {
            yield return new WaitForSecondsRealtime(5);
            if (GameManager.Instance.gameLevel >= 3)
            {
                int poolIndex = Random.Range(0, pools.Length);
                // Instantiate(prefabs[2], pools[poolIndex].transform.position, Quaternion.identity);
            }
        }
    }

    IEnumerator SpawnMonster4()
    {
        while (!GameManager.Instance.playerIsDead)
        {
            yield return new WaitForSecondsRealtime(5);
            if (GameManager.Instance.gameLevel >= 4)
            {
                int poolIndex = Random.Range(0, pools.Length);
                // Instantiate(prefabs[3], pools[poolIndex].transform.position, Quaternion.identity);
            }
        }
    }
    
}
