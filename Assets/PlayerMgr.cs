using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMgr : MonoBehaviour
{

    public float speed;
    int isleft;
    public GameObject direction;
    private GameObject gameMgrObj;
    private NPCManager npcMgr;
    private GameManager gameMgr;

    public GameObject bullet;
    public Transform spawnPoint;

    private float fireCounter = 0;
    public float fireTime = 1.4f;


    // Start is called before the first frame update
    void Start(){
        gameMgrObj = GameObject.FindGameObjectWithTag("GameController");
        gameMgr = (GameManager)gameMgrObj.GetComponent(typeof(GameManager));
        npcMgr = (NPCManager)gameMgrObj.GetComponent(typeof(NPCManager));

        speed = gameMgr.rotationSpeed;

        isleft = 1;
    }

    void FixedUpdate()
    {
        if (!npcMgr.freeze)
        {
            transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime * isleft));
            /*
            fireCounter += Time.deltaTime;
            if (fireCounter >= fireTime)
            {
                fireCounter = 0;
                Invoke("LaunchProjectile", 0.1f);
            }
            */
        }
    }

    public void LaunchProjectile()
    {
        GameObject instBullet = Instantiate(bullet, spawnPoint.position, transform.rotation) as GameObject;
    }

    public void ChangeDirection()
    {
        isleft *= -1;
        direction.gameObject.transform.Rotate(0, 180, 0);
    }
}
