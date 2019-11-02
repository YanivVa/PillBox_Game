using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject popup;
    public GameObject gamePlayCanvas;
    public float rotationSpeed = 50f;
    public float projectileSpeed = 10f;
    public float projectilePower = 1;
    public float fireRate = 2f;

    public GameObject projectileSpeedScore;
    public GameObject rotationSpeedScore;
    public GameObject ProjectilePowerScore;
    public GameObject fireRateScore;
    // Start is called before the first frame update
    void Start()
    {
        initPowerUpsPanel();
    }

    void initPowerUpsPanel()
    {
        projectileSpeedScore.GetComponent<Text>().text = projectileSpeed.ToString();
        rotationSpeedScore.GetComponent<Text>().text = rotationSpeed.ToString();
        ProjectilePowerScore.GetComponent<Text>().text = projectilePower.ToString();
        fireRateScore.GetComponent<Text>().text = fireRate.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onQuit()
    {
        popup.SetActive(true);
    }

    public void onCancel()
    {
        popup.SetActive(false);
    }

    public void onApprove()
    {
        SceneManager.LoadScene("Scenes/Opening");
    }
}
