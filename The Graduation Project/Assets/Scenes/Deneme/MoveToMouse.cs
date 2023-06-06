
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    public static List<MoveToMouse> moveableObjects = new List<MoveToMouse>();

    public float speed = 5f;
    private Vector3 target;

    private bool selected;

    void Start()
    {
        moveableObjects.Add(this);
        target = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            // Tüm seçili cisimleri hareket ettirme
            foreach (MoveToMouse obj in moveableObjects)
            {
                if (obj.selected)
                {
                    obj.target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    obj.target.z = obj.transform.position.z;
                }
            }
        }

        // Tüm cisimleri hedefe doğru hareket ettirme
        foreach (MoveToMouse obj in moveableObjects)
        {
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, obj.target, obj.speed * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        selected = !selected;

        // Cismin seçim durumuna göre renk değiştirme
        if (selected)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }

        // Eğer şu an seçili olan cisim bu cisim değilse, diğer cisimlerin seçim durumunu kapatma
        if (!selected)
        {
            foreach (MoveToMouse obj in moveableObjects)
            {
                if (obj != this)
                {
                    obj.selected = false;
                    obj.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                }
            }
        }
    }
}
