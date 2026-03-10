using UnityEngine;
using UnityEngine.Events;

public class gun : MonoBehaviour
{
    public UnityEvent OnGunShoot;
    public float FireCooldown;
    private float CurrentCooldown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentCooldown = FireCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (CurrentCooldown <= 0f)
            {
                OnGunShoot?.Invoke();
                CurrentCooldown = FireCooldown;
            }
        }
    CurrentCooldown -= Time.deltaTime;
    }
}
