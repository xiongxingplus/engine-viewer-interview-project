using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public SceneField[] Scenes;
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        var currentScene = SceneManager.GetActiveScene();
        foreach (SceneField sceneField in Scenes)
        {
            if(!SceneManager.GetSceneByName(sceneField).isLoaded)
            {
                yield return  SceneManager.LoadSceneAsync(sceneField, LoadSceneMode.Additive);
            }
        }

        SceneManager.SetActiveScene(currentScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
