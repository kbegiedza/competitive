public class RecentCounter {
    private Queue<int> _queue;

    public RecentCounter() {
        _queue = new Queue<int>();
    }

    public int Ping(int t) {
        while(_queue.Count > 0 && t - _queue.Peek() > 3000)
        {
            _queue.Dequeue();
        }

        _queue.Enqueue(t);

        return _queue.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */