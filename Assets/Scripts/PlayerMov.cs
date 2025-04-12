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
}
