using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFreeze : MonoBehaviour


{
    MonsterControl MC;
    public MonstersSpawnerControl MSC;
    GameObject[] monsters;



    //public void FreezAndStop()
    //{
        
    //    monsters = GameObject.FindGameObjectsWithTag ("Enemy");
    //    MSC.StopSpwan();
    //    foreach(GameObject m in monsters)
    //    {
    //        MC = m.GetComponent<MonsterControl>();
    //        MC.Freezing();
    //    }
    //    //MSC.StartSpwan();
    //    StartCoroutine(SpawnCunt());

    //}

    //IEnumerator SpawnCunt()
    //{
       
    //    yield return new WaitForSeconds(3f);

    //    MSC.StartSpwan();
    //    yield return null;
    //}
}
