DROP TABLE IF EXISTS `pocarquitecturedb`.`StaffType`;

CREATE TABLE `pocarquitecturedb`.`StaffType` (
  `StaffTypeId` INT NOT NULL,
  `NameStaff` VARCHAR(45) NULL,
  `DescriptionStaff` VARCHAR(45) NULL,
  PRIMARY KEY (`StaffTypeId`),
  UNIQUE INDEX `NameStaff_UNIQUE` (`NameStaff` ASC) VISIBLE)
  ENGINE=InnoDB 
  DEFAULT CHARSET=ascii;

DROP TABLE IF EXISTS `pocarquitecturedb`.`Staff`;
  
CREATE TABLE `pocarquitecturedb`.`Staff` (
  `StaffId` INT NOT NULL,
  `PersonId` VARCHAR(9) NOT NULL,
  `Certification` VARCHAR(200) NULL,
  `DeparmentId` INT NULL,
  `Education` VARCHAR(200) NULL,
  `Joined` DATETIME NOT NULL,
  `MovedFired` DATETIME NULL,
  `Languages` VARCHAR(200) NULL,
  PRIMARY KEY (`StaffId`),
  CONSTRAINT UC_Staff UNIQUE (PersonId,DeparmentId,Joined)
  )
  ENGINE=InnoDB DEFAULT CHARSET=ascii;

DROP TABLE IF EXISTS `pocarquitecturedb`.`Hospital`;
  
CREATE TABLE `pocarquitecturedb`.`Hospital` (
  `HospitalId` INT NOT NULL,
  `Address` VARCHAR(45) NULL,
  `Name` VARCHAR(45) NULL,
  `Phone` VARCHAR(15) NULL,
  `Code` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`HospitalId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = ascii;

INSERT INTO `pocarquitecturedb`.`Hospital`
(`HospitalId`,
`Address`,
`Name`,
`Phone`,
`Code`)
VALUES
(1,
"1111",
"Virgen Macarena",
"+34687691033",
"H1");


DROP TABLE IF EXISTS `pocarquitecturedb`.`Person`;

CREATE TABLE `pocarquitecturedb`.`Person` (
  `Dni` VARCHAR(9) NOT NULL,
  `BirthDate` DATETIME NULL,
  `FamilyName` VARCHAR(45) NULL,
  `Gender` VARCHAR(10) NULL,
  `GivenName` VARCHAR(45) NULL,
  `HomeAddress` VARCHAR(45) NULL,
  `MiddleName` VARCHAR(45) NULL,
  `Name` VARCHAR(45) NULL,
  `Phone` INT NULL,
  `Title` VARCHAR(45) NULL,
  PRIMARY KEY (`Dni`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = ascii;

DROP TABLE IF EXISTS `pocarquitecturedb`.`Patient`;

CREATE TABLE `pocarquitecturedb`.`Patient` (
  `PatiendId` INT NOT NULL auto_increment,
  `PersonId` VARCHAR(9) NOT NULL,
  `AcceptedDate` DATETIME NULL,
  `Age` INT NULL,
  `History` VARCHAR(45) NULL,
  `Sickness` VARCHAR(45) NULL,
  `SpecialRequirements` VARCHAR(45) NULL,
  `Allergies` VARCHAR(45) NULL,
  PRIMARY KEY (`PatiendId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = ascii;

DROP TABLE IF EXISTS `pocarquitecturedb`.`Department`;

CREATE TABLE `pocarquitecturedb`.`Department` (
  `DepartmentId` INT NOT NULL,
  `TypeOfDepartment` VARCHAR(45) NULL,
  `HospitalId` INT NULL,
  `Code` VARCHAR(15) NOT NULL,
  `Name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`DepartmentId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = ascii;

INSERT INTO `pocarquitecturedb`.`Department`
(`DepartmentId`,
`TypeOfDepartment`,
`HospitalId`,
`Code`,
`Name`)
VALUES
(1,
"TIPO1",
1,
"H1D1",
"GERIATRIA");


DROP TABLE IF EXISTS `pocarquitecturedb`.`AppConfiguration`;

CREATE TABLE `pocarquitecturedb`.`AppConfiguration` (
  `AppConfigurationId` INT NOT NULL,
  `Name` VARCHAR(45) NULL,
  `Value` VARCHAR(1000) NULL,
  `Description` VARCHAR(200) NULL,
  PRIMARY KEY (`AppConfigurationId`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = ascii;

INSERT INTO `pocarquitecturedb`.`AppConfiguration`
(`AppConfigurationId`,
`Name`,
`Value`,
`Description`)
VALUES
(1,
'Cacheable',
'True',
'Enable the cache in the application');


