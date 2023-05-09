using UnityEngine;

/**
 * This component just rotates its object between angular bounds.
 */
public class ToBlue : MonoBehaviour {


    void Update() {
            GetComponent<Renderer>().material.color = Color.blue;
    }
}
