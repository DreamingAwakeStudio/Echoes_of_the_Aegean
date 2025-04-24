using UnityEngine;
public class CameraMov : MonoBehaviour {
 [Header("Settings")]
 public float sens = 150.0f;
 public float rotationSpeed = 10.0f; 
 public float verticalLimit = 45.0f;
 public float followSpeed = 10.0f;
 public float yOffSet = 1.0f;
public Transform cameraPosition; 
private Transform target;
private float rotX, rotY;
 void Start()
 {
   Cursor.lockState = CursorLockMode.Locked;
   target = GameObject.FindGameObjectWithTag("Player").transform;
 }
 void Update()
 {
   CametaRotate();
   FirstPersonCameraTargetRotate();
 }
 private void LateUpdate()
 {
   Follow();
 }
 void CametaRotate()
 {
     
   rotX -= Input.GetAxis("Mouse Y") * sens * Time.deltaTime;
   rotY += Input.GetAxis("Mouse X") * sens * Time.deltaTime;
   rotX = Mathf.Clamp(rotX, -verticalLimit, verticalLimit);
   transform.rotation = Quaternion.Euler(rotX, rotY, 0);
 }
 void Follow()
 {
   transform.position = Vector3.Lerp(transform.position, target.position + target.up * yOffSet, Mathf.Clamp01(followSpeed * Time.deltaTime)
);

 }
 void FirstPersonCameraTargetRotate()
 {
   target.rotation = Quaternion.Lerp(target.rotation, Quaternion.Euler(0, rotY, 0), rotationSpeed * Time.deltaTime); //rotação do player
 }
}
