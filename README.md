# Итоговая проверочная работа.

## *Задача :*

### *Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трем(3) символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

#### *Примеры :*
#### ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
#### ["1234", "1567", "-2", "computer science"] -> [ "-2"]
#### ["Russia", "Denmark", "Kazan"] -> []

## Описание алгоритма решения:

#### *В начале объявляется два массива: первичный и вторый такой же длины. Затем метод, в котором цикл соразмерный длине массива, внутри цикла проверка условия ( <=3 ), если "да" элемент первого массива заносится в count элемент второго массива. Переменная count чтобы поочередно закидывать из первого массива во второй и чтобы потом не было пробелов. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца.*

## Графическое представление метода в папке Block_Diagram

## Реализация алгоритма по пути TaskWork/Program.cs