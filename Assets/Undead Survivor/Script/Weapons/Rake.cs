using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rake : MonoBehaviour
{
    private Vector3 randomPos;
    private float angle;
    private float wait;
    private float speed;
    private float damage;
    // Start is called before the first frame update
    private void Awake()
    {
        damage = 10;
        speed = 15;
        angle = 0;
        wait = 2;
        SetRandomPos();
    }
    private void Start()
    {
        transform.position = randomPos;
        Debug.Log(randomPos);
        StartCoroutine(DestoryWait());
    }
    private void FixedUpdate()
    {
        angle -= speed;
        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }

    private IEnumerator DestoryWait()
    {
        yield return new WaitForSecondsRealtime(wait);
        Destroy(this.gameObject);
    }

    private void SetRandomPos()
    {
        float x = Random.Range(0.2f, 0.8f);
        float y = Random.Range(0.2f, 0.8f);
        randomPos = Camera.main.ViewportToWorldPoint(new Vector3(x, y, 0));
        randomPos.z = 0;
    }

}
