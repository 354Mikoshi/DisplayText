using UnityEngine;
using UnityEngine.UI;

public class SphereController : MonoBehaviour
{
    public Text countText;
    private GameObject canvas;
    private int count;
    private bool positive;

    // Start is called before the first frame update
    void Start()
    {
        canvas = transform.Find("Canvas").gameObject;
        count = 0;
        positive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 6f) positive = false;
        else if (transform.position.x < -6f) positive = true;

        if (positive) transform.position += new Vector3(0.1f, 0f, 0f);
        else transform.position -= new Vector3(0.1f, 0f, 0f);
    }

    void OnCollisionEnter(Collision col) 
    { 
        count++;
        Text text = Instantiate(countText);
        text.transform.parent = canvas.transform;
        text.GetComponent<Text>().text = count.ToString();
    }
}
