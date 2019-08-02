using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    float runSpeed = 5f;
    float jumpSpeed = 5f;
    Rigidbody2D myRigidBody;
    Animator myAnimator;
    CapsuleCollider2D mybodyCollider;
    BoxCollider2D myfeetCollider;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        mybodyCollider = GetComponent<CapsuleCollider2D>();
        myfeetCollider = GetComponent<BoxCollider2D>();


    }

    // Update is called once per frame
    void Update()
    {
        Run();
        FlipSprite();
        Jump();
    }

    void Run()
    {
        //obtener el float (decimal) del control que va de -1 a 1
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal");

        //Inicializar un vector de dos dimensiones que solo modifica el componente x
        Vector2 playerVelocity = new Vector2(controlThrow*runSpeed, myRigidBody.velocity.y);

        //Asignar la nueva velocidad a rigid body
        myRigidBody.velocity = playerVelocity;

        //aplicar animacion de correr seteando la conidcion del "running del animoatr"
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > 0;

        if (playerHasHorizontalSpeed)
        {
            myAnimator.SetBool("Running", true);
        }
        else
        {
            myAnimator.SetBool("Running", false);
        }
        
    }

    void FlipSprite()
    {
        //Verificr si existe velocidad en x independeintemente del signo(por eso usamos valor absoluto)
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x)> 0;


        //Preguntamos si esa condicion en verdadera
        if(playerHasHorizontalSpeed)
        {
            //si si es vredadera, toma el signo de la velocidad en x y altera la esclaa en esa dimension
            transform.localScale = new Vector2(Mathf.Sign(myRigidBody.velocity.x), 1f);
        }
    }

    void Jump ()
    {
        //!valorbooleano

        if(!myfeetCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            return;
        }
        // Obtener el boolena (true/false) dle boton representado por le tag "jump"
        bool iSJumpButtonPressed = CrossPlatformInputManager.GetButtonDown("Jump");

        if(iSJumpButtonPressed)
        {
            Vector2 jumpVelocity = new Vector2(0, 1 * jumpSpeed);
            //sumar a la velocidad que ya tiee mi nueo vector de velocidad
            myRigidBody.velocity += jumpVelocity;
        }
    }
}
