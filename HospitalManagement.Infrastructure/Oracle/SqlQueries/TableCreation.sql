CREATE TABLE Doctor (
    Id NUMBER PRIMARY KEY,
    Name VARCHAR2(255) NOT NULL,
    PhoneNumber VARCHAR2(50),
    Salary NUMBER(10, 2) NOT NULL,
    Address VARCHAR2(500),
    Specialization VARCHAR2(255),  
    DateTime DATE   
);