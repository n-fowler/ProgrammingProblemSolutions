public class MatryoshkaDoll
{
    private readonly MatryoshkaDoll containedDoll;

    public MatryoshkaDoll() { }

    public MatryoshkaDoll(MatryoshkaDoll containedDoll)
    {
        this.containedDoll = containedDoll;
    }

    public int NumberOfSmallerDolls
    {
        get
        {
            int count = 0;
            MatryoshkaDoll _containedDoll = new MatryoshkaDoll(containedDoll);

            while (_containedDoll != null)
            {
                count++;
                _containedDoll = _containedDoll.containedDoll;
            }

            return count - 1; //Don't count original
        }
    }
}