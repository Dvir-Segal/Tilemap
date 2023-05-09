using UnityEngine;

/**
 * This component just rotates its object between angular bounds.
 */
public class ToRed : MonoBehaviour {


    void Update() {
            GetComponent<Renderer>().material.color = Color.red;
    }
}
