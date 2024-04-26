public class MyLinkedList
{
    private int _count;
    private ListNode _head;
    private ListNode _tail;

    public MyLinkedList()
    {
        _count = 0;
        _head = null;
        _tail = null;
    }

    public int Get(int index)
    {
        if(_head == null)
        {
            return -1;
        }

        var node = _head;

        for (var i = 0; i < index; ++i)
        {

            if (node.Next != null)
            {
                node = node.Next;
            }
            else
            {
                return -1;
            }
        }

        return node.Value;
    }

    public void AddAtHead(int val)
    {
        var newHead = new ListNode
        {
            Value = val,
            Next = _head,
        };

        if(_head == null)
        {
            _tail = newHead;
        }
        else
        {
            _head.Prev = newHead;
        }

        _head = newHead;

        _count++;
    }

    public void AddAtTail(int val)
    {
        var newTail = new ListNode
        {
            Value = val,
            Prev = _tail,
        };

        if(_tail == null)
        {
            _head = newTail;
        }
        else
        {
            _tail.Next = newTail;
        }

        _tail = newTail;

        _count++;
    }

    public void AddAtIndex(int index, int val)
    {
        if(index == _count)
        {
            AddAtTail(val);

            return;
        }

        if(_head == null || index < 0)
        {
            return;
        }

        var node = _head;

        for (var i = 0; i < index; ++i)
        {
            if (node.Next != null)
            {
                node = node.Next;
            }
            else
            {
                return;
            }
        }

        var newNode = new ListNode
        {
            Value = val,
            Prev = node.Prev,
            Next = node,
        };

        if(node == _head)
        {
            _head = newNode;
        }

        if(node.Prev != null)
        {
            node.Prev.Next = newNode;
        }

        node.Prev = newNode;

        _count++;
    }

    public void DeleteAtIndex(int index)
    {
        if(_head == null || index < 0)
        {
            return;
        }

        var node = _head;

        for (var i = 0; i < index; ++i)
        {
            if (node.Next != null)
            {
                node = node.Next;
            }
            else
            {
                return;
            }
        }

        if(node.Prev != null)
        {
            node.Prev.Next = node.Next;
        }
        else
        {
            _head = node.Next;
        }

        if(node.Next != null)
        {
            node.Next.Prev = node.Prev;
        }
        else
        {
            _tail = node.Prev;
        }

        _count--;
    }

    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }
        public ListNode Prev { get; set; }
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */