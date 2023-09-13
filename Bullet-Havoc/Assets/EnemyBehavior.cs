using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject player;
    public GameObject frontNode;
    public GameObject bottomNode;
    public GameObject backNode;
    public GameObject topNode;
    public float activeEnemySpeed;
    public float enemySpeed;

    private float distance;

    public LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        activeEnemySpeed = enemySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        if (distance > 4)
        {
            activeEnemySpeed = enemySpeed;
            //Allows enemy to follow player
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, activeEnemySpeed * Time.deltaTime);
        }
        else
        {
            activeEnemySpeed = 5;
            transform.position = Vector2.MoveTowards(this.transform.position, backNode.transform.position, activeEnemySpeed * Time.deltaTime);
        }


        /*
        void DrawCircle(int steps, float radius)
        {
            lr.positionCount = steps;

            for(int currentStep = 0; currentStep < steps; ++currentStep)
            {
                float circumferenceProgress = (float)currentStep / steps;

                float currentRadian = circumferenceProgress * 2 * Mathf.PI ;


            }
        }*/
    }
}
