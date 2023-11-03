namespace Lib;

public class DQueue<T> {
    int size = 0;
    Node<T>? tail = null;
    Node<T>? head = null;

    public void Push(params T[] values) {
        foreach(T value in values.Reverse()) {
            Node<T> newHead = new Node<T>(value);
            newHead.next = head;
            if (head == null) {
                tail = newHead;
            } else {
                head.prev = newHead;
            }
            head = newHead;
            size++;
        }       
    }

    public void PushBack(params T[] values) {
        foreach(T value in values) {
            Node<T> newHead = new Node<T>(value);
            newHead.prev = tail;
            if (head == null) {
                head = newHead;
            } else {
                tail!.next = newHead;
            }
            tail = newHead;
            size++;
        }       
    }

    public T Pop() {
        if (head == null) throw new InvalidOperationException();
        T value = head.data;
        head = head.next;
        head!.prev = null;
        size--;
        return value;
    }

    public T PopBack() {
        if (tail == null) throw new InvalidOperationException();
        T value = tail.data;
        tail = tail.prev;
        tail!.next = null;
        size--;
        return value;
    }

    public void Remove(params T[] values) {
        foreach(T value in values) {
            Node<T> fictionList = new Node<T>(value, head);
            Node<T> currentElement = fictionList;
            while(currentElement != null && currentElement.next != null) {
                if(currentElement.next.data!.Equals(value)) {
                    var newNextNode = currentElement.next.next;
                    if(currentElement.next == tail) tail = currentElement;
                    currentElement.next = newNextNode;
                    if(newNextNode!=null) newNextNode.prev = currentElement;
                    size--;
                }
                currentElement = currentElement.next;
            }
            head = fictionList.next;
        }
    }

    public List<int> FindValue(T value){
        Node<T> currentElement = head!;
        List<int> result = new List<int>();
        int index = 0;
        while(currentElement!=null) {
            if(currentElement.data!.Equals(value)) {
                result.Add(index);
            }
            index++;
            currentElement = currentElement.next!;
        }
        return result;
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

























// Node<T>? node = head;
        // while (node != null) {
        //     if (values.Contains(node.data)) {
        //         if (node.prev != null)
        //             node.prev!.next = node.next;
        //         if (node.next != null)
        //             node.next!.prev = node.prev;
        //         size--;
        //     }
        //     node = node.next;
        // }