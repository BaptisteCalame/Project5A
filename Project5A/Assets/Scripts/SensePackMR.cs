using System.Collections;
using System.Collections.Generic;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.InputSystem;

public class SensePackMR : MonoBehaviour
{
    public InputActionReference leftTrigger;
    public InputActionReference rightTrigger;

    public Transform leftSpawnPoint;
    public Transform rightSpawnPoint;

    public GameObject blueBoxPrefab;
    public GameObject redBoxPrefab;

    private void Awake()
    {
        leftTrigger.action.started += OnLeftTrigger;
        rightTrigger.action.started += OnRightTrigger;
    }

    private void OnDestroy()
    {
        leftTrigger.action.started -= OnLeftTrigger;
        rightTrigger.action.started -= OnRightTrigger;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnLeftTrigger(InputAction.CallbackContext callback)
    {
        GameObject newLeftObj = Instantiate(redBoxPrefab, leftSpawnPoint.position, Quaternion.identity);
    }

    private void OnRightTrigger(InputAction.CallbackContext callback)
    {
        GameObject newRightObj = Instantiate(blueBoxPrefab, rightSpawnPoint.position, Quaternion.identity);
    }


}
