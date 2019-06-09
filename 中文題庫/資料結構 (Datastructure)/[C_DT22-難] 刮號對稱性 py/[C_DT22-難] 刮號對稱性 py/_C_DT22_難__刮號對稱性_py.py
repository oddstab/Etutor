while True:
    s = input()
    L=0;R=0
    s = input()
    if s == "end":break
    for i in range(len(s)):
        if s[i]=="(":L+=1
        else :
            R+=1
            if L!=0 : L-=1;R-=1
    if L==0 and R ==0:print(1)
    else:print(-1)