using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 4f;
    public Transform teleportLocation;
    private bool hasReachedTarget = false;
    private float timer = 0f;
    private float accelerationInterval = 5f;

        void Update()
    {
        timer += Time.deltaTime;

        if (!hasReachedTarget)
        {
            Vector3 newPosition = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            transform.position = newPosition;

            if (transform.position == target.position)
            {
                hasReachedTarget = false;
                timer = 0f;

                transform.position = teleportLocation.position;
            }
        }

        if (timer >= accelerationInterval)
        {
            speed += Random.Range(3f, 4f);
            timer = 0f;
        }
    }

}