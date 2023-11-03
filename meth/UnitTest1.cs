using Lib;

namespace meth;

[TestClass]
public class StackTest {
    public Lib.MyStack<int> stack = new Lib.MyStack<int>();

    [TestMethod] 
    public void Pushing() {
        stack.push(3);
        Assert.AreEqual("3", stack.ToString());
        stack.push(15);
        Assert.AreEqual("15 3", stack.ToString());
    }

    [TestMethod] 
    public void Popping() {
        Assert.ThrowsException<InvalidOperationException>(() => stack.pop());
        stack.push(3);
        Assert.AreEqual(3, stack.pop());
    }

    [TestMethod] 
    public void Peeking() {
        Assert.ThrowsException<InvalidOperationException>(() => stack.back());
        stack.push(3);
        stack.push(15);
        Assert.AreEqual(15, stack.back());
    }

    [TestMethod] 
    public void Sizing() {
        stack.push(3, 14, 15);
        Assert.AreEqual(3, stack.Size());
    }

    [TestMethod] 
    public void Clearing() {
        stack.push(3, 14, 15);
        stack.clear();
        Assert.AreEqual(0, stack.Size());
        Assert.ThrowsException<InvalidOperationException>(() => stack.back());
    }

    [TestMethod] 
    public void Demo() {
        stack.push(3, 14);
        Assert.AreEqual(2, stack.Size());
        stack.clear();
        stack.push(1);
        Assert.AreEqual(1, stack.back());
        stack.push(2);
        Assert.AreEqual(2, stack.back());
        Assert.AreEqual(2, stack.pop());
        Assert.AreEqual(1, stack.Size());
        Assert.AreEqual(1, stack.pop());
        Assert.AreEqual(0, stack.Size());
    }
}

[TestClass]
public class QueueTest {
    public Lib.MyQueue<int> queue = new Lib.MyQueue<int>();

    [TestMethod] 
    public void Pushing() {
        queue.Push(3, 14);
        Assert.AreEqual("3 14", queue.ToString());
        queue.Push(15);
        Assert.AreEqual("3 14 15", queue.ToString());
    }

    [TestMethod] 
    public void Popping() {
        Assert.ThrowsException<InvalidOperationException>(() => queue.Pop());
        queue.Push(3, 14);
        Assert.AreEqual(3, queue.Pop());
    }

    [TestMethod] 
    public void Peeking() {
        Assert.ThrowsException<InvalidOperationException>(() => queue.Front());
        queue.Push(3, 14);
        Assert.AreEqual(3, queue.Front());
    }

    [TestMethod] 
    public void Sizing() {
        queue.Push(3, 14, 15);
        Assert.AreEqual(3, queue.Size());
    }

    [TestMethod] 
    public void Clearing() {
        queue.Push(3, 14, 15);
        queue.Clear();
        Assert.AreEqual(0, queue.Size());
        Assert.ThrowsException<InvalidOperationException>(() => queue.Front());
    }

    [TestMethod] 
    public void Demo() {
        Assert.AreEqual(0, queue.Size());
        queue.Push(1);
        Assert.AreEqual(1, queue.Size());
        queue.Push(2, 3);
        Assert.AreEqual(3, queue.Size());
        queue.Push(4);
        Assert.AreEqual(4, queue.Size());
        Assert.AreEqual("1 2 3 4", queue.ToString());
    }
}

[TestClass]
public class BracketsTest {
    [TestMethod] 
    public void One() {
        string exp = "( ( ) ) ( )";
        Assert.AreEqual("Good", Brackets.CheckBrackets(exp));
    }

    [TestMethod] 
    public void Two() {
        string exp = "( ( ( ) )";
        Assert.AreEqual("Bad", Brackets.CheckBrackets(exp));
    }

    [TestMethod] 
    public void Three() {
        string exp = "( ) ( ) )";
        Assert.AreEqual("Bad", Brackets.CheckBrackets(exp));
    }
}

[TestClass]
public class DQueueTest {
    public Lib.DQueue<int> dqueue = new Lib.DQueue<int>();

    [TestMethod] 
    public void Pushing() {
        dqueue.Push(3, 14);
        Assert.AreEqual("3 14", dqueue.ToString());
    }

    [TestMethod]
    public void PushingBack() {
        dqueue.PushBack(3, 14);
        Assert.AreEqual("3 14", dqueue.ToString());
    }

    [TestMethod] 
    public void Popping() {
        Assert.ThrowsException<InvalidOperationException>(() => dqueue.Pop());
        dqueue.Push(3, 14);
        Assert.AreEqual(3, dqueue.Pop());
    }

    [TestMethod]
    public void PoppingBack() {
        Assert.ThrowsException<InvalidOperationException>(() => dqueue.PopBack());
        dqueue.Push(3, 14);
        Assert.AreEqual(14, dqueue.PopBack());
    }

    [TestMethod] 
    public void Removing() {
        dqueue.Push(3, 14, 15);
        dqueue.Remove(14);
        Assert.AreEqual("3 15", dqueue.ToString());
        dqueue.Remove(92);
        Assert.AreEqual("3 15", dqueue.ToString());
        dqueue.Remove(15);
        Assert.AreEqual("3", dqueue.ToString());
        dqueue.Push(1, 2, 3);
        dqueue.Remove(1, 2);
        Assert.AreEqual("3 3", dqueue.ToString());
    }

    [TestMethod]
    public void Find() {
        dqueue.Push(3, 14, 15);
        Assert.AreEqual("0", string.Join(',', dqueue.FindValue(3)));
        Assert.AreEqual("1", string.Join(',', dqueue.FindValue(14)));
        Assert.AreEqual("2", string.Join(',', dqueue.FindValue(15)));
    }

    [TestMethod] 
    public void Demo() {
        dqueue.PushBack(1, 2);
        dqueue.Push(3, 4);
        Assert.AreEqual("3 4 1 2", dqueue.ToString());
        Assert.AreEqual(3, dqueue.Pop());
        Assert.AreEqual(2, dqueue.PopBack());
        Assert.AreEqual("4 1", dqueue.ToString());
        dqueue.Remove(4);
        dqueue.Remove(5);
    }
}