using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopScene : MonoBehaviour
{

    private bool showing = false;
    public string lvlName;
    public GameObject menu;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            showing = !showing;
            menu.SetActive(showing);

            Time.timeScale = showing ? 0 : 1;

        }
        
    }

    public void ExitGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene("mainMenu");
    }

    public void Restart(){
        Time.timeScale = 1;
        SceneManager.LoadScene(lvlName);
    }
}
