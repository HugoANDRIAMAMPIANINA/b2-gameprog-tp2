using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsMovement : MonoBehaviour
{
    void Update()
    {
        Vector2 movement = new Vector2(-1, 0);
        transform.Translate(movement * (Time.deltaTime * 8));
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
