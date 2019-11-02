using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float movementSpeed;
    // Start is called before the first frame update
    private GameObject gameMgrObj;
    private GameManager gameMgr;

    private void Start()
    {
        gameMgrObj = GameObject.FindGameObjectWithTag("GameController");
        gameMgr = (GameManager)gameMgrObj.GetComponent(typeof(GameManager));

        movementSpeed = gameMgr.projectileSpeed;
    }
    void Update()
    {
        transform.position += -movementSpeed * transform.right * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

   
}
