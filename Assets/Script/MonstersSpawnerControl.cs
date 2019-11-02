using UnityEngine;

public class MonstersSpawnerControl : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject[] monsters;
	int randomSpawnPoint, randomMonster;
	public static bool spawnAllowed;
    public GameObject target;
    public ScoreManager SM;
    float score;
    public float wait;
    float spawn;
    bool spawnAllowed1;
 
    private float cycleCounter = 0;
    public float cycleTime;

    private GameObject gameMgr;
    private NPCManager npcMgr;

    // Use this for initialization
    void Start () {
        gameMgr = GameObject.FindGameObjectWithTag("GameController");
        npcMgr = (NPCManager)gameMgr.GetComponent(typeof(NPCManager));



        spawn = 1;
        wait = 3f;
        SM = target.GetComponent<ScoreManager>();
        score = SM.pointsCount + 1;
        
        spawnAllowed1 = true;
        


        //StartCoroutine(SpawnGrow());
	}
  
    private void FixedUpdate()
    {
        score = SM.pointsCount + 1;

        spawnAllowed1 = !npcMgr.freeze;
        Debug.Log("Spawn allowed: " + spawnAllowed1);
        if (spawnAllowed1){
            cycleCounter += Time.deltaTime;
            if (cycleCounter >= cycleTime)
            {
                cycleCounter = 0;
                Invoke("SpawnAMonster", 0.1f);
            }
        }
        //by time spawn grow and stop at 1
        if (cycleTime <= 1f)
        {
            cycleTime = 1f;
        }
        else
        {
            cycleTime -= 0.0003f;
        }
        
    }

    public void StopSpwan()
    {
        spawnAllowed1 = false;
        Debug.Log("false");
    }
    public void StartSpwan()
    {
        spawnAllowed1 = true;
        Debug.Log("true");
    }
  

	void SpawnAMonster()
	{
        Debug.Log("Spawn");
			randomSpawnPoint = Random.Range (0, spawnPoints.Length);
			randomMonster = Random.Range (0, monsters.Length);

       
            Instantiate(monsters[randomMonster], spawnPoints[randomSpawnPoint].position,
                Quaternion.identity);
        
        
    }

}
