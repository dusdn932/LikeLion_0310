using UnityEditor.SceneManagement;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy_small;
    public GameObject enemy_boss;
    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f);
        Instantiate(enemy_small, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
    }
    void SpawnEnemy1()
    {
        float randomX = Random.Range(-2f, 2f);
        Instantiate(enemy_boss, new Vector3(0, transform.position.y, 0f), Quaternion.identity);
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.0f, 0.9f);
        SpawnEnemy1();

        /*        if (GameManager.intance.Stage_ONE)
                {

                }
                else if (GameManager.intance.StageName == "Stage_Second")
                {
                    
                }*/
    }

    void Update()
    {
        
    }
}
