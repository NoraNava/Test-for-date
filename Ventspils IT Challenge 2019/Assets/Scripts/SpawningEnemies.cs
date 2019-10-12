using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawningEnemies : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    float randX, randY;
    float randx, randy;
    Vector3 wheretospawn, wheretospawn2;
    public float spawnrate = 15f;
    float nextSpawn = 0.0f;
    public int rand;

    public void Start()
    {
        randx = Random.Range(-2171 + 900, 2171 - 900);
        randy = Random.Range(-1090 + 450, 1090 - 450);
        wheretospawn2 = new Vector3(randx, randy, 0);
        Instantiate(enemies[5], wheretospawn2, Quaternion.identity, GameObject.Find("MobSpawner").transform);
    }

    void FixedUpdate()
    {
        rand = Random.Range(0,4);
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnrate;
            randX = Random.Range(-2171 + 900, 2171 - 900);
            randY = Random.Range(-1090 + 450, 1090 - 450);
            wheretospawn = new Vector3(randX, randY, 0);

            Instantiate(enemies[rand], wheretospawn, Quaternion.identity, GameObject.Find("MobSpawner").transform);
        }
    }
}
