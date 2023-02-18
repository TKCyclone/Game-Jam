using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MakeItButton : MonoBehaviour
{
    public Color highlightColor;
    public Color originalColor;
    public UnityEvent onClick;

    private Material buttonMaterial;

    void Start()
    {
        buttonMaterial = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
        {
            // Highlight the button when the mouse is over it
            buttonMaterial.color = highlightColor;

            // Check for click on the button
            if (Input.GetMouseButtonDown(0))
            {
                onClick.Invoke();
            }
        }
        else
        {
            // Revert the button color when the mouse is not over it
            buttonMaterial.color = originalColor;
        }
    }
}



