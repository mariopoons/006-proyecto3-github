using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 9f;

    private Rigidbody _rigidbody;
    private bool isOnTheGround = true;
    

    private void Start()
    {
        // hace una fuerza que impulsa el gameobject hacia arriba

        // el getcomponent lo que hace es coger los datos de la componente que se le ascie
        _rigidbody = GetComponent<Rigidbody>();
        // _rigidbody.AddForce(Vector3.up * 9, ForceMode.Impulse);
    }

    private void Update()
    {
        /* hará que el impulso se haga efectivo cuando pulsemos la tecla espacio y solo funcionará si el personaje
        está en el suelo */
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround)
        {
            isOnTheGround = false;
            // _rigidbody.AddForce(Vector3.up * 9, ForceMode.Impulse);
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
        }
    }

    // si el player esta en el suelo, podrá saltar, si no lo está, no podrá saltar.
    private void OnCollisionEnter(Collision otherCollider)
    {
        isOnTheGround = true;
    }
}
