# Booking Hotel
## Описание сайта

Сайт букинга отелей разных классов, присутствует регистрация пользователя, просмотр каталога, возможность резервации отелей

## Используемые технологии:
  - ASP.NET CORE
  - Microsoft SQLServer

## Свойства модулей
  ### Свойства модуля 1: 
- Работа с Аккаунтом:
    - создание аккаунта;
    - вход в аккаунт;
    - просмотр аккаунта;
    - изменение данных аккаунта;
    - удаление аккаунта;
 - Работа с заказами:
    - просмотр товаров в корзине;
    - удаление товара из корзины
    - оформление заказов;
    - просмотр заказов.

### Свойства модуля 2: 
#### online бронирование

Клиенты самостоятельно могут забронировать номер в вашем отеле (пансионате, турбазе и т.п.) на вашем сайте.

#### Управление заказами

В системе реализованы возможности формирования заказов на бронирование и дополнительные услуги, отмены бронирования, выставления счетов на оплату, заселения и выселения гостей.

#### Управление ценами

В системе предусмотрена гибкая настройка тарифов на размещение гостей, а также прайс-листов на дополнительные услуги. Вы можете регулировать стоимость номеров в зависимости от сезона, дня недели, создавать различные системы скидок, определять условия оплаты за бронирование, назначать штрафные санкции за отмену брони.
    
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
	2) id_Hotel
	3) Stars
	4) Adress
	5) Features

#### 4. Rooms
	1) id_Room
	2) id_Hotel
	3) Bed
	4) Eat
	5) Free_cancel
	6) Features

#### 5. Managers
	1) id_Hotel
	2) Name
	3) Login
	4) Password

#### Для работы с пользователями

	Endpoinds:
    
		1.POST запрос для входа в аккаунт с передачей данных от пользователя.
		2.POST запрос для входа в аккаунт с передачей данных от пользователя.
		3.POST запрос для регистрации нового пользователя.
		4.DELETE запрос – удаление пользователя.
		5.PUT запрос для изменения данных пользователя.
#### Для работы с Отелями

	Endpoints:
	
		1.POST запрос для входа в аккаунт с передачей данных от отеля.
		2.POST запрос для входа в аккаунт с передачей данных от отеля.
		3.POST запрос для регистрации нового отеля.
		4.DELETE запрос – удаление отеля.
		5.PUT запрос для изменения данных отеля.
