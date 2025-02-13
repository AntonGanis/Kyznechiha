using UnityEngine;

public class MouseDirection : MonoBehaviour
{
    private Vector3 lastMousePosition;
    private bool isMousePressed = false;
    public float speed;
    Vector3 targetPosition;
    bool isMoving;
    public Animator[] me;

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isMousePressed = true;
            lastMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMousePressed = false;
            DetectMouseDirection();
        }
        if (isMoving)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, speed * Time.deltaTime);
            if (transform.localPosition == targetPosition)
            {
                isMoving = false;
            }
        }
    }

    private void DetectMouseDirection()
    {
        Vector3 currentMousePosition = Input.mousePosition;
        Vector2 direction = currentMousePosition - lastMousePosition;
        if (direction.magnitude > 0)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Debug.Log(angle);

            if (angle >= -45 && angle < 45)
            {
                Move(1);
            }
            else if (angle >= 45 && angle <= 135)
            {
                Move(2);
            }
            else if (angle > 135 || angle < -135)
            {
                Move(3);
            }
            else if (angle >= -135 && angle < -45)
            {
                Move(4);
            }
        }
        else
        {
            Debug.Log("Мышь не перемещалась.");
        }
        lastMousePosition = currentMousePosition;
    }

    void Move(int dir)//1право 2вверх 3лево 4низ
    {
        if (dir == 1 && gameObject.transform.localPosition.x < 2f) 
        {
            targetPosition = transform.localPosition + new Vector3(2, 0, 0);
            isMoving = true;
        }
        if (dir == 3 && gameObject.transform.localPosition.x > -2f)
        {
            targetPosition = transform.localPosition - new Vector3(2, 0, 0);
            isMoving = true;
        }
        if (dir == 2) 
        {
            gameObject.GetComponent<Animator>().SetTrigger("прыг");
            me[0].SetTrigger("прыг");
            me[1].SetTrigger("прыг");
            me[2].SetTrigger("прыг");
        }
        if (dir == 4)
        {
            gameObject.GetComponent<Animator>().SetTrigger("низ");
            me[0].SetTrigger("низ"); 
            me[1].SetTrigger("низ"); 
            me[2].SetTrigger("низ"); 
        }

    }
    
}
