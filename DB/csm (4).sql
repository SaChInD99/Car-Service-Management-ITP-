-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 06, 2021 at 07:22 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `csm`
--

-- --------------------------------------------------------

--
-- Table structure for table `bookingtb`
--

CREATE TABLE `bookingtb` (
  `BID` int(11) NOT NULL,
  `C_Name` varchar(50) NOT NULL,
  `Contact_No` varchar(10) NOT NULL,
  `Vehicle_No` varchar(10) NOT NULL,
  `NIC` varchar(15) NOT NULL,
  `B_Type` varchar(20) NOT NULL,
  `Time` varchar(12) NOT NULL,
  `Day` varchar(10) NOT NULL,
  `Month` varchar(20) NOT NULL,
  `Service_Slot` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bookingtb`
--

INSERT INTO `bookingtb` (`BID`, `C_Name`, `Contact_No`, `Vehicle_No`, `NIC`, `B_Type`, `Time`, `Day`, `Month`, `Service_Slot`) VALUES
(10, 'kaveesha', '0715643124', 'NGF9867', '198374758v', 'booking type 2', '1.00', 'April', '26', 'Slot A'),
(12, 'sachin', '0714323456', 'ABC1235', '254671876v', 'booking type 1', '5.30', '9', 'April', 'Slot B'),
(13, 'kamal', '0761234576', 'KG4567', '187543598v', 'booking type 5', '5.00', '22', 'July', 'Slot B'),
(15, 'lakitha', '0761254678', 'NG5687', '178756376v', 'booking type 7', '4.00', '21', 'August', 'Slot B'),
(20, 'maneesha', '0743345676', 'VGF1243', '143567654v', 'booking type 2', '12.30', '9', 'April', 'Slot A'),
(21, 'Shani', '0718155217', 'KX5654', '235467543v', 'booking type 3', '11.30', '10', 'March', 'Slot B');

-- --------------------------------------------------------

--
-- Table structure for table `completetable`
--

CREATE TABLE `completetable` (
  `C_Index` int(20) NOT NULL,
  `S_Code` varchar(30) NOT NULL,
  `NIC` varchar(40) NOT NULL,
  `Customer_Name` varchar(100) NOT NULL,
  `Vehicle_num` varchar(50) NOT NULL,
  `Com_Year` varchar(10) NOT NULL,
  `Com_Month` varchar(20) NOT NULL,
  `Com_Time` varchar(100) NOT NULL,
  `Service_count` varchar(10) NOT NULL,
  `Discount` varchar(10) NOT NULL,
  `Service_Regards` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `completetable`
--

INSERT INTO `completetable` (`C_Index`, `S_Code`, `NIC`, `Customer_Name`, `Vehicle_num`, `Com_Year`, `Com_Month`, `Com_Time`, `Service_count`, `Discount`, `Service_Regards`) VALUES
(84, '20', '995760347V', 'Hiruni J.M.D.K', 'KL4112', '2021', 'September', '2 | 14 : 5', '1', 'No', 'No issue'),
(85, '21', '995760346V', 'Nayanana W.K', 'RTYU2', '2021', 'September', '2 | 14 : 5', '1', 'No', 'No issue'),
(86, '22', '345678934V', 'Umeshi J.H.I', 'HJ2345', '2021', 'September', '2 | 14 : 5', '1', 'No', 'No issue'),
(87, '50', '345678934V', 'Umeshi J.H.I', 'KJHG3', '2021', 'October', '3 | 15 : 3', '1', 'No', 'No issue'),
(88, '51', '345678934V', 'Umeshi J.H.I', 'KJHG3', '2021', 'October', '4 | 15 : 3', '2', 'No', 'No issue'),
(89, '52', '345678934V', 'Umeshi J.H.I', 'KJHG3', '2021', 'October', '2 | 15 : 5', '3', 'Yes', 'No issue'),
(90, '28', '995760347V', 'Hiruni J.M.D.K', 'KL4112', '2021', 'October', '4 | 15 : 6', '2', 'No', 'No issue'),
(91, '38', '345678863V', 'Harold M.k.D', 'KlM2', '2021', 'October', '3 | 15 : 7', '1', 'No', 'Needed oiling'),
(92, '26', '123453678V', 'Morais F.K.S', 'KJHGDF3', '2021', 'October', '2 | 15 : 7', '1', 'No', 'No issue'),
(94, '55', '678678924v', 'Munasinghe P.M', 'KJ782', '2021', 'October', '4 | 7 : 19', '1', 'No', 'No issue'),
(95, '56', '678678924v', 'Munasinghe P.M', 'KLJ7', '2021', 'October', '4 | 7 : 19', '1', 'No', 'No issue'),
(96, '27', '567904556V', 'Kvindya T.S.K', 'HJKL9', '2021', 'October', '4 | 7 : 32', '1', 'No', 'Oil pulling needed');

-- --------------------------------------------------------

--
-- Table structure for table `currentstock_table`
--

CREATE TABLE `currentstock_table` (
  `Item_Id` int(11) NOT NULL,
  `Item_Name` varchar(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Unit_Price` varchar(50) NOT NULL,
  `Min_quantity` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `currentstock_table`
--

INSERT INTO `currentstock_table` (`Item_Id`, `Item_Name`, `Date`, `Quantity`, `Unit_Price`, `Min_quantity`) VALUES
(7, 'pins', '2021 / 9 / 22', 210, '20', '200'),
(12, 'lubricants', '2021 / 9 / 17', 100, '3000', '30'),
(16, 'tubes', '2021 / 9 / 16', 2000, '1300', '26'),
(17, 'Coolant', '2021 / 9 / 17', 100, '800', '80'),
(18, 'Cabin filters', '2021 / 9 / 29', 80, '1590', '50'),
(25, 'break oil', '2021 / 9 / 17', 10, '300', '18'),
(26, 'Oil', '2021 / 9 / 29', 1000, '400', '1000'),
(27, 'engine oil', '2021 / 9 / 29', 1000, '500', '500'),
(28, 'Greese', '2021 / 9 / 29', 300, '200', '1000'),
(29, 'Washing liquid', '2021 / 9 / 29', 1000, '500', '800'),
(30, 'Wax', '2021 / 9 / 29', 68, '700', '50');

-- --------------------------------------------------------

--
-- Table structure for table `customertable`
--

CREATE TABLE `customertable` (
  `S_Code` int(11) NOT NULL,
  `Arr_Year` varchar(11) NOT NULL,
  `Arr_Month` varchar(11) NOT NULL,
  `Arr_Time` varchar(100) NOT NULL,
  `BID` varchar(100) NOT NULL,
  `NIC` varchar(50) NOT NULL,
  `Customer_Name` varchar(100) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Contact_No` varchar(11) NOT NULL,
  `Vehicle_num` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customertable`
--

INSERT INTO `customertable` (`S_Code`, `Arr_Year`, `Arr_Month`, `Arr_Time`, `BID`, `NIC`, `Customer_Name`, `Address`, `Email`, `Contact_No`, `Vehicle_num`) VALUES
(20, '2021', 'September', '01 | 20 : 37', 'none', '995760347V', 'Hiruni J.M.D.K', 'No 613,Nugape,pamunugama', 'kaveejaya@gmail.com', '0711657890', 'KL4112'),
(21, '2021', 'September', '01 | 20 : 37', 'none', '995760346V', 'Nayanana W.K', 'No 6,park lane,kandy', 'dilekavindi@gmail.com', '0718567456', 'RTYU2'),
(22, '2021', 'September', '10| 20 : 37', 'none', '345678934V', 'Umeshi J.H.I', 'No3,Street Rd,Borella', 'umeshijay@gmail.com', '0718965473', 'HJ2345'),
(23, '2021', 'September', '11| 20 : 38', 'none', '998765434V', 'Tolani J.D.S', 'No 53,Fine lane,colombo1', 'tolaridmi@gmail.com', '0775432678', 'GHJK8'),
(24, '2021', 'September', '12 | 20 : 38', 'none', '876542734V', 'Weerakoon L.M.R', 'no 43,lake terrace,Kandy', 'lakithmtchl@gmail.com', '0715678903', 'HJKL9'),
(25, '2021', 'September', '12 | 20 : 38', 'none', '789078965V', 'Gunesekara A.S.P', 'No 614,bird street,Kadawatha', 'pramuditha@gmail.com', '0715675437', 'KLMN4'),
(26, '2021', 'September', '12 | 20 : 38', '1', '123453678V', 'Morais F.K.S', 'No 56,kapuwwatta,Ragama', 'moraismahe@gmail.com', '0776543567', 'KJHGDF3'),
(27, '2021', 'October', '02| 20 : 39', 'none', '567904556V', 'Kvindya T.S.K', 'No 613,Nugape,Bopitiya', 'kavindidile@gmail.com', '0776543245', 'HJKL9'),
(28, '2021', 'October', '02 | 20 : 39', 'none', '995760347V', 'Hiruni J.M.D.K', 'No 613,Nugape,pamunugama', 'kaveejaya@gmail.com', '0718697012', 'KL4112'),
(32, '2021', 'October', '02 | 20 : 39', '2', '995760347V', 'Hiruni J.M.D.K', 'No 613,Nugape,pamunugama', 'kaveejaya@gmail.com', '0711657890', 'KL4112'),
(36, '2021', 'October', '03 | 20 : 41', '4', '867546789V', 'Dias E.M.D', 'No 45,harold street ,galle', 'haroldjay@gmail.com', '0716786543', 'KL1220'),
(37, '2021', 'October', '03| 20 : 41', 'none', '345678934V', 'Umeshi J.H.I', 'No3,Street Rd,Borella', 'umeshi@gmail.com', '0718965473', 'KL123'),
(38, '2021', 'October', '03 | 20 : 44', 'none', '345678863V', 'Harold M.k.D', 'No 56,ark lane,colombo', 'haroldjaya@gmail.com', '0714567789', 'KlM2'),
(50, '2021', 'October', '03 | 7 : 48', 'none', '345678934V', 'Umeshi J.H.I', 'No3,Street Rd,Borella', 'umeshi@gmail.com', '0718965473', 'KJHG3'),
(51, '2021', 'October', '04 | 7 : 49', 'none', '345678934V', 'Umeshi J.H.I', 'No3,Street Rd,Borella', 'umeshi@gmail.com', '0718965473', 'KJHG3'),
(52, '2021', 'October', '04 | 7 : 50', 'none', '345678934V', 'Umeshi J.H.I', 'No3,Street Rd,Borella', 'umeshi@gmail.com', '0718965473', 'KJHG3'),
(55, '2021', 'October', '04 | 7 : 15', 'none', '678678924v', 'Munasinghe P.M', 'No 67,kandy road.Malabe', 'praveenmun@gmail.com', '0716787654', 'KJ782'),
(56, '2021', 'October', '04 | 7 : 18', 'none', '678678924v', 'Munasinghe P.M', 'No 67,kandy road.Malabe', 'praveenmun@gmail.com', '0716787654', 'KLJ7');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `ID` int(45) NOT NULL,
  `EmployeeName` varchar(45) NOT NULL,
  `EmployeeID` varchar(45) NOT NULL,
  `NIC` varchar(45) NOT NULL,
  `DOB` varchar(45) NOT NULL,
  `Adress` varchar(45) NOT NULL,
  `EmployeeEmail` varchar(45) NOT NULL,
  `ContactNumber` varchar(45) NOT NULL,
  `Attendence` varchar(45) NOT NULL,
  `OT` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`ID`, `EmployeeName`, `EmployeeID`, `NIC`, `DOB`, `Adress`, `EmployeeEmail`, `ContactNumber`, `Attendence`, `OT`) VALUES
(4, 'Jeewaka Perera', 'A001', '9524555615V', 'Tuesday, October 5, 2021', '222/33, Jaya Road, Maradana', 'jeewaka95@gmail.com', '0756123458', '25', '4200'),
(5, 'Rasanjana Fernando', 'A002', '9824452615V', 'Tuesday, October 5, 2021', 'A55, Pannipitiya Road, Maharagama', 'rasanjana0000@gmail.com', '0756123458', '24', '2500'),
(6, 'Rasika Ekanayaka', 'A003', '9678455526V', 'Tuesday, October 5, 2021', '128/B, Udubokalawela, Abathanna', 'rasika96@gmail.com', '0756123458', '27', '2800'),
(7, 'Kaveesha Walalawela', 'A004', '9958746542V', 'Tuesday, October 5, 2021', 'X3, Baseline Road, Rajagiriya', 'kaveesha523@gmail.com', '0751212124', '28', '2900'),
(8, 'Malishi Warnakulasooriya', 'A005', '9954152456V', 'Tuesday, October 5, 2021', '22A, Vihara Para, Modara', 'malishi@gmail.com', '0758452154', '30', '4900'),
(9, 'Iduwara Ananda', 'A007', '9658545524V', 'Tuesday, October 5, 2021', '2/45, Panagoda Para, Katugasthota', 'iduwara.a@gmail.com', '0756106152', '28', '4650'),
(10, 'Tolani Weerasinghe', 'A008', '9286542785V', 'Tuesday, October 5, 2021', '035, kadawatha, Mabola, Wattala', 'tolaaani@gmail.com', '0766106175', '30', '2850'),
(11, 'Hiruni Jayamaha', 'A009', '9856348752V', 'Tuesday, October 5, 2021', '44AN, Rajamaha Vihara Para, Kurunagala', 'hiru@gmail.com', '0766106175', '29', '3750'),
(12, 'Lakitha Weerakon', '0010', '9754525524V', 'Sunday, October 5, 1997', 'S22/02, Waliwita Road, Waliwita', 'luky111@gmail.com', '0766106175', '24', '3650'),
(13, 'Nimal Jayarathna', 'A011', '7754524762V', 'Tuesday, October 5, 2021', 'colombo6', 'nimaljayarathne@gmail.com', '0766106175', '25', '3500'),
(14, 'Wasanthi Rathnayaka', 'A012', '5926736389V', 'Wednesday, October 6, 2021', '22/345, Subithapura, Kirulapana', 'wasanthi@gmail.com', '07574830647', '19', '2800'),
(15, 'Sunil Hunugama', 'A015', '7167384665V', 'Tuesday, October 5, 1971', '30J, Malwathugama, Panapitiya', 'Sunil.H@gmail.com', '0716456528', '30', '1200'),
(16, 'Danuka Akash', 'A016', '2037495337V', 'Thursday, October 5, 2000', '3/45, Sunethradevi Piriwen Para, Papiliyana', 'akash_d@gmail.com', '07165438276', '20', '800'),
(17, 'Mahasen Abeetha Gunarathne', 'A017', '9867428774V', 'Monday, October 5, 1998', '67/33, Ingiriya Para, Athurugiriya', 'mahasen98@gmail.com', '0752364816', '27', '500'),
(18, 'Sathsara Wanaguru', 'A018', '9027417773V', 'Friday, October 5, 1990', '3A, Epitamulla, Sapugaskanda', 'wanaguru.s@gmail.com', '0752364816', '27', '900'),
(19, 'Shehan Aroshana', 'A019', '2001845642V', 'Friday, October 5, 2001', 'A5/65, Perera Road, Wariyapola', 'shehana@gmail.com', '0752845387', '28', '1500'),
(20, 'Sampath Rajakaruna', 'A020', '7483727749V', 'Tuesday, October 5, 2021', '34/C, Hanwwalla Road, Awissawella', 'sampath@gmail.com', '0716384936', '23', '5500'),
(21, 'Nushkan Nizmi', 'A021', '9858490034V', 'Monday, October 5, 1998', '33A, Rathnapura Road, Balangoda', 'nushnish@gmail.com', '0773892749', '30', '1500'),
(22, 'Shiwa Rajakrishnan', 'A022', '5563827745V', 'Tuesday, October 5, 2021', '8C, Nadan Road, Muthrajawela', 'shiwar@gmail.com', '0777364274', '25', '5500'),
(23, 'Saraswathi Manohari', 'A023', '8538418837V', 'Tuesday, January 15, 1985', '12/18, Aulcot Road, Kottawa', 'saraswathi85@gmail.com', '0777364274', '20', '1800'),
(24, 'Santhush godawela', 'A024', '9965874123v', 'Thursday, August 12, 1999', '12/4,bokkawala, pujapitiya', 'santhush@gmail.com', '0777364274', '24', '1000'),
(25, 'suresh jayamaha', 'A025', '9758641235v', 'Tuesday, July 7, 1998', '12/4 pujapitiya, ambathenna', 'suresh828@gmail.com', '0777364274', '26', '750'),
(26, 'Susitha rajapaksha', 'A026', '7894563524V', 'Thursday, November 9, 1978', '12/5 thibirigasyaya,dole road', 'susitharaja@gmail.com', '0777323474', '26', '950');

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `ID` int(45) NOT NULL,
  `EmployeeSalaryID` varchar(45) NOT NULL,
  `EmployeeName` varchar(50) NOT NULL,
  `EmployeeID` varchar(45) NOT NULL,
  `EmployeeEmail` varchar(45) NOT NULL,
  `OT` varchar(45) NOT NULL,
  `ContactNumber` varchar(45) NOT NULL,
  `Basic` varchar(45) NOT NULL,
  `Attendence` varchar(45) NOT NULL,
  `CalculatedSalary` varchar(45) NOT NULL,
  `Month` varchar(20) NOT NULL,
  `Year` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`ID`, `EmployeeSalaryID`, `EmployeeName`, `EmployeeID`, `EmployeeEmail`, `OT`, `ContactNumber`, `Basic`, `Attendence`, `CalculatedSalary`, `Month`, `Year`) VALUES
(1, '00012', 'Rasika Ekanayaka', '001', 'rasikaekanayaka@gmail.com', '300', '0769791233', '20000', '28', '20300', 'February', 2021),
(4, '0001', 'Rasika Ekanayaka', '0007', 'rasikaekanayaka19936@gmail.com', '10009', '0769791233', '100000', '30', '110009', 'March', 2021),
(5, '0002', 'Kaveesha Walalawela', '0003', 'kaveeshakwalalawela@gmail.com', '10000/=', '0766856855', '100000/=', '23', '110000', 'February', 2021),
(6, '0003', 'Hiranya Kavindi', '0001', 'dannena@gmail.com', '10000/=', '0761881881', '100000/=', '25', '110000', 'September', 2021),
(14, '0004', 'jaye', '0002', 'jaye@gmail.com', '500', '0751234568', '10000', '20', '10500', 'Octorber', 2021),
(15, '0005', 'Hasan', '0005', 'hashan@gmail.com', '520', '0765555555', '20000', '2', '20520', 'December', 2021),
(16, '0006', 'Ranul', '0006', 'ranul@gmail.com', '600', '0781234567', '50000', '12', '50600', 'November', 2021),
(17, '0007', 'Rahul', '0005', 'rahul@gmail.com', '700', '0123456789', '52000', '21', '15000', 'May', 2021),
(18, '0008', 'Rose', '0004', 'rose@gmail.com', '522', '0789456123', '50000', '12', '50522', 'July', 2018),
(21, '5456', 'Gamage', '5656', 'gamage@gmail.com', '65265', '0789456123', '50505', '12', '115770', 'June', 2018),
(23, '0525412', 'reasika', '545665', 'rasika@gmail.com', '525', '0756106155', '50000', '12', '50525', 'July', 2018),
(25, '0005a', 'Rahul', '00009a', 'ranulranul@gmail.com', '2000', '07561061555', '100000', '20', '102000', 'April', 2021),
(26, '10000', '00001', '00001', '0001@gmail.com', '555', '0756106155', '2000', '30', '2555', 'June', 2021),
(28, 'A005S', 'Malishi Warnakulasooriya', 'A005', 'malishi@gmail.com', '4900', '0758452154', '20000', '30', '24900', 'June', 2017);

-- --------------------------------------------------------

--
-- Table structure for table `liststockcost`
--

CREATE TABLE `liststockcost` (
  `StockCostID` int(45) NOT NULL,
  `Order_Id` varchar(45) NOT NULL,
  `Item_Id` varchar(45) NOT NULL,
  `Item_Name` varchar(45) NOT NULL,
  `Date` varchar(45) NOT NULL,
  `Req_Quantity` varchar(45) NOT NULL,
  `Unit_Price` varchar(45) NOT NULL,
  `Total_Price` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `liststock_table`
--

CREATE TABLE `liststock_table` (
  `Order_Id` int(11) NOT NULL,
  `Item_Id` varchar(50) NOT NULL,
  `Item_Name` varchar(50) NOT NULL,
  `Date` varchar(50) NOT NULL,
  `Req_Quantity` varchar(50) NOT NULL,
  `Unit_Price` varchar(50) NOT NULL,
  `Total_Price` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `liststock_table`
--

INSERT INTO `liststock_table` (`Order_Id`, `Item_Id`, `Item_Name`, `Date`, `Req_Quantity`, `Unit_Price`, `Total_Price`) VALUES
(16, '16', 'tubes', '2021 / 10 / 16', '1000', '1300', '1300000'),
(24, '25', 'break oil', '2021 / 9 / 29', '1000', '300', '300000'),
(25, '28', 'Greese', '2021 / 9 / 29', '2500', '200', '500000'),
(26, '17', 'Coolant', '2021 / 9 / 29', '110', '800', '88000'),
(27, '29', 'Washing liquid', '2021 / 9 / 29', '500', '500', '250000'),
(28, '26', 'Oil', '2021 / 9 / 30', '2000', '400', '800000');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`, `id`) VALUES
('csm', 'csm123', 0),
('csm', 'csm123', 0),
('csm1', 'csm1234', 1),
('csm1', 'csm1234', 1);

-- --------------------------------------------------------

--
-- Table structure for table `mytable`
--

CREATE TABLE `mytable` (
  `S_ID` int(11) NOT NULL,
  `CustomerID` varchar(10) NOT NULL,
  `CustomerName` varchar(50) NOT NULL,
  `VehicleID` varchar(10) NOT NULL,
  `Time` varchar(50) NOT NULL,
  `Day` varchar(10) NOT NULL,
  `Month` varchar(20) NOT NULL,
  `Year` varchar(10) NOT NULL,
  `PaymenthM` varchar(20) NOT NULL,
  `Price` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `mytable`
--

INSERT INTO `mytable` (`S_ID`, `CustomerID`, `CustomerName`, `VehicleID`, `Time`, `Day`, `Month`, `Year`, `PaymenthM`, `Price`) VALUES
(5, 'C005', 'Kamal', 'LI 7390', '19 : 15', '13', 'February', '2019', 'Visa', 25000),
(7, 'C007', 'Nisal', 'NHJ 8372', '18 : 11', '23', 'September', '2021', 'Cheque', 16000),
(8, 'C008', 'Amali', 'BCD 2399', '18 : 15', '14', 'April', '2021', 'Visa', 38000),
(9, 'C009', 'Sunil', 'CAV 7676', '19 : 17', '23', 'February', '2021', 'Cash', 28500),
(12, '123456789v', 'Kumara', 'BAD 3400', '19 : 8', '4', 'Octorber', '2021', 'Master', 42000),
(14, 'C013', 'Namal', 'CGC 8877', '19 : 48', '15', 'February', '2020', 'Cash', 14000),
(16, 'C0017', 'Kumudu', 'LKJ 3003', '6 : 35', '14', 'May', '2021', 'Cash', 23000),
(17, 'C0018', 'Perera', 'UTY 6777', '6 : 39', '8', 'June', '2021', 'Cash', 30000),
(18, 'C019', 'Amaani', 'CCG 5612', '6 : 40', '19', 'July', '2021', 'Visa', 35000),
(19, 'C020', 'Shehan', 'BNH 9070', '6 : 41', '30', 'August', '2021', 'Cheque', 45000),
(20, 'C022', 'Sunimal', 'HJI 6675', '22 : 21', '19', 'Octorber', '2021', 'Cheque', 36000),
(21, 'C023', 'Lalitha', 'DFR 4592', '6 : 50', '8', 'December', '2021', 'Cash', 28000),
(35, 'q', 'q', 'q', '8 : 23', '10', 'September', '2021', 'Cheque', 10000),
(37, 'C025', 'Melani', 'GCT 3682', '7 : 58', '18', 'April', '2019', 'Cash', 5000),
(38, 'C001', 'Kamal', 'VGF 7637', '8 : 40', '11', 'September', '2021', 'Cash', 7500),
(39, 'C026', 'Nuwan', 'RVG 6567', '8 : 42', '23', 'March', '2019', 'Cash', 20000),
(40, 'hhh', 'hhh', 'hh', '1 : 16', '12', 'September', '2020', 'Cash', 7550),
(48, 'y', 'y', 'y', '10 : 33', '26', 'January', '2021', 'Cheque', 100000),
(49, 'a', 'a', 'a', '10 : 38', '11', 'January', '2019', 'Cheque', 13000),
(50, 'c1001', 'Arjuna', 'CVF 2345', '12 : 36', '17', 'November', '2021', 'Cash', 49300),
(51, 'C00111', 'Ranasginghe', 'FGT 5276', '12 : 44', '17', 'September', '2021', 'Cash', 31150),
(53, 'c1234', 'Amal', 'VGT 6454', '12 : 57', '17', 'April', '2021', 'Cash', 34700),
(54, 'c1222', 'Vipun', 'fdt 5342', '13 : 0', '17', 'March', '2021', 'Cash', 1200),
(55, 'c111', 'xxxx', 'gggg', '15 : 7', '17', 'September', '2021', 'Cash', 26000),
(56, 'c122', 'harin', 'vfg 6454', '15 : 8', '17', 'September', '2021', 'Visa', 1230),
(57, 'C911', 'Denuwan', 'FCD 3546', '18 : 18', '1', 'September', '2019', 'Cash', 1000),
(58, 'C912', 'Binara', 'CDD 4561', '18 : 20', '2', 'September', '2019', 'Cheque', 1600),
(59, 'C913', 'Hiruna', 'ADW 7786', '18 : 21', '3', 'September', '2019', 'Cheque', 1300),
(60, 'C914', 'Vimal', 'FRT 4546', '12:78', '4', 'September', '2019', 'Cash', 2000),
(61, 'C915', 'Nimal', 'FRT 4546', '12:78', '5', 'September', '2019', 'Cash', 900);

-- --------------------------------------------------------

--
-- Table structure for table `mytable2`
--

CREATE TABLE `mytable2` (
  `ID` int(11) NOT NULL,
  `SType` varchar(30) NOT NULL,
  `Price` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `mytable2`
--

INSERT INTO `mytable2` (`ID`, `SType`, `Price`) VALUES
(1, 'Service type 1', '15000'),
(2, 'Service type 2', '13000'),
(3, 'Service type 3', '15000'),
(4, 'Service type 4', '19000'),
(5, 'Service type 5', '3000'),
(6, 'Service type 6', '9000'),
(7, 'Service type 7', '11000'),
(8, 'Service type 8', '12000');

-- --------------------------------------------------------

--
-- Table structure for table `suppliermanage`
--

CREATE TABLE `suppliermanage` (
  `sup_id` int(10) NOT NULL,
  `companyname` varchar(30) NOT NULL,
  `address` varchar(60) NOT NULL,
  `country` varchar(20) NOT NULL,
  `contactnumber` int(10) NOT NULL,
  `email` varchar(30) NOT NULL,
  `Item_Id` varchar(50) NOT NULL,
  `itemtype` varchar(20) NOT NULL,
  `description` varchar(200) NOT NULL,
  `date` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `suppliermanage`
--

INSERT INTO `suppliermanage` (`sup_id`, `companyname`, `address`, `country`, `contactnumber`, `email`, `Item_Id`, `itemtype`, `description`, `date`) VALUES
(1, 'Chevron Lubricants Lanka PLC', 'No. 200, Nawala Road Narahenpita Colombo', 'sri lanka', 2147483647, 'cxservice@z.co.nz', '8', 'Lubricant', 'Chevron Lubricants Lanka PLC engages in blending, manufacturing, importing, distributing, and marke', '2021-03-05'),
(2, 'LAUGFS Lubricants Ltd', 'LAUGFS Lubricants Ltd 6th Floor, No. 101', 'sri lanka', 1145245251, 'info@laugfslubricants.com', '7', 'lubricant', 'LAUGFS Lubricants Limited is a fully owned subsidiary of LAUGFS Holdings which is the only Sri Lankan company to launch its own brand, offering to every class of motor vehicles and industries', '2021-12-11'),
(3, 'LAUGFS Lubricants Ltd', 'LAUGFS Lubricants Ltd 6th Floor, No. 101', 'sri lanka', 1145245251, 'info@laugfslubricants.com', '11', 'lubricant', 'LAUGFS Lubricants Limited is a fully owned subsidiary of LAUGFS Holdings which is the only Sri Lankan company to launch its own brand, offering to every class of motor vehicles and industries', '2020-12-13'),
(4, 'Shell gas', 'Carel van Bylandtlaan 16, 2596 HR The Hague, The Netherlands', 'Netherlands', 2147483647, 'info@laugfslubricants.com', '9', 'lubricant', 'Shell is a global group of energy and petrochemical companies that aims to meet the world’s growing need for more and cleaner energy solutions in ways that are economically, environmentally and social', '2021-13-14'),
(5, 'IMS Trading Pvt Ltd | Spare pa', 'No: 257/1, Kendaliyadda Paluwa, Ganemulla 11020', 'sri lanka', 2147483642, 'info@IMSt.com', '8', 'Spare Parts', 'Japanese, Indian, Malaysian, Chinese & Korean Auto Parts Suppliers in Sri Lanka. ... All the body parts available in IMS TRADING (PVT) LTD, in ganemulla', '2021-12-09'),
(6, 'New InterLanka Auto Spares Com', '541 Old Kottawa Rd, Nugegoda 10280', 'sri lanka', 1245678906, 'Newinternetlanka@gmail.com', '6', 'Car body', 'Japanese, Indian, Malaysian, Chinese & Korean Auto Parts Suppliers in Sri Lanka. ... All the body parts available', '2019-11-10'),
(7, 'American Car Craft', '18924 Sakera Rd, Hudson, FL 34667, United States', 'United states', 727861150, 'americancar@gmail.com', '8', ' spare parts', 'Find all the latest handcrafted custom car accessories we\'ve designed to make your car a winner at the shows!  All our ﻿new custom car products﻿ are made to fit stock vehicles and are hand-made from 1', '2021-08-09'),
(8, 'McLarens Lubricants Ltd - Mobi', '284 Vauxhall St,', 'America', 114321180, 'Mclerens@yahoo.com', '8', 'Lubricant', 'McLarens Lubricants Limited, known for its superior range of automotive, marine, industrial, aviation lubricants and chemical products, operates under the authorized distributorship of the largest pub', '2020-08-15'),
(12, 'Hasala Auto Parts', '278 High Level Rd, Pannipitiya 10230', ' sri lanka', 775349352, 'hasla@gmail.com', '1', ' spare parts', 'Hasala Auto Parts is a Auto machine shop located in Pannipitiya 10230. It is one of the 622 Auto machine shops in Sri Lanka. Address of Hasala Auto Parts is Weera Mawatha, Pannipitiya 10230, Sri Lanka', '2021-02-28'),
(13, 'all parts', 'Allparts (Watford) Unit 5B Shakespeare Industrial Estate Sha', 'united Kingdom', 1923239039, 'allparts@gmail.com', '8', ' spare parts', 'We offer an on-demand delivery service to independent garages and workshops, but at Allparts we think that top service is more than delivering the right parts at the right time. This is why we further', '2021-05-08'),
(14, 'Napa Auto Parts - Himel Motor ', 'Napa Auto Parts - Himel Motor Supply', 'united Kingdom', 337445320, 'Napaauto@gmail.com', '16', 'Paints', 'sdf', '2020-06-03');

-- --------------------------------------------------------

--
-- Table structure for table `vehicle_table`
--

CREATE TABLE `vehicle_table` (
  `Vid` int(11) NOT NULL,
  `Vehicle_num` varchar(50) NOT NULL,
  `Vcol` varchar(50) NOT NULL,
  `Vtype` varchar(50) NOT NULL,
  `Vcon` varchar(50) NOT NULL,
  `NIC` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `vehicle_table`
--

INSERT INTO `vehicle_table` (`Vid`, `Vehicle_num`, `Vcol`, `Vtype`, `Vcon`, `NIC`) VALUES
(1, 'CAF-1550', 'Grey', 'Car', 'Good', '990021122V'),
(2, 'CAL-8351', 'Red', 'Jeep', 'Good', '990712603V'),
(3, 'CAB-1121', 'White', 'Bike', 'Avarage', '199921212V'),
(4, 'KM-1245', 'Red', 'Car', 'Good', '996423603V');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bookingtb`
--
ALTER TABLE `bookingtb`
  ADD PRIMARY KEY (`BID`);

--
-- Indexes for table `completetable`
--
ALTER TABLE `completetable`
  ADD PRIMARY KEY (`C_Index`);

--
-- Indexes for table `currentstock_table`
--
ALTER TABLE `currentstock_table`
  ADD PRIMARY KEY (`Item_Id`);

--
-- Indexes for table `customertable`
--
ALTER TABLE `customertable`
  ADD PRIMARY KEY (`S_Code`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `EmployeeSalaryID` (`EmployeeSalaryID`);

--
-- Indexes for table `liststockcost`
--
ALTER TABLE `liststockcost`
  ADD UNIQUE KEY `StockCostID` (`StockCostID`);

--
-- Indexes for table `liststock_table`
--
ALTER TABLE `liststock_table`
  ADD PRIMARY KEY (`Order_Id`);

--
-- Indexes for table `mytable`
--
ALTER TABLE `mytable`
  ADD PRIMARY KEY (`S_ID`);

--
-- Indexes for table `mytable2`
--
ALTER TABLE `mytable2`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `suppliermanage`
--
ALTER TABLE `suppliermanage`
  ADD PRIMARY KEY (`sup_id`);

--
-- Indexes for table `vehicle_table`
--
ALTER TABLE `vehicle_table`
  ADD PRIMARY KEY (`Vid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bookingtb`
--
ALTER TABLE `bookingtb`
  MODIFY `BID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `completetable`
--
ALTER TABLE `completetable`
  MODIFY `C_Index` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97;

--
-- AUTO_INCREMENT for table `currentstock_table`
--
ALTER TABLE `currentstock_table`
  MODIFY `Item_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `customertable`
--
ALTER TABLE `customertable`
  MODIFY `S_Code` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `ID` int(45) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `ID` int(45) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `liststock_table`
--
ALTER TABLE `liststock_table`
  MODIFY `Order_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `mytable`
--
ALTER TABLE `mytable`
  MODIFY `S_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=62;

--
-- AUTO_INCREMENT for table `mytable2`
--
ALTER TABLE `mytable2`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `suppliermanage`
--
ALTER TABLE `suppliermanage`
  MODIFY `sup_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `vehicle_table`
--
ALTER TABLE `vehicle_table`
  MODIFY `Vid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
