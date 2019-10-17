
using UnityEngine;
using UnityEngine.SceneManagement;
public class Quit : MonoBehaviour
{
    //public GameObject OutMenu;

    public void QuitApp()
    {
        Application.Quit();
    }

    public void BackHome()
    {
        //AskOut();
        SceneManager.LoadScene("Opening", LoadSceneMode.Single);
    }

    public void AskOut()
    {
       // OutMenu.SetActive(true);
    }
}
