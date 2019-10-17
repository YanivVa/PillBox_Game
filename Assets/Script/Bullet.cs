using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float movementSpeed = 0.2f;
    // Start is called before the first frame update

    
    private void Start()
    {
       
    }
    void Update()
    {
       

        transform.position += -1*transform.right * Time.deltaTime ;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

   
}
