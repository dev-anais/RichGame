using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GeneralManager : MonoBehaviour
{
    public GameObject menuSet;

    // 게임 처음 시작할 때 
    public void  MoveToGame(){
       SceneManager.LoadScene("InitialGame");
    }

    public void  HideSettingDialog(){
        menuSet.SetActive(false);
    }
    //세팅 화면 보여주기
    public void ShowSettingDialog(){
        menuSet.SetActive(true);
    }
}
