-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 20, 2021 at 11:49 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `try`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `cust_username` varchar(50) NOT NULL,
  `cust_pass` varchar(50) NOT NULL,
  `cust_Fname` varchar(50) NOT NULL,
  `cust_Lname` varchar(50) NOT NULL,
  `cust_MN` varchar(50) NOT NULL,
  `cust_Gender` varchar(7) NOT NULL,
  `cust_Add` varchar(100) NOT NULL,
  `cust_Cnum` int(11) NOT NULL,
  `cust_email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`cust_username`, `cust_pass`, `cust_Fname`, `cust_Lname`, `cust_MN`, `cust_Gender`, `cust_Add`, `cust_Cnum`, `cust_email`) VALUES
('anice', 'hak', 'janice', 'ade', 'lanm', 'Female', 'bulacan', 876544333, 'chesterclenn0223@gmail.com'),
('Via', '1234', 'Via', 'Durango', 'dko alam', 'Female', 'dko alam saan', 2147483647, 'chesterclenn0223@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `emp_username` varchar(50) NOT NULL,
  `emp_pass` varchar(50) NOT NULL,
  `emp_fname` varchar(50) NOT NULL,
  `emp_lname` varchar(50) NOT NULL,
  `emp_MN` varchar(50) NOT NULL,
  `emp_gender` varchar(7) NOT NULL,
  `emp_Add` varchar(100) NOT NULL,
  `emp_email` varchar(50) NOT NULL,
  `emp_Cnum` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_username`, `emp_pass`, `emp_fname`, `emp_lname`, `emp_MN`, `emp_gender`, `emp_Add`, `emp_email`, `emp_Cnum`) VALUES
('KEM', '123', 'Kem', 'Umipig', 'ewan ko', 'Female', 'dko din alam', 'chesterclenn0223@gmail.com', 9876543),
('p', 'ho', 'a', 'bc', 'c', 'Female', 't', 'chesterclenn0223@gmail.com', 2147483647),
('user', 'pass', 'name', 'lname', 'mname', 'Male', 'address', 'chesterclenn0223@gmail.com', 987654321);

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

CREATE TABLE `schedule` (
  `sched_ID` int(11) NOT NULL,
  `sched_Sname` varchar(50) NOT NULL,
  `sched_Price` varchar(8) NOT NULL,
  `sched_custUS` varchar(50) NOT NULL,
  `sched_date` date NOT NULL,
  `sched_issued` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `schedule`
--

INSERT INTO `schedule` (`sched_ID`, `sched_Sname`, `sched_Price`, `sched_custUS`, `sched_date`, `sched_issued`) VALUES
(5, 'Hair Color', '350', 'Via', '2021-11-30', '2021-11-20 18:41:26');

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `service_name` varchar(50) NOT NULL,
  `service_desc` text NOT NULL,
  `Price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`service_name`, `service_desc`, `Price`) VALUES
('Hair Color', 'HAIR COLOR AVAILABLE : PINK, WHITE, RED, MAROON', 350);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`cust_username`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_username`);

--
-- Indexes for table `schedule`
--
ALTER TABLE `schedule`
  ADD PRIMARY KEY (`sched_ID`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`service_name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `schedule`
--
ALTER TABLE `schedule`
  MODIFY `sched_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
