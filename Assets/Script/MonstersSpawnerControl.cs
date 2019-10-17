using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstersSpawnerControl : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject[] monsters;
	int randomSpawnPoint, randomMonster;
	public static bool spawnAllowed;
    public GameObject target;
    public ScoreManager SM;
    float score;
    float wait;
    float spawn;
	// Use this for initialization
	void Start () {
        spawn = 1;
        wait = 3f;
        SM = target.GetComponent<ScoreManager>();
        score = SM.pointsCount + 1;
        spawnAllowed = true;
        
        StartCoroutine(SpawnGrow());
	}
    private void Update()
    {
        score = SM.pointsCount + 1;
        
    }


    IEnumerator SpawnGrow()
    {
        while (spawnAllowed)
        {
            
            Invoke("SpawnAMonster",0.1f);
            
            yield return new WaitForSeconds(wait);

        }

        yield return null;
    }

	void SpawnAMonster()
	{
       
			randomSpawnPoint = Random.Range (0, spawnPoints.Length);
			randomMonster = Random.Range (0, monsters.Length);
			Instantiate (monsters [randomMonster], spawnPoints [randomSpawnPoint].position,
				Quaternion.identity);
        if (wait < 1)
        {
            wait = 1.3f;
        }
        else
        {
            wait -= 0.03f;

        }
        spawn += 1;
    }

}
