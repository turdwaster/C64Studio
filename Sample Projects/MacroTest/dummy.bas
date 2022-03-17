#C64Studio.MetaData.BASIC:2049,BASIC V2
2 REM ****CHAPTER 33***********
10 FOR S=54272TO54296:POKES,0:NEXT
15 M=54272
20 DIM H(500,2),L(500,2),D(500,2)
30 V(0)=17:V(1)=17:V(2)=17
40 REM ***LOAD ARRAY****
100 FOR K=0 TO 2 
110 I=0
120 READ N,DR 
130 IF DR=0 THEN 200
140 WF=V(K):WX=WF-1
150 HF%=N/256:LF%=N-256*HF%
160 IF DR=1 THEN H(I,K)= HF%:L(I,K) = LF%:D(I,K)=WF:I=I+1:GOTO120
170 FOR J=1TODR-1:H(I,K)= HF%:L(I,K) = LF%:D(I,K)=WF:I=I+1:NEXT
180 H(I,K)= HF%:L(I,K) = LF%:D(I,K)=WX
190 I=I+1:GOTO120
200 NEXT K

210END

250 REM ****SOUND SETTINGS****
300 POKE 54277,0:POKE 54278,255
310 POKE 54284,0:POKE 54285,255
320 POKE 54291,0:POKE 54292,255
330 POKE 54296,15

399 REM ******FACING THE MUSIC******
400 P1=0:P2=0:P3=0
410 POKE 54272,L(P1,0):POKE 54273,H(P1,0)
420 POKE 54279,L(P2,1):POKE 54280,H(P2,1)
430 POKE 54286,L(P3,2):POKE 54287,H(P3,2)
440 POKE 54276,D(P1,0):POKE 54283,D(P2,1):POKE 54290,D(P3,2)
445 FOR T=1 TO 3:NEXT T
450 P1=P1+1:P2=P2+1:P3=P3+1
455 IF D(P1,0)=0 THEN2000
460 IF D(P2,1)=0 THEN2500
465 IF D(P3,2)=0 THEN3000

470 GOTO 410
600 REM ***** LESS DATA! *******
610 DATA 0,1,1432,2,3406,2,3215,2,2864,2,3215,2,3406,2
620 DATA 2145,12
630 DATA 1432,2,3406,2,3215,2,2864,2,3215,2,3406,2
640 DATA 4291,6,2145,6,0,0
700 DATA 0,1,0,48,5728,2,6218,2,5103,2,6430,2,5728,2,6812,2
710 DATA 8583,2,7647,2,6812,2,6430,2,5728,2,5103,2,0,0
800 DATA 0,1,0,96,17167,40,11457,4,17167,4,15294,4,11457,4,15294,40,11457,4
810 DATA 15294,4,13625,24,11457,24,12860,40,11457,4,9634,4,8583,44,11457,4
820 DATA 12860,40,11457,4,8583,4,7647,48,0,0

2000 P1=1:GOTO460
2500 P2=49:GOTO 465
3000 P3=1:P2=1:RESTORE:GOTO410
