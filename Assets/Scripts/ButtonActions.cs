using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonActions : MonoBehaviour
{

    [SerializeField] GameObject gameOverTextObject;
    [SerializeField] GameObject retryButtonObject;

    public void retryButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverTextObject.SetActive(false);
        retryButtonObject.SetActive(false);

    }


}
