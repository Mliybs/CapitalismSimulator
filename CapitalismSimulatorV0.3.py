#资本主义模拟器

pause = 0

round = 0

temp = None

number = None

item = None

G = 1000;Pm = 0;A = 0

list = []

listing = []

T1 = {"code":1,"name":"木板","number":0,"Pm":16,"A":4,"m":4,"W":24}

T2 = {"code":2,"name":"螺丝","number":0,"Pm":2,"A":2,"m":2,"W":6}

#数值重置 pause=结束 round=回合 temp=输入缓存 number=数字缓存 item=物件缓存 G=货币 Pm=生产资料 A=劳动力
#list=生产进程 listing=进程陈述
#T1=木板 T2=螺丝 code=编号 name=名称 number=个数 Pm=所需生产资料 A=所需劳动力 m=剩余价值 W=价值

while pause == 0:

    temp = None

    number = None

    item = None

    round += 1

    #缓存重置

    if list != []:
    
        if (list[0])[-1] > 0:

            (list[0])[-1] -= 1

            if (list[0])[0] == 1:

                T1["number"] += 1

                listing[0] = f'{(list[0])[-1]}个木板'

            elif (list[0])[0] == 2:

                T2["number"] += 1

                listing[0] = f'{(list[0])[-1]}个螺丝'

        if (list[0])[-1] == 0:

            del list[0]

            del listing[0]

    #进程刷新

    T1.update({"intro":f'\n{T1["code"]}.{T1["name"]}（生产资料{T1["Pm"]}￥+劳动力{T1["A"]}￥+剩余价值{T1["m"]}￥，总价值{T1["W"]}￥，持有{T1["number"]}个）'})

    T2.update({"intro":f'\n{T2["code"]}.{T2["name"]}（生产资料{T2["Pm"]}￥+劳动力{T2["A"]}￥+剩余价值{T2["m"]}￥，总价值{T2["W"]}￥，持有{T2["number"]}个）'})

    #商品状态更新

    print(f"\n\n————————————————————————————资本主义模拟器回合分界线——第{round}回合————————————————————————————")

    print(f'\n\n货币：{G}￥，生产资料：{Pm}￥，劳动力：{A}￥\n{T1["intro"]}\n{T2["intro"]}\n\n目前在生产的商品有：',*listing)

    temp = input("\n\n跳过本回合输入0，购买生产资料输入1，购买劳动力输入2，进行生产活动输入3，售卖商品输入4，输入其它值结束游戏（不保存）：")

    number = abs(int(temp))

    temp = None

    if  number == 0:

        print("\n\n本回合跳过！")

    elif number == 1:

        #进入生产资料购买

        temp = input(f'\n\n你要购买多少￥的生产资料呢？最多可购买{G}￥')

        number = abs(int(temp))

        if number <= G:

            G -= number

            Pm += number

        else:

            print("\n\n你所持有的￥不够！")

    elif number == 2:

        #进入劳动力购买

        temp = input(f'\n\n你要购买多少￥的劳动力呢？最多可购买{G}￥')

        number = abs(int(temp))

        if number <= G:

            G -= number

            A += number

        else:

            print("\n\n你所持有的￥不够！")

    elif number == 3:

        #进入生产活动

        temp = input(f'\n\n你要生产哪种商品呢？\n{T1["intro"]}，最多可生产{min(Pm//T1["Pm"],A//T1["A"])}个\n{T2["intro"]}，最多可生产{min(Pm//T2["Pm"],A//T2["A"])}个：')

        item = abs(int(temp))

        list.append([item])

        if item != T1["code"] and item != T2["code"]:

            print("\n\n没有输入有效值！本回合结束！")

        else:
            
            temp = None

            temp = input("\n\n你要生产几个呢？")

            number = abs(int(temp))

            if item == T1["code"] and number * T1["Pm"] <= Pm and number * T1["A"] <= A:                

                (list[-1]).append(number)

                listing.append(f'{(list[-1])[-1]}个木板')

                Pm -= number * T1["Pm"]

                A -= number * T1["A"]

            elif item == T2["code"] and number * T2["Pm"] <= Pm and number * T2["A"] <= A:

                (list[-1]).append(number)

                listing.append(f'{(list[-1])[-1]}个螺丝')

                Pm -= number * T2["Pm"]

                A -= number * T2["A"]

            else:

                print("\n\n你所持有的生产资本不够！")

    elif number == 4:

        #进入商品售卖

        temp = input(f'\n\n你要售卖哪种商品呢？\n{T1["intro"]}\n{T2["intro"]}：')

        item = abs(int(temp))

        if item != T1["code"] and item != T2["code"]:

            print("\n\n没有输入有效值！本回合结束！")

        else:

            temp = None

            temp = input("\n\n你要售卖几个呢？")

            number = abs(int(temp))

            if item == T1["code"] and number <= T1["number"]:

                G += number * T1["W"]

                T1.update({"number":T1["number"]-number})

            elif item == T2["code"] and number <= T2["number"]:

                G += number * T2["W"]

                T2.update({"number":T2["number"]-number})

            else:

                print("\n\n你所持有的商品不够！")

    else:

        print("\n\nadieu~")

        pause = 1
