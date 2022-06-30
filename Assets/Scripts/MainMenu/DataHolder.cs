
public static class DataHolder 
{
    private static float[] _data = new float[5];
    private static float _candidateForRecord=0;

    public static void SetData() 
    {
        for (int i= 0; i < 5; i++)
            _data[i] = 0;
    }
    public static void TrySetNewData() 
    {
        for(int i=0;i<5; i++) 
        {
            if (_data[i] < _candidateForRecord)
            {
                for (int j = 4; j > i; j--) 
                {
                    _data[j] = _data[j - 1];
                }
                _data[i] = _candidateForRecord;
                break;
            }
        }
    }
    public static void SetCandidateForRecord(float current) 
    {
        _candidateForRecord = current;
    }
    public static float[] GetData() 
    {
        return _data;
    }

}
