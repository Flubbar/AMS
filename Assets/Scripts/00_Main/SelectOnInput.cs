using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour
{
    public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttonSelected;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("vertical") != 0 && buttonSelected == false)
        {
            eventSystem.SetSelectedGameObject(selectedObject);
            buttonSelected = true;
        }
    }

    private void OnDisabled()
    {
        buttonSelected = false;
    }
}
