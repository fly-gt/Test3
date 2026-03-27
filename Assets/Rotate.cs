using UnityEngine;

public class Rotate : MonoBehaviour {
    [SerializeField] private Vector3 rotate;
    [SerializeField] private float speed;

    void Update() {
        transform.Rotate(rotate * speed * Time.deltaTime);
    }
}
