# Задание 6: CheckedListBox

Задание: Разработать форму для обмена ресурсами. Предварительно создать 2 глобальных массива и заполнить их любыми значениями.

Компоненты на форме:
- 2 `checkedListBox`
- 2 `textBox`
- 26 `button`

Свойства `checkedListBox`:
- `CheckOnClick` - true
- `Sorted` - true

Назначения кнопок:
- `Clear` - удаляет все элементы списка
- `Снять выделенное` - убирает выделение (цвет)
- `+` - добавляет текст к соответствующему списку. Не добавляйте пустые строки
- `Снять check` - убирает все пометки (галочка)
- `Check all` - Помечает все элементы
- `>+` - копирует из левого списка в правый выделенный элемент (без удаления)
- `>>+` - копирует из левого списка в правый помеченный элемент
- `-` - убирает из списка помеченные элементы
- `>` - перемещает из левого списка в правый выделенный элемент (с удалением)
- `>>` - перемещает из левого списка в правый помеченный элемент
- `Убрать дубликаты` - удаляет повторяющиеся элементы
- `Из массива` - добавляет в список элементы из массива
- `В массив` - добавляет в массив элементы из массив
- `<`, `<<`, `<+` `<<+` - аналогично, но в другую сторону

![](https://github.com/kefaxoo/csharp-bsuir/raw/main/courses/l6/images/Picture%201.png)