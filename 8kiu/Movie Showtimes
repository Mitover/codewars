def movie_times(open, close, length):
  time=[]
  if close<open:
        close = close +24
  min=0
  time.append((open,min))
  while open%24<close:
    open= open + (length +15+min)//60 
    min = (min+length +15)%60
    if open + (length +min)//60 %24==close and (length +min)%60==0:
        time.append((open%24,min))
        break
    elif open + (length +min)//60 %24  >= close:
       break
    time.append((open%24,min))
  return time
