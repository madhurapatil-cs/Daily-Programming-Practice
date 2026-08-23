n = int(input("Enter a number: "))

original = n
sum = 0

while n > 0:
    digit = n % 10
    fact = 1

    for i in range(1, digit + 1):
        fact *= i

    sum += fact
    n //= 10

if sum == original:
    print(original, "is a Strong Number.")
else:
    print(original, "is not a Strong Number.")