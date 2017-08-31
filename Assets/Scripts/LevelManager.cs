using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    static public LevelManager lm;
    public Transform player;
    public GameObject enemy;
    public float rateTime = 2;
    float myTime;
	void Awake () {
        lm = this;
	}
	
	// Update is called once per frame
	void Update () {
        myTime += Time.deltaTime;
        if (myTime > rateTime) {
            Vector2 r = Random.insideUnitCircle * 20;
            Vector2 f = Random.insideUnitCircle;
            Instantiate(enemy,new Vector3(r.x,0,r.y),Quaternion.identity);
            myTime -= rateTime;
        }
		
	}
}
