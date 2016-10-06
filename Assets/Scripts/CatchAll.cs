using UnityEngine;
using System.Collections;

public class CatchAll : MonoBehaviour {

    void OnTriggerEnter(Collider a_other) {
        if (Literals.MainCharacter == a_other.gameObject.tag)
        {
            a_other.gameObject.SendMessage(Literals.ReSpawn, SendMessageOptions.RequireReceiver);
            return;
        }

        Destroy(a_other.gameObject);

    }
}
