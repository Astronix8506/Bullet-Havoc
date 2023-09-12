using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject player;
    public float activeEnemySpeed;
    public float enemySpeed;
    public float enemyNumber;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        enemySpeed = enemySpeed*Mathf.Pow(0.97f,enemyNumber);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, Input.mousePosition.normalized);
        Vector2 direction = Input.mousePosition.normalized - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, Input.mousePosition.normalized, enemySpeed * Time.deltaTime);
    }
}
