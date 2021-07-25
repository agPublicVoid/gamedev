using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 10f;
    private const float _xMin = -2.55f;
    private const float _xMax = 2.55f;

    // Update is called once per frame
    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float xCoordinate = Input.GetAxis("Horizontal");

        // original player position 
        Vector2 origPosition = transform.position;

        if (xCoordinate > 0)
        {
            // moving right ...
            origPosition.x += Speed * Time.deltaTime;
        }

        if (xCoordinate < 0)
        {
            // moving left ...
            origPosition.x -= Speed * Time.deltaTime;
        }

        // lock movement within 2.55 margin from the sides
        if (origPosition.x < _xMin)
        {
            origPosition.x = _xMin;
        }

        if (origPosition.x > _xMax)
        {
            origPosition.x = _xMax;
        }

        // set new player's position
        transform.position = origPosition;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        //collided with a bomb
        if (target.tag == "Bomb")
        {
            // pause game
            Time.timeScale = 0f;
        }
    }
}