using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cycle : MonoBehaviour
{

    public float speed = 50f;
    int isleft;
    public GameObject direction;
    private GameObject gameMgr;
    private NPCManager npcMgr;
    // Start is called before the first frame update
    void Start()
    {
        gameMgr = GameObject.FindGameObjectWithTag("GameController");
        npcMgr = (NPCManager)gameMgr.GetComponent(typeof(NPCManager));

        isleft = 1;
      
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!npcMgr.freeze)
        {
            transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime * isleft));
        }
    }

    public void ChangeDirection()
    {
        isleft *= -1;
        direction.gameObject.transform.Rotate(0, 180, 0);
    }
}
