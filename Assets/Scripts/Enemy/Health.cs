
public class Health
{
    private float _health;

    public Health() 
    {
        _health = 1;
    }

    public Health(float health) => _health=health;

    public float GetHealth 
    {
        get 
        {
            return _health;
        }
    }
    public void TakeHealth(float damage) 
    {
        _health -= damage;
    }

    public bool IsDie() 
    {
        return _health <= 0;
    }
    
}
