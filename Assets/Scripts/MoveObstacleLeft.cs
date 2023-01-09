using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacleLeft : MonoBehaviour
{
    public float speed = 15f;


    // hará que el obstaculo se mueva hacia la izquierda
    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
