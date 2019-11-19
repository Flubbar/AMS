using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class KeyBinds : MonoBehaviour
{
    Transform menuPanel;
    Event keyEvent;
    Text buttonText;
    KeyCode newKey;
    bool waitingForKey;
    // Start is called before the first frame update
    void Start()
    {
        menuPanel = transform.Find("Panel");
        menuPanel.gameObject.SetActive(false);
        waitingForKey = false;
        for (int i = 0; i < menuPanel.childCount; i++)
        {
            if (menuPanel.GetChild(i).name == "ForwardKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.forward.ToString();
            }
            else if (menuPanel.GetChild(i).name == "BackwardKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.backward.ToString();
            }
            else if (menuPanel.GetChild(i).name == "LeftKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.left.ToString();
            }
            else if (menuPanel.GetChild(i).name == "RightKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.right.ToString();
            }
            else if (menuPanel.GetChild(i).name == "JumpKey")
            {
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.jump.ToString();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !menuPanel.gameObject.activeSelf)
        {
            menuPanel.gameObject.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && menuPanel.gameObject.activeSelf)
        {
            menuPanel.gameObject.SetActive(false);
        }
    }
    void OnGUI()
    {
        keyEvent = Event.current;
        if (keyEvent.isKey && waitingForKey)
        {
            newKey = keyEvent.keyCode; 
            //Assigns newKey to the key user presses
            waitingForKey = false;
        }
    }
    public void StartAssignment(string keyName)
    {
        if (!waitingForKey)
        {
            StartCoroutine(AssignKey(keyName));
        }
    }
    public void SendText(Text text)
    {
        buttonText = text;
    }
    IEnumerator WaitForKey()
    {
        while (!keyEvent.isKey)
        {
            yield return null;
        }
    }
    public IEnumerator AssignKey(string keyName)

    {

        waitingForKey = true;



        yield return WaitForKey(); //Executes endlessly until user presses a key



        switch (keyName)
        {
            case "forward":
                GameManager.GM.forward = newKey; //Set forward to new keycode
                buttonText.text = GameManager.GM.forward.ToString(); //Set button text to new key
                PlayerPrefs.SetString("forwardKey", GameManager.GM.forward.ToString()); //save new key to PlayerPrefs
                break;

            case "backward":
                GameManager.GM.backward = newKey; //set backward to new keycode
                buttonText.text = GameManager.GM.backward.ToString(); //set button text to new key
                PlayerPrefs.SetString("backwardKey", GameManager.GM.backward.ToString()); //save new key to PlayerPrefs
                break;

            case "left":
               GameManager.GM.left = newKey; //set left to new keycode
                buttonText.text = GameManager.GM.left.ToString(); //set button text to new key
                PlayerPrefs.SetString("leftKey", GameManager.GM.left.ToString()); //save new key to playerprefs
                break;

            case "right":
                GameManager.GM.right = newKey; //set right to new keycode
                buttonText.text = GameManager.GM.right.ToString(); //set button text to new key
                PlayerPrefs.SetString("rightKey", GameManager.GM.right.ToString()); //save new key to playerprefs
                break;

            case "jump":
                GameManager.GM.jump = newKey; //set jump to new keycode
                buttonText.text = GameManager.GM.jump.ToString(); //set button text to new key
                PlayerPrefs.SetString("jumpKey", GameManager.GM.jump.ToString()); //save new key to playerprefs
                break;
        }
        yield return null;
    }
}
