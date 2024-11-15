# GameHost

Разработать игра угадай число по принципу SOLID

Решение состоит из 3 проектов:
 - [GameDomain](https://github.com/PiterPoker/GameHost/tree/main/GameDomain) реализует базовые классы решения
 - [GameHost.App](https://github.com/PiterPoker/GameHost/tree/main/GameHost.App) реализует консольное приложение для запуска проекта
 - [GuessNumber](https://github.com/PiterPoker/GameHost/tree/main/GuessNumber) реализует игру угадай число

# Понимание SOLID
SOLID - это набор из пяти принципов объектно-ориентированного программирования, направленных на создание более гибкого, расширяемого и поддерживаемого кода. Давайте рассмотрим, как эти принципы могут быть применены в нашей игре.

 1. Принцип единственной ответственности (Single Responsibility Principle, SRP). Каждый класс должен иметь только одну причину для изменения.
  
    1.1. Класс GuessNumberGame: Управляет игровым процессом (начало, конец игры, подсчет попыток).
    
    1.2. Класс NumberGenerator: Генерирует случайное число.
    
    1.3. Класс Validator: Проверяет корректность введенных данных и т. д.
    
 2. Принцип открытости/закрытости (Open-Closed Principle, OCP). Объекты должны быть открыты для расширения, но закрыты для модификации.
 
    2.1. Использование абстрактных классов (класс Game) и интерфейсов (INumberGeneratorService, IValidator и т.д.) для определения поведения.

    2.2. Добавление новых типов форматов вывода (NumericInputValidator, RangeInputValidator, CompositeValidator) без изменения существующего кода.
    
 3. Принцип подстановки Барбары Лисков (Liskov Substitution Principle, LSP). Объекты в программе должны быть заменяемыми их подтипами без изменения корректности программы.

    3.1. Подклассы IValidator должны быть заменяемы базовым классом без нарушения корректности программы.

 4. Принцип разделения интерфейса (Interface Segregation Principle, ISP). Клиенты не должны зависеть от методов, которые они не используют.

    4.1. Разделение интерфейсов на более мелкие, специфические интерфейсы. Например, интерфейс CompositeValidator имеет реализацию методов для удаление/добавления проверки в список проверок интерфейс ICompositeValidator и метод проверки на правильность ввода значения интерфейс IValidator.
    
 5. Принцип инверсии зависимостей (Dependency Inversion Principle, DIP). Зависимости должны направлены на абстракции, а не на конкретные реализации.

    5.1. Использование абстрактных классов (Game для запуска проекта) и интерфейсов для определения зависимостей.

    5.2. Внедрение зависимостей через конструкторы или свойства.
