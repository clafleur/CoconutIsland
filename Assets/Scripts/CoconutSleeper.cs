using UnityEngine;
using System.Collections;

public class CoconutSleeper : MonoBehaviour {

    public float sleepMagnitude = 1.0f;
    public float startCheckingInSeconds = 2.5f;
    public float checkEverySeconds = 1.0f;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        StartCoroutine(GoToSleep());
        rb = GetComponent<Rigidbody>();
	}

    IEnumerator GoToSleep() {
        yield return new WaitForSeconds(startCheckingInSeconds);
        while (rb.angularVelocity.magnitude > sleepMagnitude || 
                rb.velocity.magnitude > sleepMagnitude)
        {
            yield return new WaitForSeconds(checkEverySeconds);
        }

        rb.angularVelocity = Vector3.zero;
        rb.velocity = Vector3.zero;
        rb.Sleep();
    }

}
