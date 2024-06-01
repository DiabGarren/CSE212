public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value < Data)
        {
            if (Left is not null)
                return Left.Contains(value);
        }
        else if (value > Data)
        {
            if (Right is not null)
                return Right.Contains(value);
        }
        else if (value == Data)
            return true;
        return false;
    }

    public int GetHeight()
    {
        if (Left is not null && Right is not null)
        {
            int left = Left.GetHeight();
            int right = Right.GetHeight();

            return Math.Max(left, right) + 1;
        }
        else if (Left is not null)
        {
            int left = Left.GetHeight(); return left + 1;
        }
        else if (Right is not null)
        {
            int right = Right.GetHeight(); return right + 1;
        }
        return 1;
    }
}