using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string SceneName = ""; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSceneChange()
    {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
    }
}
