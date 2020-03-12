using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    //private void Start()
    //{
    //    Time.timeScale = 1f;
    //}
    public Animator cameraAnim;
    public void PlayGame()
    {
        cameraAnim.Play("CameraSlideAnimation");
        
    }


}
