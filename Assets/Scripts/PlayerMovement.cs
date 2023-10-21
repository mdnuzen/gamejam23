using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public CharacterController controller;
    private float grav = -9.81f;
    private bool isGrounded;
    private Vector3 playerVelocity;
    private float jumpHeight = 1.0f;
    private float playerSpeed = 2.0f;
    public float rotationSpeed = 1.0f;
    public string playerRotation = "left";
    public SpriteRenderer m_SpriteRenderer;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        isGrounded = controller.isGrounded;
        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        if(Input.GetKey(KeyCode.Space) && isGrounded)
        {
            Debug.Log("Jump!");
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * grav);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        controller.Move(movementDirection * Time.deltaTime * playerSpeed);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);
        playerVelocity.y += grav * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        if((Input.GetKey(KeyCode.A) ||  Input.GetKey(KeyCode.LeftArrow)) && playerRotation == "right")
        {
            m_SpriteRenderer.flipX = true;
            playerRotation = "left";
        }

        if((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && playerRotation == "left")
        {
            m_SpriteRenderer.flipX = false;
            playerRotation = "right";
        }
    }
}