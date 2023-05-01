using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;

    GameObject leftArrow;
    GameObject rightArrow;
    GameObject topArrow;
    GameObject bottomArrow;

    // Start is called before the first frame update
    void Start()
    {
        leftArrow = GameObject.Find("LeftArrow");
        rightArrow = GameObject.Find("RightArrow");
        topArrow = GameObject.Find("TopArrow");
        bottomArrow = GameObject.Find("BottomArrow");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveCamera(Vector2.left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveCamera(Vector2.right);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveCamera(Vector2.up);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveCamera(Vector2.down);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject == leftArrow)
                {
                    MoveCamera(Vector2.left);
                }

                if (hit.collider.gameObject == rightArrow)
                {
                    MoveCamera(Vector2.right);
                }

                if (hit.collider.gameObject == topArrow)
                {
                    MoveCamera(Vector2.up);
                }

                if (hit.collider.gameObject == bottomArrow)
                {
                    MoveCamera(Vector2.down);
                }
            }
        }
    }

    void MoveCamera(Vector2 direction)
    {
        Vector3 newPosition = transform.position + new Vector3(direction.x, direction.y, 0f) * moveSpeed * Time.deltaTime;
        newPosition.x = Mathf.Clamp(newPosition.x, -10f, 10f);
        newPosition.y = Mathf.Clamp(newPosition.y, -10f, 10f);
        transform.position = newPosition;
    }
}
