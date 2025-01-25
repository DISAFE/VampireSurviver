using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TerrainTools;
using UnityEngine.UIElements;

public class Shovels : MonoBehaviour
{
    [SerializeField]
    private GameObject myPrefab;
    private GameObject[] prefabList;
    private float[] prefabAngleList;
    private string myName;
    private int myLevel;
    
    private void Awake()
    {
        myName = "Shovels";
    }
    private void Start()
    {
        PlayerManager.Instance.OnWeaponLevelUp.AddListener(LevelUp);
        myLevel = PlayerManager.Instance.GetLevel(myName);
        Batch();
    }
    private void FixedUpdate()
    {
        transform.position = PlayerManager.Instance.player.transform.position;
        Paint();
    }

    private void LevelUp() // 레벨업 리스너 함수
    {
        if (PlayerManager.Instance.GetLevel(myName) != myLevel) Batch();
    }

    private void Paint()
    {
        for (int i = 0; i < myLevel; i++)
        {
            prefabAngleList[i] += 2f;
            prefabList[i].transform.localPosition = (new Vector3(-Mathf.Sin(prefabAngleList[i] * Mathf.Deg2Rad), Mathf.Cos(prefabAngleList[i] * Mathf.Deg2Rad), 0)) * 1.5f;
            prefabList[i].transform.rotation = Quaternion.Euler(0, 0, prefabAngleList[i]);
        }
    }
    private void Batch()
    {
        if (myLevel == 0) return;
        prefabList = new GameObject[myLevel];
        prefabAngleList = new float[myLevel];
        for (int i = 0; i < myLevel; i++)
        {
            Debug.Log("batch");
            prefabAngleList[i] = 360 * i / myLevel;
            prefabList[i] = Instantiate(myPrefab);
            prefabList[i].transform.SetParent(transform, false);
            prefabList[i].transform.rotation = Quaternion.Euler(0, 0, prefabAngleList[i]);
            prefabList[i].transform.localPosition += (new Vector3(-Mathf.Sin(prefabAngleList[i] * Mathf.Deg2Rad), Mathf.Cos(prefabAngleList[i] * Mathf.Deg2Rad), 0)) * 1.5f;
        }
    }
}
