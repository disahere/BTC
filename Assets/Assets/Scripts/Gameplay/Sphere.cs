using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public float speed = 5f;
    public float delay = 0.5f;
    public KeyCode key = KeyCode.Space;

    private Coroutine currentCoroutine;
    private Vector3 direction = Vector3.up;

    private void Update()
    {
        if (Input.GetKeyDown(key))
        {
            direction = -direction;
            if (currentCoroutine != null)
            {
                StopCoroutine(currentCoroutine);
            }
            currentCoroutine = StartCoroutine(MoveToTarget(transform.position + direction * 10));
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            MoveToTarget(target1.position);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MoveToTarget(target2.position);
        }
    }

    private IEnumerator MoveToTarget(Vector3 targetPosition)
    {
        if (targetPosition == null)
        {
            Debug.LogError("Позиция не может быть нулевой");
            yield break;
        }
        if (speed == 0)
        {
            Debug.LogError("Скорость не может быть нулевой");
            yield break;
        }
        yield return new WaitForSeconds(delay);

        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
            yield return null;
        }

        currentCoroutine = null;
    }
}