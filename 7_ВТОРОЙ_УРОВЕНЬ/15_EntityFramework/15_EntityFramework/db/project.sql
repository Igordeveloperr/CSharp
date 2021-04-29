-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Апр 26 2021 г., 21:39
-- Версия сервера: 10.1.38-MariaDB
-- Версия PHP: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `project`
--

-- --------------------------------------------------------

--
-- Структура таблицы `admin_users`
--

CREATE TABLE `admin_users` (
  `id` int(11) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `admin_users`
--

INSERT INTO `admin_users` (`id`, `email`, `password`, `status`) VALUES
(1, 'admin', '13579', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `description_admin_panal`
--

CREATE TABLE `description_admin_panal` (
  `id` int(11) NOT NULL,
  `description` text NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `description_admin_panal`
--

INSERT INTO `description_admin_panal` (`id`, `description`, `status`) VALUES
(1, '11111111Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit sapiente optio repellat praesentium sed laboriosam quia modi soluta excepturi culpa. Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit sapiente optio repellat praesentium sed laboriosam quia modi soluta excepturi culpa. Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit sapiente optio repellat praesentium sed laboriosam quia modi soluta excepturi culpa.', 1),
(2, '2222222222Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit sapiente optio repellat praesentium sed laboriosam quia modi soluta excepturi culpa. Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit sapiente optio repellat praesentium sed laboriosam quia modi soluta excepturi culpa. Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugit sapiente optio repellat praesentium sed laboriosam quia modi soluta excepturi culpa.', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `main_user_description`
--

CREATE TABLE `main_user_description` (
  `id` int(11) NOT NULL,
  `description` text NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `main_user_description`
--

INSERT INTO `main_user_description` (`id`, `description`, `status`) VALUES
(1, 'Dolorum, ipsam. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum, ipsam. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum, ipsam. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum, ipsam. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum, ipsam. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum, ipsam. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum, ipsam. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum, ipsam. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum, ipsam. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum, ipsam. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum, ipsam.', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `news_admin`
--

CREATE TABLE `news_admin` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `news_admin`
--

INSERT INTO `news_admin` (`id`, `title`, `description`, `date`, `status`) VALUES
(1, 'first new', 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatum unde numquam praesentium illo eius libero excepturi iure perspiciatis voluptate laborum? Veritatis ratione numquam, tenetur tempore laboriosam, cupiditate possimus optio quod voluptatibus eos a vero. Corporis deserunt itaque vel ullam voluptatum? Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatum unde numquam praesentium illo eius libero excepturi iure perspiciatis voluptate laborum? Veritatis ratione numquam, tenetur tempore laboriosam, cupiditate possimus optio quod voluptatibus eos a vero. Corporis deserunt itaque vel ullam voluptatum? Lorem ipsum dolor sit amet consectetur adipisicing elit.', '2019-09-23 08:12:24', 1),
(2, 'second new', 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatum unde numquam praesentium illo eius libero excepturi iur', '2019-09-26 07:16:18', 1),
(3, 'tHERD', 'DAREHWGUNB9BUOW0IGSMN89N8=hng8ew09rhnew9r80HB809hb908-hhb09-ahnhew0rmmh0rewmh-0re', '2019-11-27 10:01:49', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `news_for_user`
--

CREATE TABLE `news_for_user` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `news_for_user`
--

INSERT INTO `news_for_user` (`id`, `title`, `description`, `date`, `status`) VALUES
(1, 'Сайт заработал\r\n', '\r\net consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste. Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste.', '2019-10-11 09:23:28', 1),
(2, 'PHP ', 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste. Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste.', '2019-10-11 09:23:41', 1),
(3, 'Разработчик', 'твьшфытв0шфыщтв8фы09ртв8фырвф7рывп87фыпив8нфмыив8ыфмв87фмы8вф', '2019-10-11 09:39:34', 1),
(4, 'Test1', 'wwwwwwwwwwwwwwasaasssssssssssssssssssssssssssssssssssssssssss', '2019-10-11 09:39:49', 1),
(5, 'test2', '2222222222222222222222', '2019-10-11 09:40:08', 1),
(6, 'test3', 's333333333333333333333333333', '2019-10-11 09:40:30', 1),
(7, 'test4', '4444444444444', '2019-10-11 09:40:41', 1),
(8, 'test8', 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste. Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste.', '2019-11-08 08:40:47', 1),
(9, 'test9', 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste. Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste.', '2019-11-08 08:41:12', 1),
(10, 'test10', 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste. Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste.', '2019-11-08 08:41:19', 1),
(11, 'test11', 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste. Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste.', '2019-11-08 08:41:28', 1),
(12, 'test12', 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste. Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste.', '2019-11-08 08:41:38', 1),
(13, 'test13', 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste. Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste.', '2019-11-08 08:41:49', 1),
(14, 'TEST14', 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste. Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam, fugiat! Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis, sequi. Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati, odit. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Libero, iste.Lorem ipsum dolor sit am', '2019-11-08 13:40:26', 1),
(15, 'TEST 15', 'DASDASFSDAGSOPGFD,OP', '2020-01-05 02:30:31', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `school_classes`
--

CREATE TABLE `school_classes` (
  `id` int(11) NOT NULL,
  `title` varchar(10) NOT NULL,
  `category_id` int(11) NOT NULL,
  `status` int(2) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `school_classes`
--

INSERT INTO `school_classes` (`id`, `title`, `category_id`, `status`) VALUES
(1, '1 класс', 1, 1),
(2, '2 класс', 2, 1),
(3, '3 класс', 3, 1),
(4, '4 класс', 4, 1),
(5, '5 класс', 5, 1),
(6, '6 класс', 6, 1),
(7, '7 класс', 7, 1),
(8, '8 класс', 8, 1),
(9, '9 класс', 9, 1),
(10, '10 класс', 10, 1),
(11, '11 класс', 11, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `subjects_for_tests`
--

CREATE TABLE `subjects_for_tests` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `status` int(11) NOT NULL,
  `category_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `subjects_for_tests`
--

INSERT INTO `subjects_for_tests` (`id`, `title`, `status`, `category_id`) VALUES
(1, 'Математика', 1, 1),
(2, 'Русский язык', 1, 2),
(3, 'Биология', 1, 3),
(4, 'Информатика', 1, 4),
(5, 'История', 1, 5),
(6, 'География', 1, 6),
(7, 'Физика', 1, 7),
(8, 'Химия', 1, 8),
(9, 'Литература', 1, 9),
(10, 'Английский язык', 1, 10),
(11, 'Немецкий язык', 1, 11),
(12, 'Обществознание', 1, 12),
(13, 'ОБЖ', 1, 13),
(14, 'ФИЗО', 1, 14),
(15, 'Астрономия', 1, 15),
(16, 'Философия', 1, 16);

-- --------------------------------------------------------

--
-- Структура таблицы `tests`
--

CREATE TABLE `tests` (
  `id` int(11) NOT NULL,
  `question` varchar(255) NOT NULL,
  `option_1` varchar(255) NOT NULL,
  `option_2` varchar(255) NOT NULL,
  `option_3` varchar(255) NOT NULL,
  `option_4` varchar(255) NOT NULL,
  `option_5` varchar(255) NOT NULL,
  `option_6` varchar(255) NOT NULL,
  `category_id` int(7) NOT NULL,
  `status` int(11) NOT NULL,
  `correct_answer` varchar(255) NOT NULL,
  `class_id` int(2) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tests`
--

INSERT INTO `tests` (`id`, `question`, `option_1`, `option_2`, `option_3`, `option_4`, `option_5`, `option_6`, `category_id`, `status`, `correct_answer`, `class_id`) VALUES
(6, 'первая буква алфавита а или и ?', 'а', 'и', 'оба ответа не верны', 'хз', '', '', 2, 1, 'а', 1),
(7, '4 * 4', '44', '16', '890', '', '', '', 1, 1, '16', 1),
(10, 'буква А согласная?', 'да', 'нет', 'хз', '', '', '', 1, 1, 'нет', 1),
(11, 'буква Г согласная?', 'да', 'нет', 'не знаю', '', '', '', 2, 1, 'да', 1),
(12, 'teeeeeeestssssss', 't', 's', 'r', '', '', '', 2, 1, 'r', 1),
(13, '2222222222222222222222222222222222222', '2222', '2', '2222', '', '', '', 1, 1, '2', 1),
(14, 'Никита Панк?', 'да', 'нет', 'он репер', '', '', '', 2, 1, 'он панк-рокер', 1),
(15, 'function(a = 4, b = 9){return a + b} - что получится?', '1', '2121', '13', '', '', '', 1, 1, '13', 1),
(17, '2+3', '52', '12', '1', '5', '45', '78', 1, 1, '5', 1),
(18, '42 - четное?', 'надо подумать', 'возможно', 'хз', 'да', 'нет', '', 1, 1, 'да', 1),
(19, '50 + 50', '10', '5050', '150', '100', '', '', 1, 1, '100', 1),
(20, '230 + 30', '261', '245', '12121', '360', '260', '', 1, 1, '260', 1),
(21, '2 + 4', '6', '7', '12', '78', '', '', 1, 1, '6', 1),
(22, '2+2*4', '10', '16', '121', '121', '1212', '3323', 1, 1, '10', 1),
(23, 'f(x) = 2x-3. f(2)?', '23', '1', '2', '4', '8', '12121212', 1, 1, '1', 1),
(24, '144+4', '1', '148', '15', '', '', '', 1, 1, '148', 1),
(25, 'че как по запятой?', 'а', 'кто ', 'каво', 'норм', 'ага', '', 2, 1, 'ага', 1),
(27, 'ээээээээээээээээээ', 'дддддддд', 'д', 'дддд', 'дддддд', 'дд', 'дддддд', 2, 1, 'д', 1),
(28, 'test test ', '1', '2', '3', '4', '5', '6', 2, 1, '6', 1),
(29, 'буква В согласная?', 'да', 'нет', 'не знаю', '', '', '', 0, 1, 'да', 1),
(30, 'буква В согласная?', 'да', 'нет', 'не знаю', '', '', '', 0, 1, 'да', 1),
(31, 'буква В согласная?', 'да', 'нет', 'не знаю', '', '', '', 0, 1, 'да', 1),
(34, 'oooooooooooooooooooo', 'o', 'oo', 'ooo', '', '', '', 2, 1, 'o', 1),
(35, '[[[[[[[[[[[[[[[[[[[[[[[[[[', '[', '[[', '[[[', '', '', '', 2, 1, '[[', 1),
(36, 'mmmmmmmmmmmmmmmmmmm', 'm', 'mm', 'mmm', '', '', '', 2, 1, 'mmm', 1),
(37, 'yyyyyyyyyyyyyyyy', 'y', 'yy', 'yyy', '', '', '', 2, 1, 'yyy', 1),
(38, 'буква А согласная?', 'нет', 'не знаю', 'да', '', '', '', 2, 1, 'нет', 11),
(40, 'буква Г согласная?', 'нет', 'не знаю', 'да', '', '', '', 2, 1, 'да', 5),
(41, 'aaaaaaaaaaaaaaaaaaa', '1', '2', '23', '56', '89', '09', 1, 1, '23', 3),
(42, 'teeeeeeeeeeeeeeeeeeee', '11', '22', '33', '', '', '', 4, 1, '33', 1),
(43, '2222222222222222222', '2', '22', '222', '', '', '', 5, 1, '2', 1),
(44, '111111111111111', '1', '11', '111', '', '', '', 6, 1, '1', 1),
(45, '112222121', '1111', '21', '22', '', '', '', 7, 1, '22', 1),
(46, '3334', '33', '3332121', '1', '', '', '', 8, 1, '1', 1),
(47, 'tt', 't', 'ttt', 'tt', '', '', '', 9, 1, 't', 1),
(48, 'ццццццц', '3', '112', '12121', '', '', '', 10, 1, '3', 1),
(49, '2', '32', '22', '221', '', '', '', 11, 1, '22', 1),
(50, 'к', 'кк', 'к', 'ккк', '', '', '', 12, 1, 'к', 1),
(51, 'ззз', '1', '2', '3', '', '', '', 13, 1, '2', 1),
(52, 'пп', '1', '2', '3', '', '', '', 14, 1, '3', 1),
(53, 'ззз', '1', '2', '3', '', '', '', 15, 1, '1', 1),
(55, 'Леша лох?', 'да ', 'нет', 'мабе бабе', 'каво', 'Илья лох', 'гг', 13, 1, 'нет', 11),
(57, 'буква А согласная?', 'да', 'нет', 'не', '', '', '', 2, 1, 'нет', 2),
(58, 'test1 1 24 2', 'tt', 'yy', 'aa', 'oo', 'pp', 'xx', 13, 1, 'xx', 5),
(59, 'сколько будет 2 + 7 ?', '9', '10', '11', '', '', '', 1, 1, '9', 7),
(60, '1', '1', '2', '23', '', '', '', 1, 1, '1', 7),
(61, 'f(x = 2) = 2 + x?', '13', '4', '45', '89', '90', '3', 4, 1, '4', 6),
(62, '32323', '323', '232', '3232', '', '', '', 1, 1, '1212', 11),
(63, 'сколько будет 2 + 2 ?', '4', '6', '8', '', '', '', 1, 1, '4', 2),
(64, '5 + 3?', '8', '7', '9', '', '', '', 1, 1, '8', 2),
(65, 'ускорение свободного падения зависит от:', 'массы тела', 'плотности тела', 'радиоактивности тела', '', '', '', 7, 1, 'массы тела', 7),
(66, 'кто тут лох?', 'Юра', 'Гохля', 'Валентин', 'Леха', '', '', 16, 1, 'Юра', 1),
(67, '1', '1', '1', '1', '1', '1', '1', 1, 1, '1', 1),
(68, '45 + 5?', '51', '49', '50', '50.5', '49.5', '', 1, 1, '50', 11);

-- --------------------------------------------------------

--
-- Структура таблицы `test_category_from_admin`
--

CREATE TABLE `test_category_from_admin` (
  `id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `test_category_from_admin`
--

INSERT INTO `test_category_from_admin` (`id`, `title`, `status`) VALUES
(1, 'Математика', 1),
(2, 'Русский язык', 1),
(3, 'Биология', 1),
(4, 'Информатика', 1),
(5, 'История', 1),
(6, 'География', 1),
(7, 'Физика', 1),
(8, 'Химия', 1),
(9, 'Литература', 1),
(10, 'Английский язык', 1),
(11, 'Немецкий язык', 1),
(12, 'Обществознание', 1),
(13, 'ОБЖ', 1),
(14, 'ФИЗО', 1),
(15, 'Астрономия', 1),
(16, 'Философия', 1);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `admin_users`
--
ALTER TABLE `admin_users`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `description_admin_panal`
--
ALTER TABLE `description_admin_panal`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `main_user_description`
--
ALTER TABLE `main_user_description`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `news_admin`
--
ALTER TABLE `news_admin`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `news_for_user`
--
ALTER TABLE `news_for_user`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `school_classes`
--
ALTER TABLE `school_classes`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `subjects_for_tests`
--
ALTER TABLE `subjects_for_tests`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `tests`
--
ALTER TABLE `tests`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `test_category_from_admin`
--
ALTER TABLE `test_category_from_admin`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `admin_users`
--
ALTER TABLE `admin_users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `description_admin_panal`
--
ALTER TABLE `description_admin_panal`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `main_user_description`
--
ALTER TABLE `main_user_description`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `news_admin`
--
ALTER TABLE `news_admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `news_for_user`
--
ALTER TABLE `news_for_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT для таблицы `school_classes`
--
ALTER TABLE `school_classes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблицы `subjects_for_tests`
--
ALTER TABLE `subjects_for_tests`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT для таблицы `tests`
--
ALTER TABLE `tests`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=69;

--
-- AUTO_INCREMENT для таблицы `test_category_from_admin`
--
ALTER TABLE `test_category_from_admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
