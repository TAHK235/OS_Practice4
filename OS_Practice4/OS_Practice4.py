import time


def f(arg, b, c):
    if arg == 0:
        return 0
    a = 0
    for i in range(1, 100000000):
        a += 2 * b + c - arg
    return f(arg - 1, b, c) + a


print("Введите i, b, c")
arg = int(input())
b = int(input())
c = int(input())
print("Считаем...")
start_time = time.monotonic()
result = f(arg, b, c)
print("Время: " + str(time.monotonic() - start_time))
print("Ответ: " + str(result))
input()
