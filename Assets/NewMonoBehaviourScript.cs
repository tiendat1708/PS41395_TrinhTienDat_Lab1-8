using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Di chuyển thẳng theo trục Z
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
