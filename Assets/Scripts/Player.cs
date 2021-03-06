using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float velocidade;
    [SerializeField] private float distance;

    public Enemy enemyRef;
    public Animator anim;
    
    public bool aux;


    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    void Update()
    {        
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            anim.SetTrigger("Front");
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            anim.SetTrigger("Down");
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            anim.SetTrigger("Up");
        }
    }
}
