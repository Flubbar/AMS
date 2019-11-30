using UnityEngine;
using UnityEngine.SceneManagement;

/*

* 프로그램명 : LevelComplete.cs

* 작성자 : 나선율(김민선, 김택원, 이승연, 조수현)

* 작성일 : 2019년 11월27일

* 프로그램 설명 : 다음 스테이지를 불러온다.

*/

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LowerVolume()
    {
        AudioListener.volume -= 0.2f;
    }
}
