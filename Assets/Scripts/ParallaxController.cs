using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    [SerializeField] private Transform[] layers;
    [SerializeField] private float[] coeff;
    private int layersCount;
    private Vector3 pos;

    [SerializeField] private float smoothing = 1f;

    void Start()
    {
        layersCount = layers.Length;
        pos = transform.position;
    }

    void Update()
    {
        //Vector2 pos = transform.position;
        ////pos.y = posY.y;
        //for (int i = 0; i < layersCount; i++)
        //{

        //    layers[i].position = pos* coeff[i];
        //}


        for (int i = 0; i < layersCount; i++)
        {
            float parallax = (pos.x - transform.position.x) * coeff[i];
            float backgroundTargetPosX = layers[i].position.x + parallax; 
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, layers[i].position.y, layers[i].position.z);
            // Smoothly move the background towards the target position
            layers[i].position = Vector3.Lerp(layers[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }
        pos = transform.position;
    }
}
