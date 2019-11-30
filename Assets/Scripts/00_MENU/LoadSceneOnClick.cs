using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/*

* 프로그램명 : LoadSceneOnClick

* 작성자 : 이승연 (김민선, 김택원, 나선율, 조수현)

* 작성일 : 2019년 11월 27일

* 프로그램 설명 : 버튼 클릭시 대응되는 씬이 로드되게 한다.

*/


public class LoadSceneOnClick : MonoBehaviour
{
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}