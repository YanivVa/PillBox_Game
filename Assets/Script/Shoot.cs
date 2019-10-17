using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   
    public GameObject bullet;
    public Transform spawnPoint;
    public float shootTime;
    public float speed = 100f;
    float firerate = 1.4f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchProjectile", 2.0f, firerate);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    void LaunchProjectile()
    {
        
       GameObject instBullet = Instantiate(bullet, spawnPoint.position, transform.rotation) as GameObject ;
        
       
    }
}
