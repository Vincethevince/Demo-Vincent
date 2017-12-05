using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class L : MonoBehaviour {

    // Use this for initialization
    public void Load () {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("ReadText", LoadSceneMode.Single);
    }
    /*public void Example()
    {
        Application.LoadLevel("ReadText");
    }*/
}
