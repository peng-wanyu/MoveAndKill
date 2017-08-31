using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxAmin : MonoBehaviour {
    public AnimationCurve AC;
    Vector3 s;
    float playSpeed = 3;
    float timeOffset = 0;
	// Use this for initialization
	void Start () {
        s = transform.localScale;
        timeOffset = Random.value;
	}
	
	// Update is called once per frame
	void Update () {
        timeOffset += Time.deltaTime;
        float r = AC.Evaluate(timeOffset*playSpeed);
        transform.localScale = new Vector3(s.x, s.y * r, s.z);
	}
}
