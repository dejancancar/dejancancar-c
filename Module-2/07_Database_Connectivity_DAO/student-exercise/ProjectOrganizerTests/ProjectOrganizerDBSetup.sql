
DELETE FROM project_employee
DELETE FROM project
DELETE FROM employee
DELETE FROM department



-- Fill department and project before employee or project_employee because they have no foreign key dependencies
INSERT INTO department (name) VALUES ('Department of Redundancy');
INSERT INTO department (name) VALUES ('Network Administration');
INSERT INTO department (name) VALUES ('Research and Development');
INSERT INTO department (name) VALUES ('Store Support');

INSERT INTO project (name, from_date, to_date) VALUES ('Project X', '1961-03-01', '2002-08-31');
INSERT INTO project (name, from_date, to_date) VALUES ('Forelorn Cupcake', '2010-01-01', '2011-10-15');
INSERT INTO project (name, from_date, to_Date) VALUES ('The Never-ending Project', '2010-09-01', '2016-03-21');
INSERT INTO project (name, from_date, to_date) VALUES ('Absolutely Done By', '2015-06-30', '2017-06-30');
INSERT INTO project (name, from_date, to_date) VALUES ('Royal Shakespeare', '2015-10-15', '2016-03-14');
INSERT INTO project (name, from_date, to_date) VALUES ('Plan 9', '2014-10-01', '2017-12-31');

INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Department of Redundancy'), 'Fredrick', 'Keppard', '1953-07-15', 'M', '2001-04-01', 'Chief Head Honcho');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Department of Redundancy'), 'Flo', 'Henderson', '1990-12-28', 'F', '2011-08-01', 'Floss Replenisher');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Network Administration'), 'Franklin', 'Trumbauer', '1980-07-14', 'M', '1998-09-01', 'Money Guy');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Network Administration'), 'Delora', 'Coty', '1976-07-04', 'F', '2009-03-01', 'Fax Sender and Paper Copier');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Network Administration'), 'Sid', 'Goodman', '1972-06-04', 'F', '1998-09-01', 'Coffee Delivery Tech');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Research and Development'), 'Mary Lou', 'Wolinski', '1983-04-08', 'F', '2012-04-01', 'Royal Pain in the...');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Research and Development'), 'Jammie', 'Mohl', '1987-11-11', 'M', '2013-02-16', 'Following the Boss Around');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Research and Development'), 'Neville', 'Zellers', '1983-04-04', 'M', '2013-07-01', 'Payroll Glitch');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Research and Development'), 'Meg', 'Buskirk', '1987-05-13', 'F', '2007-11-01', 'Official Go Getter');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Research and Development'), 'Matthew', 'Duford', '1968-04-05', 'M', '2016-02-16', 'Cat Lover');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Store Support'), 'Jarred', 'Lukach', '1981-09-25', 'M', '2003-05-01', 'Fish Enthusiast');
INSERT INTO employee (department_id, first_name, last_name, birth_date, gender, hire_date, job_title)
VALUES ((SELECT department_id FROM department WHERE name = 'Store Support'), 'Chris', 'Christie', '1980-03-17', 'M', '1999-08-01', 'Grain Sales');

INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'Project X'), (SELECT employee_id FROM employee WHERE first_name = 'Franklin' AND last_name = 'Trumbauer'));
INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'Project X'), (SELECT employee_id FROM employee WHERE first_name = 'Sid' AND last_name = 'Goodman'));
INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'The Never-ending Project'), (SELECT employee_id FROM employee WHERE first_name = 'Fredrick' AND last_name = 'Keppard'));
INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'The Never-ending Project'), (SELECT employee_id FROM employee WHERE first_name = 'Sid' AND last_name = 'Goodman'));
INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'The Never-ending Project'), (SELECT employee_id FROM employee WHERE first_name = 'Jammie' AND last_name = 'Mohl'));
INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'Absolutely Done By'), (SELECT employee_id FROM employee WHERE first_name = 'Flo' AND last_name = 'Henderson'));
INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'Absolutely Done By'), (SELECT employee_id FROM employee WHERE first_name = 'Mary Lou' AND last_name = 'Wolinski'));
INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'Royal Shakespeare'), (SELECT employee_id FROM employee WHERE first_name = 'Neville' AND last_name = 'Zellers'));
INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'Royal Shakespeare'), (SELECT employee_id FROM employee WHERE first_name = 'Meg' AND last_name = 'Buskirk'));
INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'Plan 9'), (SELECT employee_id FROM employee WHERE first_name = 'Sid' AND last_name = 'Goodman'));
INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'Plan 9'), (SELECT employee_id FROM employee WHERE first_name = 'Matthew' AND last_name = 'Duford'));
INSERT INTO project_employee (project_id, employee_id) VALUES ((SELECT project_id FROM project WHERE name = 'Plan 9'), (SELECT employee_id FROM employee WHERE first_name = 'Jarred' AND last_name = 'Lukach'));
