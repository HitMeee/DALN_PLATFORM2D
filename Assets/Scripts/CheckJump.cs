using UnityEngine;

public class CheckJump : MonoBehaviour
{

    private InputController PlayerInput => GamePlayerController.Instance.gameContaint.inputController;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            PlayerInput.isGrounded = true;
            PlayerInput.animator.SetBool("IsJump", false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            PlayerInput.isGrounded = false;
        }
    }
}