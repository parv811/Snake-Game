using UnityEngine;
using TMPro;

public class FoodPlacement : MonoBehaviour
{
    public BoxCollider2D gridArea;
    public TextMeshProUGUI textMeshPro;
    public float score;


    private void Start()
    {
        RandomizePosition();
    }

    private void Update()
    {
        textMeshPro.text = "" + score;
    }
    private void RandomizePosition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x); 
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            RandomizePosition();
            score += 1;
        }
    }
}
