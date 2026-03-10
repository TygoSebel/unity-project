using UnityEngine;


public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 20f;
    
    void Start()
    {
        PrintInstructions();
    }

    
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use WASD or Arrow Keys to move.");
        Debug.Log("Don't bump into the objects!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
