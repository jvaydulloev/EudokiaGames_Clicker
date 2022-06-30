
public class Complication
{
    public float Difficulty 
    {
        get;
        private set;
    }
    public Complication() 
    {
        Difficulty = 0;
    }
    public void Complicate(float currentForDifficulty) 
    {
        Difficulty = 0.1f * currentForDifficulty;
    }
}
