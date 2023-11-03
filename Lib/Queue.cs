namespace Lib;

public class MyQueue<T> {
    int size = 0;
    Node<T>? tail = null;
    Node<T>? head = null;

    public void Push(params T[] values) {
        foreach(T value in values) {
            Node<T> newHead = new Node<T>(value);
            if(head != null) {
                newHead.prev = head.prev;
                head.prev = newHead;
            }

            head = newHead;

            if(tail==null) tail = head;

            size++;
        }       
    }

    public T Pop() {
        if(size==0) throw new InvalidOperationException();
        T tailValue = tail!.data;
        tail = tail.prev;
        if(tail != null) {
            tail.next = null;
        }

        if(tail == null) {
            head = null;
        }

        size--;

        return tailValue;
    }

    public T Front() {
        if(size==0) throw new InvalidOperationException();
        return tail!.data;
    }

    public int Size() {
        return size;
    }

    public void Clear() {
        while(size>0) {
            this.Pop();
        }
    }

    public override string ToString() {
        T[] res = new T[size];
        int k = 0;
        Node<T>? node = tail;
        while (node != null) {
            res[k++] = node.data;
            node = node.prev;
        }
        return String.Join(' ', res);
    }
}