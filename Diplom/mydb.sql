-- --------------------------------------------------------
-- Хост:                         192.168.1.21
-- Версия сервера:               5.6.29-log - MySQL Community Server (GPL)
-- ОС Сервера:                   Win64
-- HeidiSQL Версия:              9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Дамп структуры базы данных mydb
CREATE DATABASE IF NOT EXISTS `mydb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `mydb`;


-- Дамп структуры для таблица mydb.BookLocation
CREATE TABLE IF NOT EXISTS `BookLocation` (
  `idBookLocation` int(11) NOT NULL AUTO_INCREMENT,
  `BookWay` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`idBookLocation`),
  CONSTRAINT `BookFK` FOREIGN KEY (`idBookLocation`) REFERENCES `Books` (`idКниги`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8;

-- Дамп данных таблицы mydb.BookLocation: ~5 rows (приблизительно)
/*!40000 ALTER TABLE `BookLocation` DISABLE KEYS */;
REPLACE INTO `BookLocation` (`idBookLocation`, `BookWay`) VALUES
	(23, 'bd7a8850-e92c-45f7-9a34-9f8e272b06fd.mydb'),
	(24, 'c7c6ac37-3534-4eff-b9d5-2bd50be9efe4.mydb'),
	(25, '7e092b64-8dee-4879-9f1d-724498a2320f.mydb'),
	(30, '05427f94-6f75-448e-a6af-3ada95c20329.mydb'),
	(31, '3762a789-1750-4460-9fe2-9aa36bf1498a.mydb');
/*!40000 ALTER TABLE `BookLocation` ENABLE KEYS */;


-- Дамп структуры для таблица mydb.Books
CREATE TABLE IF NOT EXISTS `Books` (
  `idКниги` int(11) NOT NULL AUTO_INCREMENT,
  `НазваниеКниги` varchar(45) DEFAULT NULL,
  `Язык` varchar(45) DEFAULT NULL,
  `Жан` varchar(45) DEFAULT NULL,
  `Автор` varchar(45) DEFAULT NULL,
  `ДатаВыпуска` varchar(50) DEFAULT NULL,
  `Описание` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`idКниги`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8;

-- Дамп данных таблицы mydb.Books: ~5 rows (приблизительно)
/*!40000 ALTER TABLE `Books` DISABLE KEYS */;
REPLACE INTO `Books` (`idКниги`, `НазваниеКниги`, `Язык`, `Жан`, `Автор`, `ДатаВыпуска`, `Описание`) VALUES
	(23, 'Звездные короли', 'казахский', 'Драма', 'кто то там', '16.06.2016', 'уфыафывп'),
	(24, '123123222', 'албанский', 'Новелла', '2222', '20.02.2016', ''),
	(25, 'звездные короли', 'алюторский', 'Детская литература', '4424', '02.06.2016', 'пвврпывпдрывапотлыовпыо'),
	(30, 'Магфиг', 'русский', 'Фентези', 'Кружевский', '20.06.2016', 'Тест'),
	(31, '33333333333333333333333333333333333', 'английский ', 'Детская литература', '33333333333333333333333333333333333', '21.06.2016', '3333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333');
/*!40000 ALTER TABLE `Books` ENABLE KEYS */;


-- Дамп структуры для таблица mydb.User
CREATE TABLE IF NOT EXISTS `User` (
  `idПользователя` int(11) NOT NULL AUTO_INCREMENT,
  `ИмяПользователя` varchar(50) DEFAULT NULL,
  `Логин` varchar(45) DEFAULT NULL,
  `Пароль` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idПользователя`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8;

-- Дамп данных таблицы mydb.User: ~3 rows (приблизительно)
/*!40000 ALTER TABLE `User` DISABLE KEYS */;
REPLACE INTO `User` (`idПользователя`, `ИмяПользователя`, `Логин`, `Пароль`) VALUES
	(47, 'root', 'root', 'root'),
	(49, 'qwe', 'ewq', 'asd'),
	(50, 'asdg', 'asdgag', 'asdhadh');
/*!40000 ALTER TABLE `User` ENABLE KEYS */;


-- Дамп структуры для таблица mydb.UserOpenBook
CREATE TABLE IF NOT EXISTS `UserOpenBook` (
  `idЛог` int(11) NOT NULL AUTO_INCREMENT,
  `idПользователя` int(11) NOT NULL,
  `idКниги` int(11) NOT NULL,
  `ИмяПользователя` varchar(50) NOT NULL,
  `НазваниеКниги` varchar(50) NOT NULL,
  PRIMARY KEY (`idЛог`),
  KEY `user` (`idПользователя`),
  KEY `book` (`idКниги`),
  CONSTRAINT `book` FOREIGN KEY (`idКниги`) REFERENCES `Books` (`idКниги`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `user` FOREIGN KEY (`idПользователя`) REFERENCES `User` (`idПользователя`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Дамп данных таблицы mydb.UserOpenBook: ~6 rows (приблизительно)
/*!40000 ALTER TABLE `UserOpenBook` DISABLE KEYS */;
REPLACE INTO `UserOpenBook` (`idЛог`, `idПользователя`, `idКниги`, `ИмяПользователя`, `НазваниеКниги`) VALUES
	(1, 47, 25, 'root', 'звездные короли'),
	(2, 47, 25, 'root', 'звездные короли'),
	(3, 47, 23, 'root', 'Звездные короли'),
	(4, 47, 30, 'root', 'Магфиг'),
	(5, 47, 30, 'root', 'Магфиг'),
	(6, 47, 23, 'root', 'Звездные короли');
/*!40000 ALTER TABLE `UserOpenBook` ENABLE KEYS */;


-- Дамп структуры для таблица mydb.UserRights
CREATE TABLE IF NOT EXISTS `UserRights` (
  `idUserRights` int(11) NOT NULL AUTO_INCREMENT,
  `BookAdd` tinyint(1) DEFAULT NULL,
  `BookDelete` tinyint(1) DEFAULT NULL,
  `BookEdit` tinyint(1) DEFAULT NULL,
  `UserControl` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idUserRights`),
  CONSTRAINT `Users` FOREIGN KEY (`idUserRights`) REFERENCES `User` (`idПользователя`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8;

-- Дамп данных таблицы mydb.UserRights: ~3 rows (приблизительно)
/*!40000 ALTER TABLE `UserRights` DISABLE KEYS */;
REPLACE INTO `UserRights` (`idUserRights`, `BookAdd`, `BookDelete`, `BookEdit`, `UserControl`) VALUES
	(47, 1, 1, 1, 1),
	(49, 1, 0, 1, 1),
	(50, 1, 0, 1, 0);
/*!40000 ALTER TABLE `UserRights` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
