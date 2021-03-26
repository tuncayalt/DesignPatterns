namespace DesignPatternsLibrary.Composite
{
    public interface ICompositeComponent
    {
        void AddComponent(ICompositeComponent newComponnent);
        void DisplayComponents();
    }
}