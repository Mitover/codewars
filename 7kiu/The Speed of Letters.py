def speedify(st): 
    print(st)
    alf="ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    c=" "
    b=[]
    for i in range(len(st)):
        b.append(alf.index(st[i])+ 1 + i)
    if len(b)==0:
        return ""
    c=c*max(b)
    c=list(c)
    print(c)
    for i in range(len(st)):
        c[alf.index(st[i])+i] = st[i] 
    return "".join(c)
