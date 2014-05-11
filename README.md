PacmanWorld
=========•	PamanWord е игра во која херојот се движи (со стрелките)низ својот свет и јадеќи ја храната (се генерира случајно во секоја нова игра), собира поени (вкупно 200) за да победи и да отиде на следно ниво.Секој портокал што го јаде носи 2 поени, секој лимон носи 3 поени, додека печурката му одзема еден живот. Ако изеде 10 печурки играта звршува.Патот на херојот е отежнат заради блоковите ( се генерираат случајно),низ кои не може да помине.Ако се удри во блок кога се движи  на лево,насоката на херојот автоматски се менува на десно. Ако се удри во блок кога се движи  на десно,насоката на херојот автоматски се менува на лево Ако се удри во блок кога се движи  нагоре,насоката на херојот автоматски се менува надолу. Ако се удри во блок кога се движи  надолу лево,насоката на херојот автоматски се менува нагоре.
•	Класата Pacman го претставува херојот, кој ја јаде храната (сликите) во мапата.Во неа чувам податоци за позицијата X и  Y , насоката во која се движи ,поените кои ги собира, животите кои ги има ,бојата на четката со која го цртаме. Во конструкторот на класта(кој прима аргументи X,Y ,позиција) ги иницијализирам променливите(насоката ја поставувам на десно) .  Во оваа класа имаме метод Move(за придвижување и исцртување  на херојот), во зависност од насоката.Класата Element е абстрактна  класа, од која се наследуваат класите  Block, Food1, Food2,  Mushrooms .Секоја од овие класи  го имплемнтира bool методот Dopir(Pacman p)  и во конструкторот на секоја од овие класи јсе вчитува сликата за соодветниот елемент што треба да се постави  во мапата.Притоа се преоптоварува конструкторот на двете класи, со аргумент int . Ако променливатa resourceId  се иницијализира на 1,тогаш се вчитува сликата за првото ниво, додека ако променливата ја иницијализира на 2 , се вчитува сликата за второто ниво. Во класите Food1, Food2,  во методот Dopir() ги поставувам поените на херојот да се зголемуваат за 3,2 додека во класата Mushrooms во методот Dopir() ги намалувам животите на херојот за еден.Во овие класи bool  методот Dopir(Pacman p)  враќа вредност true, за да може херојот да се придвижува низ нив. Класата Blocks (за претсатвување на препреките низ кои херојот не може да се движи)го имплементира методот Dopir(Pacman p) така што ја користиме switch- case наредбата за да можеме во зависност од насоката на херојот ако стигне до блок да ја поставиме неговата следна насока. Ако се удри во блок кога се движи  на десно,насоката на херојот автоматски се менува на лево .Ако се удри во блок кога се движи  нагоре,насоката на херојот автоматски се менува надолу. Ако се удри во блок кога се движи  надолу лево,насоката на херојот автоматски се менува нагоре. Во оваа класа методот ни врќа false вредност за херојот да не може да се движи низ оваа поле.Во главната форма се имплементираат методите  NewGame() и InitLevel2(). Во констукторот се повикува метдот NewGame() со кој се стартува нова игра. Во овој метод се иницијализира нова игра.Притоа се поставуваат големината и ширината на формата, се истанцира објект од класата Pacman, се инстанцира нов објект од класата Timer и го поставувам неговиот интервал на 400. Се  имплементира  неговиот метод  Tick и се повикува методот за стартување.Потоа ја иницијализирам матрицата од класата Element  така што сите елементи храната, печурката и блоковите се поставуваат  Random низ матрицата од елементи.Се имплементира Timer_Tick  настанот, при што се ажуира состојбата на играта.Се изминува матрицата и во зависност од тоа дали херојот се наоѓа на соодветното поле од матрицата ,тоа се поставува на null(изедено).Во Timer_Tick   го имплемнтирам методот за исцртување на состојбата на играта. Со соодветни циклуси се проверуват поените и животите на херојот.Ако има повеке од 200 поени се повикува методот InitLevel2(), при што започнува второто ниво на играта.Ако животите на херојот се помалку од четири се менеува бојата на Pacman,додека ако поените станат еднакви на 0, играта заврсува при што се покажува диалог, со вкупните поени.
•	Освен идејата за играта,сите функции и класи од проектот се пишувани од мене.
<img src="https://fbcdn-sphotos-h-a.akamaihd.net/hphotos-ak-prn1/v/t35.0-12/10358820_10203660771268285_1329340129_o.jpg?oh=debe58fcdda22a414ffa721003d87a72&oe=53712E53&__gda__=1399936846_6ca92fb8fee2e2e234fedaac4f59a526" alt="Level1"/>

•	Кога започнува играта портокалите,лимонит, печурките и блоковите се генерираат Random.
Херојот се движи со помош на стрелките (лево, десно,горе,долу) ←, →  ,  . Целта на играта е да собере 200 поени и да помине на следното ниво. Секој портокал што го јаде носи 2 поени, секој лимон носи 3 поени, додека печурката му одзема еден живот. Ако изеде 10 печурки играта звршува.Патот на херојот е отежнат заради блоковите ( се генерираат случајно),низ кои не може да помине.Ако се удри во блок кога се движи  на лево,насоката на херојот автоматски се менува на десно. Ако се удри во блок кога се движи  на десно,насоката на херојот автоматски се менува на лево Ако се удри во блок кога се движи  нагоре,насоката на херојот автоматски се менува надолу. Ако се удри во блок кога се движи  надолу лево,насоката на херојот автоматски се менува нагоре.Во статусната лента се покажуваат вкупните поени и животи што ги има во моментот.Кога на херојот ќе му преостанат три животи , неговата боја се менува во жолта.Ако животите се намалат до 0 играта завршува и се отвара нова форма во која се испишуваат вкупните поени. 
Ако Pacman собере 200 поени , а не ги истроши своите животи преминува на следното ниво, каде се зголемува брзината со која се движи.Животите му се пренесуваат од претходното ниво, додека поените му започнуваат од нула.
<img src="https://fbcdn-sphotos-h-a.akamaihd.net/hphotos-ak-prn2/v/t35.0-12/10340450_10203662597193932_2062192979_o.jpg?oh=acaa55552a88b10590091bd9a3917b5c&oe=53715183&__gda__=1399931687_132f34d2e4d1be278b34ed7b835fe214" alt="Level2" />
 

           



