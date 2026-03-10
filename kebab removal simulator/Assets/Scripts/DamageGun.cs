using UnityEngine;

public class DamageGun : MonoBehaviour
{
    public float damage;
    private Transform PlayerCamera;
    public KebabScript kebabscript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerCamera = Camera.main.transform;
    }
    public void Shoot()
    {
        Ray gunRay = new Ray(PlayerCamera.position, PlayerCamera.forward);
        if (Physics.Raycast(gunRay, out RaycastHit hitInfo))
        {
            if (hitInfo.collider.gameObject.TryGetComponent(out Entity enemy))
            {
                enemy.Health -= damage;
                kebabscript.RemoveKebab();
            }
        }
    }
}
