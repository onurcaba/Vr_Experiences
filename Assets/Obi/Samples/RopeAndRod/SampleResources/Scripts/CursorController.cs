using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Obi;

[RequireComponent(typeof(ObiRope))]
public class CursorController : MonoBehaviour
{

	ObiRopeCursor cursor;
	ObiRope rope;
	public float minLength = 0.1f;
    public float speed = 1;

	// Use this for initialization
	void Start ()
    {
        rope = GetComponent<ObiRope>();
        cursor = GetComponent<ObiRopeCursor>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Keyboard.current[Key.W].IsPressed() && cursor != null)
        {
            if (rope.restLength > minLength)
                cursor.ChangeLength(rope.restLength - speed * Time.deltaTime);
		}

		if (Keyboard.current[Key.S].IsPressed() && cursor != null)
        {
            cursor.ChangeLength(rope.restLength + speed * Time.deltaTime);
		}

		if (Keyboard.current[Key.A].IsPressed())
		{
			rope.transform.Translate(Vector3.left * Time.deltaTime,Space.World);
		}

		if (Keyboard.current[Key.D].IsPressed())
		{
			rope.transform.Translate(Vector3.right * Time.deltaTime,Space.World);
		}

	}
}
