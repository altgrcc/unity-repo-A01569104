using UnityEngine;

public class MoveObject : MonoBehaviour
{

    float x,y,z;
    public Vector3 speed;


    // Update is called once per frame
    void Update() // 120 fps, 20 fps
    {
        transform.position = new Vector3(x, y, z);
        x += speed.x * Time.deltaTime; // 0.008 s = 8 ms en una potente, 0.050 s = 50 ms en una lenta // deltaTime: lo que le tomo al frame anterior renderizarse // 60 fps esta muy bien para la industria *aceptable
        y += speed.y * Time.deltaTime;
        z += speed.z * Time.deltaTime;
    }
}
