using UnityEngine;

public class ObjectRemover : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y > 5f || transform.position.y < -4.3f)
        {
            Destroy(gameObject);
        }
    }
}
