namespace Lib;

public class Node<T> {
    public T data;
    public Node<T>? next {get; set;}
    public Node<T>? prev {get; set;}

    public Node(T data) {
        this.data = data;
        next = null;
        prev = null;
    }

    public Node(T data, Node<T> next) {
        this.data = data;
        this.next = next;
        this.prev = null;
    }
} 