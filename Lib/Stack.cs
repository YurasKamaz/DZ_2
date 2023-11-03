namespace Lib;

public class MyStack<T> {
    int size;
    public Node<T>? head;

    public MyStack() {
        size = 0;
        head = null;
    }

    public void push(params T[] values) {
        foreach (T value in values) {
            Node<T> newNode = new Node<T>(value);
            newNode.next = head;
            head = newNode;
            size++;
        }
    }

    public T pop() {
        if(size == 0) throw new InvalidOperationException();
        T currentValue = head!.data;
        head = head.next;
        size--;
        return currentValue;
    }

    public T back() {
        if(size == 0) throw new InvalidOperationException();
        return head!.data;
    }

    public int Size() {
        return size;
    }

    public void clear() {
        while(this.size>0) {
            this.pop();
        }
    }

    public override string ToString() {
        T[] res = new T[size];
        int k = 0;
        Node<T>? node = head;
        while (node != null) {
            res[k++] = node.data;
            node = node.next;
        }
        return String.Join(' ', res);
    }
}
