namespace StackUsingLinkedList
{
    internal class Node
    {
        internal object next;
        internal string data;
        private int value;

        public Node(int value)
        {
            this.value = value;
        }
    }
}