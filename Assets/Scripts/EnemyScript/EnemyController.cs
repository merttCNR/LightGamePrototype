using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemyManager enemyManager;
    Rigidbody2D enemyRb;
    private float enemySpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        enemyManager = GameObject.Find("spawnPos(x14)").GetComponent<EnemyManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        EnemyMove();
    }
    private void EnemyMove(){
        enemyRb.velocity = Vector2.left * enemySpeed * Time.deltaTime;
    }
}
