using UnityEngine;
using System.Collections;

public class CatchAll : MonoBehaviour {

    void OnTriggerEnter(Collider a_other) {

        Destroy(a_other.gameObject);

    }
}
