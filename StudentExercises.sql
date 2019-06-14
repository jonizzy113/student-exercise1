-- USE MASTER
-- GO

-- IF NOT EXISTS (
--     SELECT [name]
--     FROM sys.databases
--     WHERE [name] = N'StudentExercises'
-- )
-- CREATE DATABASE StudentExercises
-- GO

-- USE StudentExercises
-- GO

CREATE TABLE Cohort (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    CohortName VARCHAR(55)
);

CREATE TABLE Student (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(55) NOT NULL,
    LastName VARCHAR(55) NOT NULL,
    Slack VARCHAR(55),
    CohortId INTEGER NOT NULL,
    CONSTRAINT FK_Student_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
);



CREATE TABLE Instructor (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    FirstName VARCHAR(55) NOT NULL,
    LastName VARCHAR(55) NOT NULL,
    Slack VARCHAR(55),
    Specialty VARCHAR,
    CohortId INTEGER NOT NULL,
    CONSTRAINT FK_Instructor_Cohort FOREIGN KEY (CohortId) REFERENCES Cohort(Id)
);

CREATE TABLE Exercise (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    ExerciseName VARCHAR(55),
    ExerciseLanguage VARCHAR(55)
);

CREATE TABLE StudentExercise (
    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
    ExerciseId INTEGER NOT NULL,
    StudentId INTEGER NOT NULL,
    CONSTRAINT FK_StudentExercise_Exercise FOREIGN KEY (ExerciseId) REFERENCES Exercise (Id),
    CONSTRAINT FK_StudentExercise_Student FOREIGN KEY (StudentId) REFERENCES Student (Id)
);

-- populate tables
-- INSERT INTO Cohort (CohortName) VALUES ('Cohort 30');
-- INSERT INTO Cohort (CohortName) VALUES ('Cohort 31');
-- INSERT INTO Cohort (CohortName) VALUES ('Cohort 32');
SELECT * FROM Cohort;

-- INSERT INTO Student (FirstName, LastName, CohortId) VALUES ('Jonathan', 'Schaffer', 2);
-- INSERT INTO Student (FirstName, LastName, CohortId) VALUES ('Jameka', 'Echols', 1);
-- INSERT INTO Student (FirstName, LastName, CohortId) VALUES ('Billy', 'Mathison', 3);
-- INSERT INTO Student (FirstName, LastName, CohortId) VALUES ('Clif', 'Happy', 2);
-- INSERT INTO Student (FirstName, LastName, CohortId) VALUES ('Alex', 'Thacker', 2);

SELECT * FROM Student;
-- INSERT INTO Instructor (FirstName, LastName, CohortId) VALUES ('Jisie', 'David', 1);
-- INSERT INTO Instructor (FirstName, LastName, CohortId) VALUES ('Steve', 'David', 2);
-- INSERT INTO Instructor (FirstName, LastName, CohortId) VALUES ('Andy', 'David', 2);
-- INSERT INTO Instructor (FirstName, LastName, CohortId) VALUES ('Joe', 'David', 3);
SELECT * FROM Instructor;

-- INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('National Parks', 'JavaScript');
-- INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('Kandy Korner', 'React');
-- INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('Kennel', 'React');
-- INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('Ternary Travler', 'JavaScript');
-- INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('Daily Journal', 'JavaScript');
-- INSERT INTO Exercise (ExerciseName, ExerciseLanguage) VALUES ('Planets', 'JavaScript');


SELECT * FROM Exercise;

-- INSERT INTO StudentExercise (ExerciseId, StudentId) VALUES (1, 1);
-- INSERT INTO StudentExercise (ExerciseId, StudentId) VALUES (2, 3);
-- INSERT INTO StudentExercise (ExerciseId, StudentId) VALUES (3, 2);
-- INSERT INTO StudentExercise (ExerciseId, StudentId) VALUES (4, 4);
-- INSERT INTO StudentExercise (ExerciseId, StudentId) VALUES (5, 5);
-- INSERT INTO StudentExercise (ExerciseId, StudentId) VALUES (6, 6);
SELECT * FROM StudentExercise;