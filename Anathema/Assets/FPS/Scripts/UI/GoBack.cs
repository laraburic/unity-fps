using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBack : MonoBehaviour
{
    public void BackButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("IntroMenu");
    }
}
