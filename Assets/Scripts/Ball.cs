using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter(Collider coll) {
        if (coll.tag == "Enemy") {
            coll.GetComponent<FCtrl> ().Hurt ();
        }
    }
}
