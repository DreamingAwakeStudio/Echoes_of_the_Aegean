using UnityEngine;
public class PlayerMov : MonoBehaviour
{
    private Animator anim;
    private float inputX, inputZ;
    public float walkSpeed;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        SetInputs();
        ToWalk();
    }
    void ToWalk()
    {
        anim.SetFloat("Horizontal", this.inputX);
        anim.SetFloat("Vertical", this.inputZ);
        transform.Translate(new Vector3(inputX,0,inputZ) * walkSpeed * Time.deltaTime);
    }
    void SetInputs()
    {
        this.inputX = Input.GetAxis("Horizontal");
        this.inputZ = Input.GetAxis("Vertical");
    }

    /*private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = UnityEngine.Input.GetAxis("Horizontal");
        float vertical = UnityEngine.Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(horizontal, 0, vertical);
        controller.Move(movimento * Time.deltaTime);
    }*/
}
