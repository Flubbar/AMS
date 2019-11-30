using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

/*

* 프로그램명 : Gamemanager.cs

* 작성자 : 나선율(김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 스테이지 이동 및 재시작을 시행한다.

*/


public class GameManager : MonoBehaviour
{
    bool gameHadEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHadEnded == false)
        {
            gameHadEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
