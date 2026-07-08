using UnityEngine;

public class NPCController : MonoBehaviour
{
    // กำหนดความเร็วในการขับเคลื่อนของรถ
    [SerializeField] 
    float speed = 15f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}