# smart_city_2021
  Реализация задания командой "Bauman city" с финала профиля "Умный город" ОНТИ.  
  
  Состав команды:
  Попов Максим (к) 
  Данилов Валерий 
  Трашко Никита 
  Гришин Александр

Документация


*Работа с базой данных 
Для работы с базой данных рекомендуется установить MySQL Community  Server  (см. ссылка 1). После также рекомендуется установить MySQL Workbanch для удобной работы с создаваемыми базами(см ссылка 2). Для инициализации необходимо запустить консоль и ввести следующие команды:

// Change directory to the MySQL's binary directory
// Suppose that your MySQL is installed in "c:\myWebProject\mysql"

cd \myWebProject\mysql\bin
 
// Initialize the database. Create a root user with random password. Show the messages on console
mysqld --initialize --console

Для запуска сервера необходимо ввести:

cd \myWebProject\mysql\bin
 
-- Start the MySQL Database Server
mysqld --console


Запуск сервера:
Ссылка 1 -  https://dev.mysql.com/downloads/mysql/
Ссылка 2 -   https://www.mysql.com/products/workbench/


Подробную инструкцию по работе с базой данных можно найти здесь : https://www3.ntu.edu.sg/home/ehchua/programming/sql/MySQL_HowTo.html

Файл базы данных: ./NTI_DB/model.mwb

*Работа с десктопом
Проект находится в ./NTI_APP/


*Работа с Factory I/O

Если FACTORY IO расположить по пути C:/Program Files(x86)/Real Games/Factory IO/Factory IO.exe, то Factory IO будет открываться автоматически при запуске десктопа.
Иначе окрыть самостоятельно, сцена находится в ./FactoryIO
Проект, работающий с FactoryIO - ./FactoryIO/Controllers


