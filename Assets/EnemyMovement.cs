using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

    Rigidbody2D myrigidbody;

	void Start ()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        if (IsFacingRight())
        {
            myrigidbody.velocity = new Vector2(moveSpeed, 0f);
        }
        else
        {
            myrigidbody.velocity = new Vector2(-moveSpeed, 0f);
        }
	}

    bool IsFacingRight()
    {
        return transform.localScale.x > 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-Mathf.Sign(myrigidbody.velocity.x), 1f);
    }
}
