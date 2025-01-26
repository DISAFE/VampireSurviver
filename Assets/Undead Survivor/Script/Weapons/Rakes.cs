using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rakes : MonoBehaviour
{
    [SerializeField]
    private GameObject myPrefab;
    private float cooltime;
    private string myName;
    private int myLevel;
    

    private void Awake()
    {
        myName = "Rakes";
        cooltime = 5;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack());

        myLevel = PlayerManager.Instance.weapons.GetLevel(myName);
    }

    private IEnumerator Attack()
    {
        while (true)
        {
            yield return new WaitForSeconds(cooltime);
            for(int i = 0; i < myLevel; i++)
            {
                GameObject rake = Instantiate(myPrefab);
                rake.transform.localScale = Vector3.one * 2;
                rake.transform.localPosition += Vector3.up * 1.5f;
                yield return new WaitForSeconds(0.5f);
            }
        }
    }

}
