using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    �� Ŭ������ ���� ���¸� �����ϴ� �Ŵ����Դϴ�. 
    �ַ� Scene�� �����մϴ�.
 */
public class StateManager : MonoBehaviour
{
    // GameManager �ڱ� �ڽ��� �����ϱ� ���� GameManager
    public static StateManager Instance;

    void Awake()
    {
        Instance = this;
    }
}
