using UnityEngine;

public class CameraTransform : MonoBehaviour
{

    public Transform target1;
    public Transform target2;
    public Transform target3;
    
    void Start()
    {
        transform.LookAt(target1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target1);
       
       
    }
}
