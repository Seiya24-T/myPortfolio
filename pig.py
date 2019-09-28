import random as rd

def dice():
    return rd.randint(1, 6)


def main():
    goal = int(input("目標点数は？"))
    mPoint = 0
    ePoint = 0
    while(True):
        # 自分のターン
        print("\nYour turn!")
        mini_sum = 0
        input()
        while(True):
            print("ダイスを振りますか？")
            print("1:YES")
            print("2:NO")
            command = int(input())
            if command == 1:
                d = dice()
                print(str(d) + "が出ました")
                if d == 1:
                    print("アウトです")
                    mini_sum = 0
                    break
                else:
                    mini_sum += d
                    print("只今" + str(mini_sum) + "point です")
            if command == 2:
                mPoint += mini_sum
                break

        print("Your  point:" + str(mPoint))
        print("Enemy point:" + str(ePoint))

        if mPoint >= goal:
            print("You win!")
            break

        # 敵のターン
        print("\nEnemy turn!")
        mini_sum = 0
        input()
        while(True):
            go = dice()
            if mini_sum == 0 or go != 1:
                d = dice()
                print(str(d) + "が出ました")
                if d == 1:
                    print("アウトです")
                    mini_sum = 0
                    break
                else:
                    mini_sum += d
                    print("只今" + str(mini_sum) + "point です")
            else:
                ePoint += mini_sum
                break
        input()
        print("Your  point:" + str(mPoint))
        print("Enemy point:" + str(ePoint))

        if ePoint >= goal:
            print("Enemy win!")
            break


if __name__ == "__main__":
    main()
