using UnityEngine;
public class PlayerMov : MonoBehaviour
{
    private Animator anim;
    private float speed;
    private float inputX, inputZ;
    
    public float walkSpeed, runSpeed;
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
        anim.SetBool("run", Input.GetKey(KeyCode.LeftShift) && inputX == 0 && inputZ > 0);
        transform.Translate(new Vector3(inputX,0,inputZ) * speed * Time.deltaTime);
    }
    void SetInputs()
    {
        this.inputX = Input.GetAxis("Horizontal");
        this.inputZ = Input.GetAxis("Vertical");

        this.speed = Input.GetKey(KeyCode.LeftShift) && inputX == 0 && inputZ > 0 ? runSpeed :walkSpeed; //Mêcanica de correr
    }
}
