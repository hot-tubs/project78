
using UnityEngine;

public class MouseDrag : MonoBehaviour {

    float distance = 10;

    void OnMouseDrag()
    {
        Vector3 MousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(MousePosition);


        transform.position = objPosition;

    }
}


