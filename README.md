# Booking Hotel
## Описание сайта

Сайт букинга отелей разных классов, присутствует регистрация пользователя, просмотр каталога, возможность резервации отелей. Сайт предоставляет возможность пользования клиентом и менеджером отелей.

## Используемые технологии:
  - ASP.NET CORE
  - SQL Server

## Свойства модулей
### Свойства модуля 1: 
#### Работа с Аккаунтом:
	1) просмотр аккаунта;
	2) изменение данных аккаунта;
	3) удаление аккаунта;

#### Работа с бронью:
	1) Просмотр бронирования клиента;
	2) Отмена брони;
	3) Оформление брони;
	4) просмотр брони.

### Свойства модуля 2: 
#### Работа с отелями:
	1) Просмотр отелей с фильтрацией
	2) Просмотр отелей
	3) Добавление отеля в избранное
### Свойство модуля 3:
	1) Регистрация
### Свойство модуля 4:
	1) Вход
	
    
## Достоинства Sql Server
  - Продукт подходит для широкого спектра задач
  - Позволяет длительно хранить данные
  - Позволяют хранить структурированную информацию, которая всегда классифицируется по одним и тем же критериям и не изменяется.
  - Возникновение ошибок в данных практически невозможно

## Причины для использования SQL Server
 1. SQL Server упрощает развертывание, передачу и интеграцию больших данных
Решение для обработки больших данных на основе Kubernetes, встроенное в SQL Server, позволяет легко развернуть кластер больших данных и работать с ним. Kubernetes обеспечивает развертывание хранилищ HDFS, реляционного модуля SQL Server и средств аналитики Spark в виде контейнеров в рамках одного удобного пакета.
В состав SQL Server 2019 входят Spark и HDFS, которые позволяют выполнять чтение и запись непосредственно в HDFS, используя SQL Server или Spark.  Архитектура Kubernetes обеспечивает гибкое масштабирование вычислительных мощностей и хранилищ по запросу
 2. Интеграция структурированных и неструктурированных данных
Сегодняшние объемы данных делают неразумным и невыгодным конвертацию всех доступных данных в реляционные таблицы для хранения в СУБД. Еще 2 года назад Microsoft представила технологию PolyBase, позволяющую экземпляру SQL Server обрабатывать запросы Transact-SQL, которые обращаются к данным Hadoop и объединять данные из Hadoop и SQL Server. В SQL Server внешняя таблица или внешний источник данных обеспечивает соединение с Hadoop, виртуализируя внешние источники данных без необходимости их прямого импорта в реляционную базу, и потом позволяет обращаться к этим данным с запросами.

Таким образом, данные накапливаются в своем естественном формате, не обязательно реляционном, но могут быть представлены в виде виртуальной таблицы. Виртуализация позволяет интегрировать данные разного формата, из разнородных источников и мест хранения без их репликации и перемещения, создавая единую виртуальную матрицу данных.



 3. Высокая производительность
Не первый год Microsoft подтверждает высокую производительность SQL Server транзакционными тестам и тестами производительности хранилищ данных. Версия 2019 отмечена отличными результатами в следующих тестах:

- производительность OLTP;
- производительность DW для 1 ТБ, 10 ТБ и 30 ТБ;
- соотношение цены и производительности OLTP;
- соотношение цены и производительности DW для 1 ТБ, 10 ТБ и 30 ТБ.
 4. Поддержка постоянной памяти (РМЕМ)
Постоянная память (Persistent Memory, PMEM) – это быстрая память, обладающая возможностью хранить данные после отключения питания. Она позволяет обрабатывать данные in-memory, избавляя от необходимости передавать данные по каналам передачи и ускоряя обработку запросов на 30% для интенсивных рабочих нагрузок ввода-вывода.

Любой файл SQL Server, помещенный на устройство PMM, теперь доступен напрямую, минуя стек хранения операционной системы, используя эффективные операции memcpy.

 5. Гибридная транзакционная/аналитическая обработка (НТАР)
Модель HTAP позволяет одновременно осуществлять операционные транзакции и аналитику на одних и тех же данных в одной и той же памяти, также реализуя подход in memory.

 6. Интеллектуальная обработка запросов
Параллелизация запросов и улучшенное масштабирование частых запросов благодаря механизмам интеллектуальной обработки запросов делают производительность значительно выше. Отложенная компиляция табличных переменных более чем на 50% ускоряет обработку запросов.

Семейство функций интеллектуальной обработки запросов



Приложения и инструменты аналитики работают со всеми реляционными и большими данными через ведущий экземпляр SQL Server при помощи T-SQL

7. Безопасность и соответствие требованиям
Защита конфиденциальных данных при помощи технологии Always Encrypted с защищенными анклавами. Шифрование на месте позволяет выполнять криптографические операции с конфиденциальными данными без их перемещения за пределы базы данных.

Криптографические операции включают в себя шифрование столбцов, и эти операции теперь можно выполнять с помощью Transact-SQL, они не требуют перемещения данных из базы данных. Внутри защищенных анклавов поддерживаются все полнофункциональные вычисления, включая сопоставления и сравнения диапазонов, что значительно расширяет возможности их применения

Технология Always Encrypted с защищенными анклавами доступна в Windows Server 2019.



8. Azure Data Studio
Azure Data Studio (бывший SQL Operations Studio) – это упрощенное кроссплатформенное графическое средство управления и редактор кода. Позволяет создавать запросы к реляционным и нереляционным базам данных с поддержкой разных операционных систем и источников данных. Azure Data Studio позволяет подключаться к SQL Server локально и в облаке, в Windows, macOS и Linux.

9. Выбор ОС и контейнеров
SQL Server 2019 отличается гибкостью в отношении выбора платформы, языка программирования и средства доставки.

Поддержка Red Hat Enterprise Linux, SUSE Linux Enterprise Server, Ubuntu и Windows.
Контейнеры Docker для Linux и Windows. Установка со встроенной поддержкой инструментов Linux: Yum lnstall, Apt-Get и Zypper.
Один и тот же уровень абстракции с SQL Server на Linux.
Возможность использования R, Python и Java при работе с T-SQL. Теперь расширение языка Java доступно для выполнения кода Java в SQL Server.
10. Интеллектуальный анализ данных
Развитие SQL Server пошлo по пути интеграции с другими аналитическими платформами, в частности Spark, которая включена теперь  в поставку SQL Server.

Spark является очень популярным инструментом для машинного обучения, для продвинутой аналитики, имеет эффективную in memory машину. И все это интегрировано с SQL, который очень эффективен для визуализации аналитики.

Правильный анализ и эффективное представление результатов напрямую влияет на эффективность анализа данных и возможность принимать на их основе управленческие решения.
## Определение API и Endpoint

### Модули api будут использовать 5 моделей для общения:
#### 0. Users
	1)Users_id
	2)Login
	3)Password
	
#### 1. Clients
	1) id_Client
	2) Firstname
	3) Surname
	4) Citizenship
	5) Birtday
	6) Email

#### 2. Orders
	1) Order_ID
	2) Start_Day
	3) End_Day
	4) id_Client
	5) id_Hotel
	6) id_Room

#### 3. Hotel
	1) Name
	2) Images
	3) id_Hotel
	4) Stars
	5) Adress
	6) Features

#### 4. Rooms
	1) id_Room
	2) id_Hotel
	3) Images_Room
	4) Bed
	5) Eat
	6) Free_cancel
	7) Features
	8) Price
	9) Reviews
		
### Работа с аккаунтом:
#### Просмотр аккаунта
##### Get api/clients/{ID:int32};требуется авторизация в роли пользователя
	1) 200 – ok, модель User
	2) 404 – notFound
	3) 401 – unauthorized
#### Изменение данных аккаунта
##### PUT api/clients/{ID:int32}; login, password, firstname,surname, citizenship, birthday, email; nтребуется авторизация в роли пользователя
	1) 200 – OK, модель User
	2) 404 – notFound
	3) 401 – unauthorized
#### Удаление Аккаунта
##### Delete api/clients/{ID:int32}; требуется авторизация в роли пользователя
	1) 204 – noContent
	2) 404 – notFound
	3) 401 - unauthorized
### Работа с бронью:
#### Отмена брони
##### POST – api/Rooms/{Id_Room:int32}, need authorization with User role, Id_Room, ID_Client, Start_Day, End_Day;
	1) 200 – OK
	2) 404 – NotFound
	3) 401 – Unauthorized
#### Просмотр брони
##### POST – api/Rooms/{id_Room:int32}, need authorization with User role, UserModel;
	1) 200 – OK
	2) 404 – NotFound
	3) 401 – Unauthorized
#### Оформление брони
##### POST – api/Rooms/{id_Room:int32}, need authorization with User role, Id_Room, Start_Day, End_Day, Id_Hotel, Id_Client;
	1) 200 – OK
	2) 404 – NotFound
	3) 401 – Unauthorized
#### Просмотр отелей
##### Get api/Hotels, don’t need authorization;
	1) 200 - OK, array of product model
	2) 404 - NotFound
#### Просмотр отелей с фильтрацией
##### POST api/Hotels/Price, don’t need authorization;
	1) 200 - OK, array of product model
	2) 404 - NotFound
#### Добавление отеля в избранное
##### POST api/Hotels/{ID_Hotel:int32}, need authorization with user role;
	1) 204 - noContent
	2) 404 - NotFound
	3) 401 – Unauthorized
#### Создание Аккаунта
##### POST api/clients/registration; login, password, firstname, surname, citizenship, birthday, email;
	1) 201 – Created, модель User
	2) 406 - notAcceptable
#### Вход в аккаунт
##### POST api/clients/authorization; login, password, firstname, surname, citizenship, birthday, email;
	1) 200 – Ok, модель User
	2) 404 – notFound

### Диаграмма базы данных
<img src = https://user-images.githubusercontent.com/116554810/200197410-88f8ec1d-e6aa-43af-a698-1350368a0105.png>

