using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -15;
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
