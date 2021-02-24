using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    private uiscript controllerScript;
    // Start is called before the first frame update
    void Start()
    {
        controllerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<uiscript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            GetComponent<AudioSource> ().Play();
            controllerScript.updateScore(1);
            Destroy(gameObject, 1.0f);
        }
    }
}