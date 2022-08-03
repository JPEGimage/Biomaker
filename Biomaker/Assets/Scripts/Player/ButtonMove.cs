using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMove : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rig;

    public Animator anim;

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
    void FixedUpdate()
    {
        if(moving)
        {
            switch (direction)
            {
                case "up":
                    var up = new Vector3(0f, 1f, 0f).normalized;
                    rig.velocity = up * speed;
                    anim.SetBool("up",true);
                    img.sprite = SpriteUp;
                    break;
                case "down":
                    var down = new Vector3(0f, -1f, 0f).normalized;
                    rig.velocity = down * speed;
                    anim.SetBool("down", true);
                    img.sprite = SpriteDown;
                    break;
                case "left":
                    var left = new Vector3(-1f, 0f, 0f).normalized;
                    rig.velocity = left * speed;
                    anim.SetBool("left", true);
                    img.sprite = SpriteLeft;
                    break;
                case "right":
                    var right = new Vector3(1f, 0f, 0f).normalized;
                    rig.velocity = right * speed;
                    anim.SetBool("right", true);
                    img.sprite = SpriteRight;
                    break;
            }
        }
        else
        {
            rig.velocity = new Vector2(0f, 0f);
            anim.SetBool("up", false);
            anim.SetBool("down", false);
            anim.SetBool("right", false);
            anim.SetBool("left", false);
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