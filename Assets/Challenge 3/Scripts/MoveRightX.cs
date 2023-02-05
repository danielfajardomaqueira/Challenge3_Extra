using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightX : MonoBehaviour
{
    public float speed;
    private PlayerControllerX playerControllerScript;
    private float RightBound = 10;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }

        // If object goes off screen that is NOT the background, destroy it
        if (transform.position.x > RightBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }
    }
}
