import  random
i =1
ball = 0
while (i<=3):
    print(f"Попытка {i}")
    pol = int(input("ведите число "))
    p1 = random.randint(1,24)
    p2 = random.randint(1, 24)
    p3 = random.randint(1, 24)
    print(f"Программа {p1} {p2} {p3}")
    if (pol == p1) or (pol == p2) or (pol == p3):
        print("1 балл")
        i+=1
        ball+=1
    else:
        i+=1
if ball >=2:
    print("Вы выиграли")
else:
    print("Вы проиграли")
