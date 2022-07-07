using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMove : MonoBehaviour
{
    public GameObject player;

    private SpriteRenderer img;
    public Sprite SpriteDown;
    public Sprite SpriteUp;
    public Sprite SpriteLeft;
    public Sprite SpriteRight;

    public float speed;
    bool moving = false;
    string direction;
    void Start()
    {
        img = player.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(moving)
        {
            switch (direction)
            {
                case "up":
                    var up = new Vector3(0f, 1f, 0f).normalized;
                    player.transform.position += up * speed * Time.deltaTime;
                    Debug.Log("cima");
                    img.sprite = SpriteUp;
                    break;
                case "down":
                    var down = new Vector3(0f, -1f, 0f).normalized;
                    player.transform.position += down * speed * Time.deltaTime;
                    Debug.Log("baixo");
                    img.sprite = SpriteDown;
                    break;
                case "left":
                    var left = new Vector3(-1f, 0f, 0f).normalized;
                    player.transform.position += left * speed * Time.deltaTime;
                    Debug.Log("esquerda");
                    img.sprite = SpriteLeft;
                    break;
                case "right":
                    var right = new Vector3(1f, 0f, 0f).normalized;
                    player.transform.position += right * speed * Time.deltaTime;
                    Debug.Log("direita");
                    img.sprite = SpriteRight;
                    break;
            }
        }
    }
    public void Move(string di)
    {
        direction = di;
        moving = true;
    }
    public void Stop()
    {
        moving = false;
    }

}