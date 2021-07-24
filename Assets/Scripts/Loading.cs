using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{

    private float time;
    // Start is called before the first frame update
    void Start() {
        time = Time.time;
    }

    // Update is called once per frame
    void Update() {
        if(Time.time - time > 4){
            time = Time.time;
            RestartNewScenes();
        }
    }

    public void RestartNewScenes(){
            SceneManager.LoadScene(NextLevelPoint.instance.lvlName);
    }
}
