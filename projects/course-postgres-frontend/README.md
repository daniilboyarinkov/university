# Store практическая работа по БД Postgresql 

Картиночки:

![image](https://user-images.githubusercontent.com/89917619/221348208-f45f4467-61ca-4edc-8ef6-e627e439ae27.png)

![image](https://user-images.githubusercontent.com/89917619/221348212-acf128af-7616-4e52-867a-fb9c11e7b5e7.png)



## Локально развернуть проект

1. Скачать и развернуть бд NorthWind в postgresql по ссылке: [дамп Northwind](https://e.sfu-kras.ru/mod/resource/view.php?id=1349742)
2. Склонировать репозиторий backend части по ссылке: [backend часть](https://github.com/daniilboyarinkov/store-postgres-backend)
3. Установка зависимостей для склонированного проекта

```
npm install
```

4. Настроить доступ к развернутой БД в backend части объекте pool по пути /models/products_model.js

```js
const pool = new Pool({
    user: db_user,
    host: db_host ?? 'localhost',
    database: db_name,
    password: db_passwrd,
    port: db_port ?? 5432,
});
```

5. запустить сервер локально на 3001 порту:

```
npm start
```

6. Склонировать текущий репозиторий: [этот репозиторий (рекурсия)](https://github.com/daniilboyarinkov/store-postgresql-frontend)
7. Установка зависимостей и запуск проекта

```
npm install
```

```
npm start
```
