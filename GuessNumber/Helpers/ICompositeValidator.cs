namespace GuessNumber.Helpers
{
    internal interface ICompositeValidator
    {
        void Add(IValidator validator);
        bool Remote(IValidator validator);
    }
}