using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Des : MonoBehaviour {
    public float BloodlifeTime=5;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, BloodlifeTime);
	}
}
