CREATE TABLE prisoner (
    Prisoner_Id INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Date_of_Birth DATE,
    Gender ENUM('Male', 'Female', 'Other'),
    Admission_Date DATE NOT NULL,
    Release_Date DATE,
    Cell_Number VARCHAR(20),
    Crime_Committed TEXT,
    Sentence_Length INT, 
    Status_of_Prisoner ENUM('Active', 'Released', 'Transferred') DEFAULT 'Active'
);

CREATE TABLE visitor (
    Visitor_Id INT PRIMARY KEY AUTO_INCREMENT,
    First_Name VARCHAR(50) NOT NULL,
    Last_Name VARCHAR(50) NOT NULL,
    Relationship_to_Prisoner VARCHAR(50),  
    Prisoner_Id INT NOT NULL,
    Visit_Date DATE NOT NULL,
    Time_In TIME,
    Time_Out Time,
    notes TEXT,
    FOREIGN KEY (Prisoner_Id) REFERENCES prisoner(Prisoner_Id)
);


CREATE TABLE staff (
    Staff_Id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    role_of_staff VARCHAR(50) NOT NULL,  
    department VARCHAR(50),  
    job_date DATE,
    shift VARCHAR(20),  
    contact_number VARCHAR(15),
    email VARCHAR(100)
);


CREATE TABLE incident (
    Incident_Id INT PRIMARY KEY AUTO_INCREMENT,
    Prisoner_Id INT NOT NULL,
    Staff_Id INT,  
    incident_type VARCHAR(50) NOT NULL,  
    incident_date DATE NOT NULL,
    incident_time TIME,
    location VARCHAR(100),  
    FOREIGN KEY (Prisoner_Id) REFERENCES prisoner(Prisoner_Id),
    FOREIGN KEY (Staff_Id) REFERENCES staff(Staff_Id)
);