using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class KeyBindMenuScript : MonoBehaviour
{
    Transform menuPanel;
    Event keyEvent;
    Text buttonText;
    KeyCode newKey;
    bool waitingForKey;

    void Start()
    {
        menuPanel = transform.Find("KeyBindPanel");
        waitingForKey = false;

        for (int i = 0; i < menuPanel.childCount; i++)
        {
            if (menuPanel.GetChild(i).name == "ForwardKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.gameManager.forward.ToString();

            else if (menuPanel.GetChild(i).name == "BackwardKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.gameManager.backward.ToString();

            else if (menuPanel.GetChild(i).name == "LeftKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.gameManager.left.ToString();

            else if (menuPanel.GetChild(i).name == "RightKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.gameManager.right.ToString();

            else if (menuPanel.GetChild(i).name == "ActionKey")
                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.gameManager.action.ToString();
        }
    }

    void Update()
    {

    }

    void OnGUI()
    {
        keyEvent = Event.current;

        if (keyEvent.isKey && waitingForKey)
        {
            newKey = keyEvent.keyCode;
            waitingForKey = false;
        }
    }

    public void StartAssignment(string keyName)
    {
        if (!waitingForKey)
            StartCoroutine(AssignKey(keyName));
    }

    public void SendText(Text text)
    {
        buttonText = text;
    }

    IEnumerator WaitForKey()
    {
        while (!keyEvent.isKey)
            yield return null;
    }

    public IEnumerator AssignKey(string keyName)
    {
        waitingForKey = true;

        yield return WaitForKey();

        switch (keyName)
        {
            case "forward":
                GameManager.gameManager.forward = newKey;
                buttonText.text = GameManager.gameManager.forward.ToString();
                PlayerPrefs.SetString("forwardKey", GameManager.gameManager.forward.ToString());
                break;

            case "backward":
                GameManager.gameManager.backward = newKey;
                buttonText.text = GameManager.gameManager.backward.ToString();
                PlayerPrefs.SetString("backwardKey", GameManager.gameManager.backward.ToString());
                break;

            case "left":
                GameManager.gameManager.left = newKey;
                buttonText.text = GameManager.gameManager.left.ToString();
                PlayerPrefs.SetString("leftKey", GameManager.gameManager.left.ToString());
                break;

            case "right":
                GameManager.gameManager.right = newKey;
                buttonText.text = GameManager.gameManager.right.ToString();
                PlayerPrefs.SetString("rightKey", GameManager.gameManager.right.ToString());
                break;

            case "action":
                GameManager.gameManager.action = newKey;
                buttonText.text = GameManager.gameManager.action.ToString();
                PlayerPrefs.SetString("actionKey", GameManager.gameManager.action.ToString());
                break;
        }

        yield return null;
    }
}