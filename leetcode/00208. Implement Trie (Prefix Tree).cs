public class Trie {
    private Dictionary<char, Trie> _nodes;

    public Trie() {
        _nodes = new Dictionary<char, Trie>();
    }

    public void Insert(string word) {
        if (word.Length == 0)
        {
            _nodes['\0'] = null;

            return;
        }

        var first = word[0];

        var next = word.Substring(1, word.Length - 1);

        if(_nodes.TryGetValue(first, out var existingNode))
        {
            existingNode.Insert(next);
        }
        else
        {
            var newNode = new Trie();
            newNode.Insert(next);

            _nodes[first] = newNode;
        }
    }

    public bool Search(string word) {
        if (word.Length == 0)
        {
            return _nodes.ContainsKey('\0');
        }

        var first = word[0];

        if (_nodes.TryGetValue(first, out var existingNode))
        {
            var next = word.Substring(1, word.Length - 1);

            return existingNode.Search(next);
        }

        return false;
    }

    public bool StartsWith(string prefix) {
        if (prefix.Length == 0)
        {
            return true;
        }

        var first = prefix[0];

        if (_nodes.TryGetValue(first, out var existingNode))
        {
            var next = prefix.Substring(1, prefix.Length - 1);

            return existingNode.StartsWith(next);
        }

        return false;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */