import random

myHand = {
    'gu': 2,
    'tyoki': 2,
    'pa': 2
}

enHand = {
    'gu': 2,
    'tyoki': 2,
    'pa': 2
}

Hand = 'gu', 'tyoki', 'pa'

myPoint = 0
enPoint = 0
turn = 0

while(True):
    turn += 1
    print("ターン " + str(turn))
    print("じゃんけん...")

    print("1:グー x " + str(myHand['gu']))
    print("2:チョキ x " + str(myHand['tyoki']))
    print("3:パー x " + str(myHand['pa']))
    while(True):
        my_num = int(input())
        if myHand[Hand[my_num - 1]] >= 1:
            myHand[Hand[my_num - 1]] -= 1
            break
        else:
            print(Hand[my_num - 1] + "はもう使えません")

    while(True):
        en_num = random.randint(1, 3)
        if enHand[Hand[en_num - 1]] >= 1:
            enHand[Hand[en_num - 1]] -= 1
            break
    
    print("自分:" + Hand[my_num - 1])
    print("相手:" + Hand[en_num - 1])

    if my_num == en_num:
        print("あいこです")
    elif my_num - en_num == 1 or en_num - my_num == 2:
        print("負けました！")
        enPoint += 1
    elif en_num - my_num == 1 or my_num - en_num == 2:
        print("勝ちました！")
        myPoint += 1

    print("\nあなたのポイント:" + str(myPoint))
    print("相手のポイント:" + str(enPoint) + "\n")

    if turn == 5:
        break

if myPoint > enPoint:
    print("あなたの勝利です！")
elif enPoint > myPoint:
    print("あなたの敗北です！")
elif myPoint == enPoint:
    print("ドローです！")

input()
