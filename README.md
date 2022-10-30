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
	
### Работа с аккаунтом:
#### Создание Аккаунта
##### PUT api/clients/registration; login, password, firstname, surname, citizenship, birthday, email;
	1. 201 – Created, модель User
	2. 406 - notAcceptable
#### Вход в аккаунт
##### POST api/clients/authorization; login, password, firstname, surname, citizenship, birthday, email;
	1. 200 – Ok, модель User
	2. 404 – notFound
#### Просмотр аккаунта
##### Get api/clients/{ID:int32};требуется авторизация в роли пользователя
	1. 200 – ok, модель User
	2. 404 – notFound
	3. 401 – unauthorized
#### Изменение данных аккаунта
##### PUT api/clients/{ID:int32}; login, password, firstname,surname, citizenship, birthday, email; nтребуется авторизация в роли пользователя
	1. 200 – OK, модель User
	2. 404 – notFound
	3. 401 – unauthorized
#### Удаление Аккаунта
##### Delete api/clients/{ID:int32}; требуется авторизация в роли пользователя
	1. 204 – noContent
	2. 404 – notFound
	3. 401 - unauthorized
### Работа с бронью:
#### Отмена брони
##### POST – api/Rooms/{Id_Room:int32}, need authorization with User role, Id_Room, ID_Client, Start_Day, End_Day;
	1. 200 – OK
	2. 404 – NotFound
	3. 401 – Unauthorized
#### Просмотр брони
##### POST – api/Rooms/{id_Room:int32}, need authorization with User role, UserModel;
	1. 200 – OK
	2. 404 – NotFound
	3. 401 – Unauthorized
#### Оформление брони
##### POST – api/Rooms/{id_Room:int32}, need authorization with User role, Id_Room, Start_Day, End_Day, Id_Hotel, Id_Client;
	1. 200 – OK
	2. 404 – NotFound
	3. 401 – Unauthorized
#### Просмотр отелей
##### Get api/Hotels, don’t need authorization;
	1. 200 - OK, array of product model
	2. 404 - NotFound
#### Просмотр отелей с фильтрацией
##### POST api/Hotels/Price,  don’t need authorization;
	1. 200 - OK, array of product model
	2. 404 - NotFound
#### Добавление отеля в избранное
##### POST api/Hotels/{ID_Hotel:int32}, need authorization with user role;
	1. 204 - noContent
	2. 404 - NotFound
	3. 401 – Unauthorized
### Работа с аккаунтом (менеджер):
#### Создание Аккаунта(менеджер)
##### PUT api/managers/registration; login, password;
	1. 201 – Created, модель User
	2. 406 - notAcceptable
#### Вход в аккаунт
##### POST api/managers/authorization; login, password;
	1. 200 – Ok, модель User
	2. 404 – notFound
#### Просмотр аккаунта
##### Get api/managers/{ID:int32};требуется авторизация в роли менеджера
	1. 200 – ok, модель Manager
	2. 404 – notFound
	3. 401 – unauthorized
#### Изменение данных аккаунта
##### PUT api/managers/{ID:int32}; login, password; nтребуется авторизация в роли менеджера
	1. 200 – OK, модель User
	2. 404 – notFound
	3. 401 – unauthorized
#### Удаление Аккаунта
##### Delete api/managers/{ID:int32}; требуется авторизация в роли менеджера
	1. 204 – noContent
	2. 404 – notFound
	3. 401 - unauthorized
#### Добавление отеля
##### POST api/Hotels/{id_Hotel:int32}, требуется авторизация в роли менеджера
	1. 204 - noContent
	2. 404 - NotFound
	3. 401 – Unauthorized
#### Редактирование данных о номерах
##### PUT api/Rooms/{Id_Room:int32}; login, password, требуется авторизация в роли менеджера
	1. 200 – OK
	2. 404 – notFound
	3. 401 – unauthorized
#### Удаление Отеля
##### Delete api/Hotels/{ID_Hotel:int32}; требуется авторизация в роли менеджера
	1. 204 – noContent
	2. 404 – notFound
	3. 401 - unauthorized
 #### Удаление Номеров
##### Delete api/Rooms/{ID_Room:int32}; требуется авторизация в роли менеджера
	1. 204 – noContent
	2. 404 – notFound
	3. 401 - unauthorized
#### Просмотр Номеров
##### Get api/Rooms/{Id_Room:int32};требуется авторизация в роли менеджера
	1. 200 – ok, модель Менеджер
	2. 404 – notFound
	3. 401 – unauthorized
<img src = https://user-images.githubusercontent.com/116554810/198907290-4903c052-60bc-4ed9-bcca-068e25209c54.png>
