using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MonsterControl : MonoBehaviour {

    public ScoreManager SM;
    Rigidbody2D rb;
	public GameObject target;
	float moveSpeed;
	Vector3 directionToTarget;
	public GameObject explosion;
    public AdShow ad;
    public bool freez;

	// Use this for initialization
	void Start () {
        freez = true;
        target = GameObject.Find("Player");
        SM = target.GetComponent<ScoreManager>();
        rb = GetComponent<Rigidbody2D> ();
		moveSpeed = Random.Range (0.1f, 0.3f);
        ad = target.GetComponent<AdShow>();
	}
	
	// Update is called once per frame
	void Update () {
		MoveMonster ();
	}

	void OnTriggerEnter2D (Collider2D col)
	{
        
        switch (col.gameObject.tag) {
           
		case "Player":
                
			MonstersSpawnerControl.spawnAllowed = false;
            GameObject exp1=Instantiate(explosion, col.gameObject.transform.position, Quaternion.identity) as GameObject;
			Destroy (col.gameObject);
			target = null;
                Destroy(exp1, 0.5f);
                Invoke("BackMain",3f);
                break;

		case "Bullet":
			GameObject exp2= Instantiate (explosion, transform.position, Quaternion.identity) as GameObject;
                
                SM.AddScore(1);
			Destroy (col.gameObject);
			Destroy (gameObject);
                Destroy(exp2, 0.5f);
                break;
		}
	}
  
	void MoveMonster ()
	{
		if (target != null && (freez)) {
			directionToTarget = (target.transform.position - transform.position).normalized;
			rb.velocity = new Vector2 (directionToTarget.x * moveSpeed,
										directionToTarget.y * moveSpeed);
		}
		else
			rb.velocity = Vector3.zero;
	}

    void BackMain()
    {
        ad.Adshower();
        SceneManager.LoadScene("Opening", LoadSceneMode.Single);
    }


    // frezzing function
    /*public void Freezing()
    {
        StartCoroutine(freezed());

    }

    IEnumerator freezed()
    {

        freez = false;
        yield return new WaitForSeconds(3f);
        freez = true;

        yield return null;
    }
    // frezzing function end //
    */

    public void Freezing()
    {
        freez = false;
        Invoke("count", 3f);
    }

    public void count()
    {
        freez = true;
    }
}
