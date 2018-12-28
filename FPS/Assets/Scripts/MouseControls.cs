using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControls : MonoBehaviour {

    private bool isLocked;

    private void MakeCursorLocked()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isLocked = true;
    }

    private void MakeCursorUnlocked()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        isLocked = false;
    }

    private void Update()
    {
        transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.P) && isLocked == false)
        {
            MakeCursorLocked();
        }
        else if (Input.GetKeyDown(KeyCode.P) && isLocked == true)
        {
            MakeCursorUnlocked();
        }
    }
}
