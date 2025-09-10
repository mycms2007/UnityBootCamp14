using System.Text;
class MyList<T>
{
    //리스트를 구현하라는 말을 들으면 아래의 내용들을 칠 수 있도록 만들어 놓겠습니다.

    private T[] _items;
    private int _count;
    private const int DefaultCapacity = 4;

    public MyList()
    {
        _items = new T[DefaultCapacity];
        _count = 0;
    }

    public int Count => _count;

    public void Add(T item)
    {
        if (_count == _items.Length)
            Resize();
        _items[_count++] = item;
    }

    public void Insert(int index, T item)
    {
        if (index < 0 || index > _count)
            throw new ArgumentOutOfRangeException();

        if (_count == _items.Length)
            Resize();

        for (int i = _count; i > index; i--)
        {
            _items[i] = _items[i - 1];
        }

        _items[index] = item;
        _count++;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
            throw new ArgumentOutOfRangeException();

        for (int i = index; i < _count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        _count--;
        _items[_count] = default(T);
    }

    public T Get(int index)
    {
        if (index < 0 || index >= _count)
            throw new ArgumentOutOfRangeException();

        return _items[index];
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        for (int i = 0; i < _count; i++)
        {
            sb.Append(_items[i]);
            if (i < _count - 1)
                sb.Append(", ");
        }
        sb.Append("]");
        return sb.ToString();
    }

    private void Resize()
    {
        int newSize = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;
        T[] newArray = new T[newSize];
        for (int i = 0; i < _count; i++)
        {
            newArray[i] = _items[i];
        }
        _items = newArray;
    }
}


class MyLinkedList<T>
{
    private class Node
    {
        public T Data;
        public Node Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node _head;
    private int _count;



    //링크드 리스트를 구현하라는 요구를 들으면 아래의 코드를 쳐낼 수 있도록 만들어놓겠습니다.
    public MyLinkedList()
    {
        _head = null;
        _count = 0;
    }

    public int Count => _count;

    public void AddLast(T item)
    {
        Node newNode = new Node(item);
        if (_head == null)
        {
            _head = newNode;
        }
        else
        {
            Node current = _head;
            while (current.Next != null)
                current = current.Next;
            current.Next = newNode;
        }
        _count++;
    }

    public void Insert(int index, T item)
    {
        if (index < 0 || index > _count)
            throw new ArgumentOutOfRangeException();

        Node newNode = new Node(item);

        if (index == 0)
        {
            newNode.Next = _head;
            _head = newNode;
        }
        else
        {
            Node prev = _head;
            for (int i = 0; i < index - 1; i++)
                prev = prev.Next;

            newNode.Next = prev.Next;
            prev.Next = newNode;
        }

        _count++;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
            throw new ArgumentOutOfRangeException();

        if (index == 0)
        {
            _head = _head.Next;
        }
        else
        {
            Node prev = _head;
            for (int i = 0; i < index - 1; i++)
                prev = prev.Next;

            prev.Next = prev.Next.Next;
        }

        _count--;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= _count)
            throw new ArgumentOutOfRangeException();

        Node current = _head;
        for (int i = 0; i < index; i++)
            current = current.Next;

        return current.Data;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");

        Node current = _head;
        while (current != null)
        {
            sb.Append(current.Data);
            if (current.Next != null)
                sb.Append(", ");
            current = current.Next;
        }

        sb.Append("]");
        return sb.ToString();
    }
}