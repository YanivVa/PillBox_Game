using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{

    public GameObject[] npcPrefabs;
    public float npcSpawnRate = 3;
    float spawnCounter = 0;
    float xAnchor = 11;
    float yAnchor = 6;
    public GameObject powerUpsPanel;
    public bool freeze = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private Vector3 randomizeSpawnPoint()
    {
        bool xMainAnchor = (Random.Range(0, 2) == 0) ? true : false ;

        if (xMainAnchor)
        {
            float ySpawnPoint = Random.Range(-yAnchor, yAnchor);
            if (Random.Range(0, 2) == 0)
            {
                // right side
                return new Vector3(xAnchor, ySpawnPoint, 0);
            } else
            {
                // left side
                return new Vector3(-xAnchor, ySpawnPoint, 0);
            }
        } else
        {
            float xSpawnPoint = Random.Range(-xAnchor, xAnchor);
            if (Random.Range(0, 2) == 0)
            {
                // up side
                return new Vector3(xSpawnPoint, yAnchor, 0);
            }
            else
            {
                // down side
                return new Vector3(xSpawnPoint, -yAnchor, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnCounter += Time.deltaTime;
        if (spawnCounter >= npcSpawnRate && !freeze)
        {
            spawnCounter = 0;
            int randomNpcIndex = Random.Range (0, npcPrefabs.Length);
            Vector3 randomizedSpawnPoint = randomizeSpawnPoint();
            GameObject npc = Instantiate(npcPrefabs[randomNpcIndex], randomizedSpawnPoint, Quaternion.identity) as GameObject;
            //npc.transform.SetParent(GameObject.FindGameObjectWithTag("GameplayCanvas").transform, false);
        }
    }


    public void freezeNpcs()
    {
        powerUpsPanel.SetActive(!freeze);
        freeze = !freeze;
        GameObject[] npcs = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject npc in npcs)
        {
            MonsterControl MC = (MonsterControl)npc.GetComponent(typeof(MonsterControl));
            MC.freezeNpc();
        }
        //MSC.StartSpwan();
        //StartCoroutine(SpawnCunt());

    }

}
