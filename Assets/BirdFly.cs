using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite upWing;
    public Sprite downWing;
    void Start()
    {

    }

    void Update()
    {
        if (Time.time % 0.2f < 0.1f)
            sr.sprite = upWing;
        else
            sr.sprite = downWing;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
}
