n = input()
string = input()

x = string.find("lv")
if not x == -1:
    print(0)
else:
    x = string.find("l")
    if not x == -1:
        print(1)
    else:
        x =string.find("v")
        if not x == -1:
            print(1)
        else:
            print(2)