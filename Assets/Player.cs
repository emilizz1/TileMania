using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    [SerializeField] float runSpeed = 5f;

    Rigidbody2D myRigidbody;

	void Start ()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        Run();
        FlipSprite();

    }

    void Run()
    {
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        myRigidbody.velocity = new Vector2(controlThrow * runSpeed, myRigidbody.velocity.y);
    }

    void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;
        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2( Mathf.Sign(myRigidbody.velocity.x), transform.localScale.y);
        }
    }
}
