r= float(input());n = int(input());p = int(input());sum=0
for i in range(n):
    sum += p +(sum+p)*r
print(int(sum))