using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   
    public GameObject bullet;
    public Transform spawnPoint;
   
    private float fireCounter = 0;
    public float fireTime = 1.4f;


    // Start is called before the first frame update
    void Start()
    {
       //Invoke("LaunchProjectile",1f) ;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        fireCounter += Time.deltaTime;
            if (fireCounter >= fireTime)
            {
            fireCounter = 0;
                Invoke("LaunchProjectile", 0.1f);
            }
      
    }
    void LaunchProjectile()
    {
        
       GameObject instBullet = Instantiate(bullet, spawnPoint.position, transform.rotation) as GameObject ;
        
       
    }
}
