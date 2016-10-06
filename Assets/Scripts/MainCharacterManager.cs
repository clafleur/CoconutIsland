using UnityEngine;
using System.Collections;

public class MainCharacterManager : MonoBehaviour {

    //Invoke this to Respawn MainCharacter
    void ReSpawn() {
        //reposition the character
        transform.position = transform.parent.position;

        //Rotate the main character
        transform.rotation = transform.parent.rotation;
    }
}
