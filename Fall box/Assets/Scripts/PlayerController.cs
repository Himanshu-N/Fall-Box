using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    public float speed = 50f;
    float inputHorizontal;
    // Start is called before the first frame update
    void Start()
    {
        DestroyEnd._gameOver = false;
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        if (inputHorizontal != 0 && !DestroyEnd._gameOver)
        {
            _rb.AddForce(new Vector2(inputHorizontal * speed, 0f));
            // _rb.velocity = Vector2.right * inputHorizontal * speed * Time.deltaTime;
            // transform.Translate(Vector2.right * inputHorizontal * speed * Time.deltaTime);
        }
    }
}
