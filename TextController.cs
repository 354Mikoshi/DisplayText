using UnityEngine;

public class TextController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(0f, 0.7f, 0f);
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, 0.03f, 0f);
    }
}
