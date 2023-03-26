# Контрольная работа по курсу "Итоги блока. Выбор специализации"

**Данная работа выполнена Дмитрием Герасимчуком**

_Работа выполнена с целью демонстрации полученных знаний и навыков по итогу прохождения первого блока обучения на программе разработчик_

Результаты итоговой работы представляют собой:

1. Созданный репозиторий на портале GitHub. _Подтверждение_: рабочая ссылка на GitHub, которая прикреплена на платформе GeekBrains: https://github.com/DmitryGerasimchuk/FinalTask.git

2. Созданный текстовый файл README.md, содержащий описание работы. В указанном документе написан текст, отражаюший суть представленной контрольной работы. В качестве языка был использован язык разметки Markdown. _Подтверждение_: файл README.md создавался в программе VSCode в начале выполнения проекта.

3. Блок-схема алгоритма решения задачи. _Подтверждение_: для понимания алгоритма работы программы, было принято решение его визуализировать (нарисовать) в специализированной программе **draw.io**.

Блок-схема **Graphic solution** представлена в 2-х форматах: картинки (расширение:png) и формат программы (расширение:drawio).

4. Решение задачи при помощи языка программирования С#:

   Условие задачи:

   "Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

   Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами"

   В качестве проверки решения задачи в условии написано:

   ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

   ['1234", "1567", "-2", "computer science"] -> ["-2"]

   ["Russia", "Denmark", "Kazan"] -> []

_Подтверждение_: в связи с тем, что условие задачи содержит ряд допущений, которые разработчик может истолковывать самостоятельно, было принято решение решать задачу максимально просто. Поэтому массив изначально был заполнен данными заказчика по условию задачи.

В связи с чем, задача решалась простым алгоритмом:

- все значения для проверки из ТЗ, внести в первый массив;
- создать пустой массив, длина которого должна равняться суммарному значению элементов для проверки (вдруг, все элементы будут не превышать 3 символа);
- обычным перебором элементов первого массива (с использованием цикла) найти элементы, длина которых не превышает 3 символов;
- записать выявленые элементы во второй массив;
- вывести на экран значения второго массива.

5. Заливка полученного решения задачи заказчика, файла README.md, картинки с блок-схемой решения задачи на портал GitHub при помощи нескольких сохранений (коммитов).
