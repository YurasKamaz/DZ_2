namespace Lib;

public static class Brackets {
    public static string CheckBrackets(string exp){
        MyStack<char> stack = new MyStack<char>();

        for(int i = 0; i<exp.Length; i++) {
            char character = exp[i];
            if(character=='(') stack.push(character);
            else if(character==')') {
                if(stack.Size() == 0) return $"нет\nПозиция первой лишней закрывающей скобки: {i + 1}";
                else stack.pop();
            }
        }

        if(stack.Size() > 0) return $"нет\nКоличество лишних открывающих скобок: {stack.Size()}";
        return "да\nСкобки расставлены правильно.";
    }
}

// $"нет\nПозиция первой лишней закрывающей скобки: {i + 1}";
// $"нет\nКоличество лишних открывающих скобок: {stack.Size()}";
// "да\nСкобки расставлены правильно.";