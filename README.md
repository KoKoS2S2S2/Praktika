# Booking Hotel
## Описание сайта

Сайт букинга отелей разных классов, присутствует регистрация пользователя, просмотр каталога, возможность резервации отелей. Сайт предоставляет возможность пользования клиентом и менеджером отелей.

## Используемые технологии:
  - ASP.NET CORE
  - Microsoft SQLServer

## Свойства модулей
### Свойства модуля 1: 
#### Работа с Аккаунтом:
	1) создание аккаунта;
	2) вход в аккаунт;
	3) просмотр аккаунта;
	4) изменение данных аккаунта;
	5) удаление аккаунта;
#### Работа с бронью:
	1) Просмотр бронирования клиента;
	2) Отмена брони;
	3) Оформление брони;
	4) просмотр брони.

### Свойства модуля 2: 
#### Работа с отелями(В роли клиента):
	2) Фильтрация поиска
	3) Просмотр отелей
	5) Добавление отеля в избранное
### Свойства модуля 3(менеджер):
#### Работа с аккаунтом:
	1) Создание аккаунта
	2) Просмотр аккаунта
	3) вход в аккаунт
	4) Изменение данных аккаунта
	5) Удаление аккаунта
#### Работа с Отелями:
	1) Добавление отеля
	2) Редактирование данных о номерах
	3) Удаление отеля
	4) Удаление номеров
	5) Просмотр номеров
	
	
    
## Достоинства SQLserver
  - Продукт очень прост в использовании
  - Текущая версия работает быстро и стабильно
  - Движок предоставляет возможность регулировать и отслеживать уровни производительности, которые помогают снизить использование ресурсов.
  - Вы сможете получить доступ к визуализации на мобильных устройствах.
  - Он очень хорошо взаимодействует с другими продуктами Microsoft.

## Определение API и Endpoint

### Модули api будут использовать 5 моделей для общения:
#### 1. Clients
	1) id_Client
	2) Firstname
	3) Surname
	4) Citizenship
	5) Login
	6) Password
	7) Birtday
	8) Email

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

#### 5. Managers
	1) id_Managers
	2) id_Hotel
	3) Name
	4) Login
	5) Password

### Для работы с пользователями.

	Endpoinds:
    
		1.POST запрос для входа в аккаунт с передачей данных от пользователя.
		2.POST запрос для входа в аккаунт с передачей данных от пользователя.
		3.POST запрос для регистрации нового пользователя.
		4.DELETE запрос – удаление пользователя.
		5.PUT запрос для изменения данных пользователя.
#### Для работы с Отелями.

	Endpoints:
	
		1.POST запрос для входа в аккаунт с передачей данных от отеля.
		2.POST запрос для входа в аккаунт с передачей данных от отеля.
		3.POST запрос для регистрации нового отеля.
		4.DELETE запрос – удаление отеля.
		5.PUT запрос для изменения данных отеля.
		
### Работа с аккаунтом:
#### Создание Аккаунта:
##### PUT api/clients/registration; login, password, firstname,surname, citizenship, birthday, email;
 1. 201 – Created, модель User
 2. 406 - notAcceptable
#### Вход в аккаунт:
##### POST api/clients/authorization; login, password, firstname,surname, citizenship, birthday, email;
 1. 200 – Ok, модель User
 2. 404 – notFound
#### Просмотр аккаунта:
##### Get api/clients/{ID:int32};требуется авторизация в роли пользователя
 1. 200 – ok, модель User
 2. 404 – notFound
 3. 401 – unauthorized
#### Изменение данных аккаунта:
##### PUT api/clients/{ID:int32}; login, password, firstname,surname, citizenship, birthday, email; nтребуется авторизация в роли пользователя
 1. 200 – OK, модель User
 2. 404 – notFound
 3. 401 – unauthorized
#### Удаление Аккаунта:
##### Delete api/clients/{ID:int32}; требуется авторизация в роли пользователя
 1. 204 – noContent
 2. 404 – notFound
 3. 401 - unauthorized
Работа с бронью
Отмена брони:
POST – api/products/{productId:int32}, need authorization with User role, Id_Room, ID_Client, Start_Day, End_Day;
200 – OK
404 – NotFound
401 – Unauthorized
Просмотр брони:
POST – api/products/{productId:int32}, need authorization with User role, UserModel;
200 – OK
404 – NotFound
401 – Unauthorized
Оформление брони
POST – api/products/{productId:int32}, need authorization with User role, Id_Room, Start_Day, End_Day, Id_Hotel, Id_Client;
200 – OK
404 – NotFound
401 – Unauthorized

Просмотр отелей: 
Get api/Hotels, don’t need authorization;
200 - OK, array of product model
404 - NotFound
Просмотр товаров с фильтрацией:
POST api/Hotels/Stars,  don’t need authorization;
200 - OK, array of product model
404 - NotFound
Добавление отеля в избранное:
POST api/Products/{productId:int32}, need authorization with user role;
204 - noContent
404 - NotFound
401 – Unauthorized

<img src = https://i.imgur.com/MMk8VgM.jpg>
