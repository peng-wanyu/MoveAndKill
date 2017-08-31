using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCtrl : MonoBehaviour {
    public Transform player;
    public float rotSpeed;
    public Vector3 vc;
    public GameObject blood;
	// Use this for initialization
	void Start () {
        player = LevelManager.lm.player;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targrtDir = player.position - transform.position;
        float step = rotSpeed * Time.deltaTime;
        Vector3 newOir = Vector3.RotateTowards(transform.forward, targrtDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newOir);
        transform.Translate(Vector3.forward * Time.deltaTime * 8);
	}
    public void Hurt(){
        Destroy(gameObject);
        Instantiate(blood, transform.position, Quaternion.identity);

    }
}
