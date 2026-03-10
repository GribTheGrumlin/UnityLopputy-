using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private float StartingHealth;
    private float health;
    public float Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
            if (health <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = StartingHealth;
    }
}
