#资本主义模拟器

pause = 0

round = 0

temp = None

number = None

item = None

G = 1000;Pm = 0;A = 0

T1 = {"code":1,"name":"木板","number":0,"Pm":16,"A":4,"W":20}

T2 = {"code":2,"name":"螺丝","number":0,"Pm":2,"A":2,"W":4}

#数值重置 pause=结束 round=回合 temp=输入缓存 number=数字缓存 item=物件缓存 G=货币 Pm=生产资料 A=劳动力
#T1=木板 T2=螺丝

while pause == 0:

    temp = None

    number = None

    item = None

    round += 1

    #缓存重置

    print(f"\n\n————————————————————————————资本主义模拟器回合分界线——第{round}回合————————————————————————————")

    print(f'\n\n货币：{G}￥，生产资料：{Pm}￥，劳动力：{A}￥\n\n{T1["name"]}（{T1["Pm"]}+{T1["A"]}）：{T1["number"]}个，{T2["name"]}（{T2["Pm"]}+{T2["A"]}）{T2["number"]}个')

    temp = input("\n\n结束（不保存）输入0，购买生产资料输入1，购买劳动力输入2，进行生产活动输入3，售卖商品输入4：")

    number = int(temp)

    temp = None

    if  number == 0:

        print("\n\nadieu~")

        pause = 1

    elif number == 1:

        #进入生产资料购买

        temp = input("\n\n你要购买多少￥的生产资料呢？")

        number = int(temp)

        if number <= G:

            G -= number

            Pm += number

        else:

            print("\n\n你所持有的￥不够！")

    elif number == 2:

        #进入劳动力购买

        temp = input("\n\n你要购买多少￥的劳动力呢？")

        number = int(temp)

        if number <= G:

            G -= number

            A += number

        else:

            print("\n\n你所持有的￥不够！")

    elif number == 3:

        #进入生产活动

        temp = input(f'\n\n你要生产哪种商品呢？\n{T1["code"]}.{T1["name"]}（{T1["Pm"]}+{T1["A"]}）{T2["code"]}.{T2["name"]}（{T2["Pm"]}+{T2["A"]}）：')

        item = int(temp)

        if item != T1["code"] and item != T2["code"]:

            print("\n\n没有输入有效值！本回合结束！")

        else:
            
            temp = None

            temp = input("\n\n你要生产几个呢？")

            number = int(temp)

            if item == T1["code"] and number * T1["Pm"] <= Pm and number * T1["A"] <= A:                

                T1.update({"number":number})

                Pm -= number * T1["Pm"]

                A -= number * T1["A"]

            elif item == T2["code"] and number * T2["Pm"] <= Pm and number * T2["A"] <= A:

                T2.update({"number":number})

                Pm -= number * T2["Pm"]

                A -= number * T2["A"]

            else:

                print("\n\n你所持有的生产资本不够！")

    elif number == 4:

        #进入商品售卖

        temp = input(f'\n\n你要售卖哪种商品呢？\n{T1["code"]}.{T1["name"]}（{T1["Pm"]}+{T1["A"]}）{T2["code"]}.{T2["name"]}（{T2["Pm"]}+{T2["A"]}）：')

        item = int(temp)

        if item != T1["code"] and item != T2["code"]:

            print("\n\n没有输入有效值！本回合结束！")

        else:

            temp = None

            temp = input("\n\n你要售卖几个呢？")

            number = int(temp)

            if item == T1["code"] and number <= T1["number"]:

                G += number * T1["W"]

                T1.update({"number":T1["number"]-number})

            elif item == T2["code"] and number <= T2["number"]:

                G += number * T2["W"]

                T2.update({"number":T2["number"]-number})

            else:

                print("\n\n你所持有的商品不够！")

    else:
        print("\n\n没有输入有效值！本回合结束！")
