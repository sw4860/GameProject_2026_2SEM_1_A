using System.Net.Sockets;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private float openAngle = 90f;
    [SerializeField] private float openSpeed = 3f;

    private bool isOpen;

    [SerializeField] private Quaternion closedRotation;
    [SerializeField] private Quaternion openRotation;

    void Start()
    {
        closedRotation = transform.localRotation;
        openRotation = closedRotation * Quaternion.Euler(0, openAngle, 0f);
    }

    private void Update()
    {
        Quaternion targetRotaion;

        if (isOpen)
        {
            targetRotaion = openRotation;
        }
        else
        {
            targetRotaion = closedRotation;
        }

        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotaion, openSpeed * Time.deltaTime);
    }

    public void Interact()
    {
        isOpen = !isOpen;
    }

    public string GetGuideText()
    {
        if (isOpen)
        {
            return "[E] 문 닫기";
        }
        return "[E] 문 열기";
    }
}
