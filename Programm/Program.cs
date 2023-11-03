foreach (string arg in args) {
    switch (arg) {
        case "--stack":
            RunStack();
            break;
        case "--queue":
            RunQueue();
            break;
        case "--dqueue":
            RunDQueue();
            break;
        case "--brackets":
            RunBrackets();
            break;
    }
}

void RunStack() {
    Lib.MyStack<int> stack = new Lib.MyStack<int>();
    while (true) {
        string[] cmd = Console.ReadLine()!.Split(' ');
        switch (cmd[0]) {
            case "push":
                int value = Convert.ToInt32(cmd[1]);
                stack.push(value);
                break;
            case "pop":
                Console.WriteLine(stack.pop());
                break;
            case "back":
                Console.WriteLine(stack.back());
                break;
            case "size":
                Console.WriteLine(stack.Size());
                break;
            case "clear":
                stack.clear();
                Console.WriteLine("ok");
                break;
            case "print":
                Console.WriteLine(stack.ToString());
                break;
            case "exit":
                Console.WriteLine("Bye");
                return;
            default:
                Console.WriteLine("Wrong command");
                break;
        }
    }
}

void RunQueue() {
    Lib.MyQueue<int> queue = new Lib.MyQueue<int>();
    while (true) {
        string[] cmd = Console.ReadLine()!.Split(' ');
        switch (cmd[0]) {
            case "push":
                int value = Convert.ToInt32(cmd[1]);
                queue.Push(value);
                break;
            case "pop":
                Console.WriteLine(queue.Pop());
                break;
            case "front":
                Console.WriteLine(queue.Front());
                break;
            case "size":
                Console.WriteLine(queue.Size());
                break;
            case "clear":
                queue.Clear();
                Console.WriteLine("ok");
                break;
            case "print":
                Console.WriteLine(queue.ToString());
                break;
            case "exit":
                Console.WriteLine("Bye");
                return;
            default:
                Console.WriteLine("Wrong command");
                break;
        }
    }
}

void RunDQueue() {
    Lib.DQueue<int> dqueue = new Lib.DQueue<int>();
    while (true) {
        string[] cmd = Console.ReadLine()!.Split(' ');
        switch (cmd[0]) {
            case "push":
                int value_1 = Convert.ToInt32(cmd[1]);
                dqueue.Push(value_1);
                break;
            case "pushback":
                int value_2 = Convert.ToInt32(cmd[1]);
                if (cmd.Length > 1)
                    dqueue.PushBack(value_2);
                break;
            case "pop":
                Console.WriteLine(dqueue.Pop());
                break;
            case "popback":
                Console.WriteLine(dqueue.PopBack());
                break;
            case "remove":
                int value_3 = Convert.ToInt32(cmd[1]);
                if (cmd.Length > 1)
                    dqueue.Remove(value_3);
                break;
            case "print":
                Console.WriteLine(dqueue.ToString());
                break;
            case "find":
                int value_4 = Convert.ToInt32(cmd[1]);
                Console.WriteLine(string.Join(',', dqueue.FindValue(value_4)));
                break;
            case "exit":
                Console.WriteLine("Bye");
                return;
            default:
                Console.WriteLine("Wrong command");
                break;
        }
    }
}

void RunBrackets() {
    while(true) {
        string? exp = Console.ReadLine();
        Console.WriteLine(Lib.Brackets.CheckBrackets(exp!));
    }
}