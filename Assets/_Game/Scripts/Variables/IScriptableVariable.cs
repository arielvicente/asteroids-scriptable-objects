namespace Variables
{
    public interface IScriptableVariable<T, TVariable>
    {
        void Set(T value);
        void Set(TVariable variable);
        void ApplyChange(T amount);
        void ApplyChange(TVariable variable);
    }
}
