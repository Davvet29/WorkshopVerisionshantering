using UnityEngine;

public class Colorchange : MonoBehaviour
{
    public GameObject ball;
    private Material ballMaterial;
    
    
        
    void Start()
    {
        ballMaterial = ball.GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ballMaterial.SetColor("_Color", Color.red);
            Debug.Log("pressed key");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ballMaterial.SetColor("_Color", Color.blue);
        }
    }
}
