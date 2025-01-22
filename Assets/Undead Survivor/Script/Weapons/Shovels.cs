using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TerrainTools;
using UnityEngine.UIElements;

public class Shovels : MonoBehaviour
{
    [SerializeField]
    private GameObject myPrefab;
    private string myName = "Shovels";
    private int myLevel;
   

    private void Awake()
    {
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
        //Paint();
    }

    private void LevelUp()
    {
        if (PlayerManager.Instance.GetLevel(myName) != myLevel) Batch();
    }

    private void Paint()
    {

    }
    private void Batch()
    {
        if (myLevel == 0) return;

        for (int i = 0; i < myLevel; i++)
        {
            GameObject newPrefab = Instantiate(myPrefab);
            newPrefab.transform.SetParent(transform, false);
            newPrefab.transform.rotation = Quaternion.Euler(0, 0, 360 * i / myLevel);
            newPrefab.transform.localPosition += new Vector3(0, 1.5f, 0);
        }
        
    }
}
