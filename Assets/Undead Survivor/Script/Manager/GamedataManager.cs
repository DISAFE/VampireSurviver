using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    �� Ŭ������ �Һ����� ���� �����͸� �����մϴ�.
 */
public class GamedataManager : MonoBehaviour
{
    public static GamedataManager Instance;
    public Vector2 normalSize;

    private void Awake()
    {
        Instance = this;
        normalSize = new Vector2(50, 40);
    }
}
