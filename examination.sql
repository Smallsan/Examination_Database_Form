-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 11, 2023 at 05:05 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `examination`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_account`
--

CREATE TABLE `admin_account` (
  `user_id` int(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin_account`
--

INSERT INTO `admin_account` (`user_id`, `username`, `password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `english_questions`
--

CREATE TABLE `english_questions` (
  `English_Question_No` int(11) NOT NULL,
  `English_Question` varchar(100) DEFAULT NULL,
  `Choice_A` varchar(100) DEFAULT NULL,
  `Choice_B` varchar(100) DEFAULT NULL,
  `Choice_C` varchar(100) DEFAULT NULL,
  `Choice_D` varchar(100) DEFAULT NULL,
  `Right_Answer_Letter` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `english_questions`
--

INSERT INTO `english_questions` (`English_Question_No`, `English_Question`, `Choice_A`, `Choice_B`, `Choice_C`, `Choice_D`, `Right_Answer_Letter`) VALUES
(0, NULL, NULL, NULL, NULL, NULL, NULL),
(1, 'What is the currency of Japan?', 'log(base 2)(8) = 3', 'statistics', 'Fluid Dynamics', 'statistics', 'D'),
(2, 'What is the chemical symbol for oxygen?', 'x + y = z', 'statistics', 'Astrophysics', 'probability', 'D'),
(3, 'What is the boiling point of water in Celsius?', 'sin(x) + cos(y) = 1', 'number theory', 'Particle Physics', 'geometry', 'C'),
(4, 'Who wrote the novel \'Pride and Prejudice\'?', 'F = ma', 'statistics', 'Mechanics', 'statistics', 'A'),
(5, 'What is the national animal of Australia?', 'πr^2', 'number theory', 'Electromagnetism', 'number theory', 'C'),
(6, 'What is the capital of France?', 'log(base 2)(8) = 3', 'discrete mathematics', 'Thermodynamics', 'algebra', 'D'),
(7, 'What is the chemical symbol for gold?', 'a^2 + b^2 = c^2', 'calculus', 'Electromagnetism', 'calculus', 'D'),
(8, 'What is the boiling point of water in Celsius?', 'E = mc^2', 'trigonometry', 'Nuclear Physics', 'geometry', 'A'),
(9, 'What is the formula for calculating the area of a circle?', 'F = ma', 'geometry', 'Quantum Mechanics', 'differential equations', 'D'),
(10, 'Who painted the Mona Lisa?', 'sin(x) + cos(y) = 1', 'discrete mathematics', 'Nuclear Physics', 'trigonometry', 'A'),
(11, 'What is the capital of France?', 'πr^2', 'probability', 'Quantum Mechanics', 'number theory', 'D'),
(12, 'Who invented the telephone?', 'E = mc^2', 'probability', 'Astrophysics', 'calculus', 'A'),
(13, 'Who is the current President of the United States?', 'E = mc^2', 'statistics', 'Thermodynamics', 'statistics', 'B'),
(14, 'What is the chemical symbol for oxygen?', '√(a^2 + b^2) = c', 'geometry', 'Statistical Mechanics', 'probability', 'C'),
(15, 'What is the capital of France?', 'πr^2', 'calculus', 'Mechanics', 'number theory', 'D'),
(16, 'What is the chemical symbol for oxygen?', '∫(2x + 3)dx = x^2 + 3x + C', 'discrete mathematics', 'Nuclear Physics', 'trigonometry', 'A'),
(17, 'Who is the author of \'To Kill a Mockingbird\'?', 'F = ma', 'trigonometry', 'Particle Physics', 'statistics', 'C'),
(18, 'Who discovered gravity?', 'x + y = z', 'probability', 'Optics', 'trigonometry', 'B'),
(19, 'What is the chemical symbol for oxygen?', 'log(base 2)(8) = 3', 'trigonometry', 'Nuclear Physics', 'number theory', 'A'),
(20, 'What is the official language of Brazil?', 'a^2 + b^2 = c^2', 'discrete mathematics', 'Astrophysics', 'statistics', 'A');

-- --------------------------------------------------------

--
-- Table structure for table `math_questions`
--

CREATE TABLE `math_questions` (
  `Math_Question_No` int(11) NOT NULL,
  `Math_Question` varchar(100) DEFAULT NULL,
  `Choice_A` varchar(100) DEFAULT NULL,
  `Choice_B` varchar(100) DEFAULT NULL,
  `Choice_C` varchar(100) DEFAULT NULL,
  `Choice_D` varchar(100) DEFAULT NULL,
  `Right_Answer_Letter` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `math_questions`
--

INSERT INTO `math_questions` (`Math_Question_No`, `Math_Question`, `Choice_A`, `Choice_B`, `Choice_C`, `Choice_D`, `Right_Answer_Letter`) VALUES
(1, 'Find the slope of the line passing through (2', 'πr^2', 'algebra', 'Fluid Dynamics', 'probability', 'C'),
(2, '5) and (4', 'F = ma', 'probability', 'Particle Physics', 'probability', 'B'),
(3, 'What is the value of cos(45 degrees)?', 'πr^2', 'differential equations', 'Statistical Mechanics', 'graph theory', 'B'),
(4, 'Find the derivative of f(x) = sin(x) + cos(x)', 'log(base 2)(8) = 3', 'discrete mathematics', 'Quantum Mechanics', 'calculus', 'A'),
(5, 'What is the value of cos(45 degrees)?', 'x + y = z', 'calculus', 'Electromagnetism', 'calculus', 'B'),
(6, 'Solve for x: 3x - 7 = 14', 'a^2 + b^2 = c^2', 'discrete mathematics', 'Fluid Dynamics', 'statistics', 'D'),
(7, '5) and (4', 'F = ma', 'statistics', 'Mechanics', 'differential equations', 'D'),
(8, 'What is the value of tan(30 degrees)?', 'a^2 + b^2 = c^2', 'probability', 'Statistical Mechanics', 'trigonometry', 'D'),
(9, 'Solve the quadratic equation: 2x^2 - 7x + 3 = 0', 'sin(x) + cos(y) = 1', 'probability', 'Statistical Mechanics', 'differential equations', 'D'),
(10, 'What is the square root of 16?', 'E = mc^2', 'differential equations', 'Particle Physics', 'algebra', 'B'),
(11, 'What is the square root of 16?', 'sin(x) + cos(y) = 1', 'geometry', 'Mechanics', 'probability', 'C'),
(12, 'Solve for x: 3x - 7 = 14', 'x + y = z', 'calculus', 'Electromagnetism', 'geometry', 'D'),
(13, 'Solve the quadratic equation: 2x^2 - 7x + 3 = 0', 'x + y = z', 'probability', 'Statistical Mechanics', 'algebra', 'A'),
(14, '9)', 'log(base 2)(8) = 3', 'probability', 'Fluid Dynamics', 'graph theory', 'B'),
(15, 'Solve for x: 3x - 7 = 14', '∫(2x + 3)dx = x^2 + 3x + C', 'algebra', 'Particle Physics', 'statistics', 'D'),
(16, 'Find the integral of f(x) = 2x + 3', 'πr^2', 'geometry', 'Statistical Mechanics', 'graph theory', 'D'),
(17, '5) and (4', 'e^(iπ) + 1 = 0', 'number theory', 'Quantum Mechanics', 'algebra', 'D'),
(18, 'Find the derivative of f(x) = sin(x) + cos(x)', 'x + y = z', 'probability', 'Thermodynamics', 'probability', 'D'),
(19, 'Find the integral of f(x) = 2x + 3', 'πr^2', 'differential equations', 'Astrophysics', 'number theory', 'C'),
(20, 'What is the value of cos(60 degrees)?', 'log(base 2)(8) = 3', 'differential equations', 'Electromagnetism', 'probability', 'A');

-- --------------------------------------------------------

--
-- Table structure for table `science_questions`
--

CREATE TABLE `science_questions` (
  `Science_Question_No` int(11) NOT NULL,
  `Science_Question` varchar(100) DEFAULT NULL,
  `Choice_A` varchar(100) DEFAULT NULL,
  `Choice_B` varchar(100) DEFAULT NULL,
  `Choice_C` varchar(100) DEFAULT NULL,
  `Choice_D` varchar(100) DEFAULT NULL,
  `Right_Answer_Letter` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `science_questions`
--

INSERT INTO `science_questions` (`Science_Question_No`, `Science_Question`, `Choice_A`, `Choice_B`, `Choice_C`, `Choice_D`, `Right_Answer_Letter`) VALUES
(0, NULL, NULL, NULL, NULL, NULL, NULL),
(1, 'banana', 'Geology', 'discrete mathematics', 'Particle Physics', 'graph theory', 'A'),
(2, 'What is the formula for calculating force?', 'Biology', 'trigonometry', 'Mechanics', 'number theory', 'D'),
(3, 'What is the function of mitochondria?', 'Computer Science', 'linear algebra', 'Quantum Mechanics', 'statistics', 'C'),
(4, 'What is the pH of a neutral solution?', 'Physics', 'statistics', 'Fluid Dynamics', 'statistics', 'B'),
(5, 'What is the chemical syold?', 'Microbiology', 'statistics', 'Fluid Dynamics', 'trigonometry', 'A'),
(6, 'What is the function of chloroplasts?', 'Geography', 'probability', 'Mechanics', 'number theory', 'B'),
(7, 'What is the formula for calculating force?', 'Zoology', 'number theory', 'Particle Physics', 'algebra', 'D'),
(8, 'What is the atomic number of oxygen?', 'Psychology', 'statistics', 'Fluid Dynamics', 'calculus', 'B'),
(9, 'What is the process of converting solid to gas called?', 'Mathematics', 'discrete mathematics', 'Fluid Dynamics', 'graph theory', 'A'),
(10, 'What is the study of matter and energy called?', 'Astronomy', 'algebra', 'Optics', 'graph theory', 'C'),
(11, 'What is the speed of light?', 'Botany', 'statistics', 'Thermodynamics', 'algebra', 'B'),
(12, 'What is the atomic number of oxygen?', 'Environmental Science', 'geometry', 'Statistical Mechanics', 'calculus', 'D'),
(13, 'What is the study of matter and energy called?', 'Chemistry', 'calculus', 'Statistical Mechanics', 'differential equations', 'B'),
(14, 'What is the boiling point of water?', 'Geology', 'statistics', 'Thermodynamics', 'graph theory', 'A'),
(15, 'What is the formula for calculating velocity?', 'Psychology', 'trigonometry', 'Electromagnetism', 'probability', 'D'),
(16, 'What is the largest organ in the human body?', 'Botany', 'linear algebra', 'Thermodynamics', 'statistics', 'D'),
(17, 'What is the boiling point of water?', 'Anthropology', 'calculus', 'Thermodynamics', 'trigonometry', 'A'),
(18, 'What is the formula for photosynthesis?', 'Chemistry', 'trigonometry', 'Particle Physics', 'statistics', 'B'),
(19, 'What is the atomic number of oxygen?', 'Psychology', 'geometry', 'Thermodynamics', 'differential equations', 'B'),
(20, 'What is the formula for calculating force?', 'Neuroscience', 'linear algebra', 'Particle Physics', 'number theory', 'D'),
(21, 'hsdfjshfskjh', 'hjkhkj', 'hkjh', 'hkjhkj', 'hjkhkj', 'D');

-- --------------------------------------------------------

--
-- Table structure for table `student_information`
--

CREATE TABLE `student_information` (
  `student_number` int(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `age` int(50) NOT NULL,
  `student_year` varchar(50) NOT NULL,
  `college` varchar(50) NOT NULL,
  `address` varchar(200) NOT NULL,
  `course` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_information`
--

INSERT INTO `student_information` (`student_number`, `name`, `age`, `student_year`, `college`, `address`, `course`) VALUES
(-1273728152, 'Christian', 7, '3rd Year', 'hjhjkhjkhjk', 'yuiyuiyuiyui', 'uiyyuiyuiyui'),
(5, 'test', 4, '3rd Year', 't', 't', 't'),
(6786, 'tytutu', 3, '3rd Year', 'tuytuy', 'tuytuy', 'ghjgjh'),
(7897, 'gjhgjh', 5, '3rd Year', 'gh', 'v', 'vb'),
(678678, 'ghj', 2, '2nd Year', 'gjhgjhgjh', 'gjhg', 'ghjg'),
(7289279, 'Christian', 3, '3rd Year', 'h', 'jkhkjhjkhjk', 'j'),
(567567567, 'fhgffghfgh', 4, '5th Year', 'rtrtyrty', 'fghfghfghfgh', 'ghffghfghfghfgh'),
(878967567, 'Christian', 22, '3rd Year', 'ENGINEERING', 'blk 20 lot 23', 'IT');

-- --------------------------------------------------------

--
-- Table structure for table `student_scores`
--

CREATE TABLE `student_scores` (
  `student_no` int(20) NOT NULL,
  `math_score` int(2) NOT NULL,
  `english_score` int(2) NOT NULL,
  `science_score` int(2) NOT NULL,
  `technology_score` int(2) NOT NULL,
  `total_score` int(3) NOT NULL,
  `date_taken` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_scores`
--

INSERT INTO `student_scores` (`student_no`, `math_score`, `english_score`, `science_score`, `technology_score`, `total_score`, `date_taken`) VALUES
(5, 0, 0, 0, 0, 0, '2023-12-08'),
(7878, 4, 3, 5, 1, 13, '2023-12-11'),
(678678, 3, 2, 1, 1, 7, '2023-12-11');

-- --------------------------------------------------------

--
-- Table structure for table `technology_questions`
--

CREATE TABLE `technology_questions` (
  `Tech_Question_No` int(11) NOT NULL,
  `Tech_Question` varchar(100) DEFAULT NULL,
  `Choice_A` varchar(100) DEFAULT NULL,
  `Choice_B` varchar(100) DEFAULT NULL,
  `Choice_C` varchar(100) DEFAULT NULL,
  `Choice_D` varchar(100) DEFAULT NULL,
  `Right_Answer_Letter` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `technology_questions`
--

INSERT INTO `technology_questions` (`Tech_Question_No`, `Tech_Question`, `Choice_A`, `Choice_B`, `Choice_C`, `Choice_D`, `Right_Answer_Letter`) VALUES
(1, 'How does virtual reality technology work?', 'Chemistry', 'Data Science', 'Quantum Mechanics', 'differential equations', 'A'),
(2, 'What is the role of data analytics in business decision-making?', 'Neuroscience', 'Blockchain', 'Particle Physics', 'differential equations', 'B'),
(3, 'How does machine learning improve recommendation systems?', 'Psychology', 'Artificial Intelligence', 'Optics', 'statistics', 'A'),
(4, 'What are the latest trends in mobile app development?', 'Environmental Science', 'Robotics', 'Quantum Mechanics', 'trigonometry', 'D'),
(5, 'What are the potential risks of using public Wi-Fi networks?', 'Anthropology', 'Cybersecurity', 'Nuclear Physics', 'number theory', 'A'),
(6, 'What are the benefits of using a content management system?', 'Biochemistry', 'Data Science', 'Quantum Mechanics', 'number theory', 'C'),
(7, 'What are the advantages of using cloud computing?', 'Mathematics', 'Cybersecurity', 'Nuclear Physics', 'geometry', 'C'),
(8, 'What are the best practices for software testing?', 'Genetics', 'Machine Learning', 'Thermodynamics', 'trigonometry', 'D'),
(9, 'How does machine learning improve recommendation systems?', 'Biochemistry', 'Virtual Reality', 'Nuclear Physics', 'trigonometry', 'C'),
(10, 'What are the challenges of implementing big data solutions?', 'Botany', 'Internet of Things', 'Nuclear Physics', 'linear algebra', 'D'),
(11, 'What are the best practices for data backup and recovery?', 'Neuroscience', 'Virtual Reality', 'Electromagnetism', 'number theory', 'D'),
(12, 'What is the best programming language for beginners?', 'Botany', 'Artificial Intelligence', 'Fluid Dynamics', 'probability', 'C'),
(13, 'What are the latest trends in mobile app development?', 'Sociology', 'Augmented Reality', 'Statistical Mechanics', 'graph theory', 'A'),
(14, 'How does artificial intelligence impact our daily lives?', 'Biology', 'Machine Learning', 'Astrophysics', 'differential equations', 'B'),
(15, 'What is the best programming language for beginners?', 'Microbiology', 'Internet of Things', 'Mechanics', 'calculus', 'D'),
(16, 'How does the Internet of Things (IoT) impact our daily lives?', 'Environmental Science', 'Robotics', 'Electromagnetism', 'graph theory', 'A'),
(17, 'What are the advantages of using open-source software?', 'Sociology', 'Cybersecurity', 'Mechanics', 'probability', 'A'),
(18, 'What are the essential skills for a cybersecurity professional?', 'Geography', 'Robotics', 'Optics', 'statistics', 'B'),
(19, 'What is the best programming language for beginners?', 'Microbiology', 'Virtual Reality', 'Astrophysics', 'differential equations', 'C'),
(20, 'What are the potential risks of using public Wi-Fi networks?', 'Biology', 'Augmented Reality', 'Statistical Mechanics', 'linear algebra', 'C');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_account`
--
ALTER TABLE `admin_account`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `english_questions`
--
ALTER TABLE `english_questions`
  ADD PRIMARY KEY (`English_Question_No`);

--
-- Indexes for table `math_questions`
--
ALTER TABLE `math_questions`
  ADD PRIMARY KEY (`Math_Question_No`);

--
-- Indexes for table `science_questions`
--
ALTER TABLE `science_questions`
  ADD PRIMARY KEY (`Science_Question_No`);

--
-- Indexes for table `student_information`
--
ALTER TABLE `student_information`
  ADD PRIMARY KEY (`student_number`);

--
-- Indexes for table `student_scores`
--
ALTER TABLE `student_scores`
  ADD PRIMARY KEY (`student_no`);

--
-- Indexes for table `technology_questions`
--
ALTER TABLE `technology_questions`
  ADD PRIMARY KEY (`Tech_Question_No`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
